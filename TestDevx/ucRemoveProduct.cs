using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace TestDevx
{
    public partial class ucRemoveProduct : DevExpress.XtraEditors.XtraUserControl
    {
        private List<product> productList = new List<product>();
        private static ucRemoveProduct _instance;
        public static ucRemoveProduct Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucRemoveProduct();
                return _instance;
            }
        }
        public ucRemoveProduct()
        {
            InitializeComponent();
            getData();
            
        }
        public void getData()
        {
            cbProducts.Items.Clear();
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            foreach (var item in db.products)
            {
                if (item.isAvailable == 1)
                {
                   
                    cbProducts.Items.Add(item.productName);
                    productList.Add(item);
                }
            }
        }
        private void ucRemoveProduct_Load(object sender, EventArgs e)
        {
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            using (var context = new STOK_TAKIPEntities())
            {
                product p = new product();
                var result = productList.Find(x => x.productName == cbProducts.SelectedItem.ToString());
                try
                {
                    var productID = new SqlParameter("@productID", result.productID);
                    context.Database.ExecuteSqlCommand("exec removeProduct @productID",
                    productID);
                    MessageBox.Show("The transaction was successful!");
                    getData();
                    ucProduct.Instance = null;
                    ucLoantoUser.Instance = null;
                }
                catch (SqlException err)
                {
                    switch (err.Number)
                    {
                        case 35100:
                            MessageBox.Show("There are users associated with this product!");
                            break;
                        default:
                            MessageBox.Show("This product is not deleting!");
                            throw;
                    }
                }
            }
        }
    }
}
