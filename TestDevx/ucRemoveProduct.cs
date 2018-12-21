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
            set
            {
                _instance = value;
            }
        }
        public ucRemoveProduct()
        {
            InitializeComponent();
            getData();
            
        }
        public void getData()
        {
            // Refresh Items After Deleted Product
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
            if(cbProducts.SelectedIndex==-1)
            {
                MessageBox.Show("You must fill in the required fields!");
                return;
            }
            using (var context = new STOK_TAKIPEntities())
            {
                product p = new product();
                var result = productList.Find(x => x.productName == cbProducts.SelectedItem.ToString());
                try
                {
                    //Delete Product from stored procedure
                    var productID = new SqlParameter("@productID", result.productID);
                    context.Database.ExecuteSqlCommand("exec removeProduct @productID",productID);
                    MessageBox.Show("The transaction was successful!");
                    getData();
                    gridRegistered.Visible = false;
                    //Refresh related instance
                    ucProduct.Instance = null;
                    ucLoantoUser.Instance = null;
                    ucUnusedProducts.Instance = null;
                }
                catch (SqlException err)
                {
                    switch (err.Number)
                    {
                        //If the product registered before
                        case 35100:
                            MessageBox.Show("There are users associated with this product!");
                            gridRegistered.Visible = true;
                            gridRegistered.DataSource = context.list(result.productID).ToList();
                        break;
                        default:
                            MessageBox.Show("This product is not deleting!");
                            throw;
                    }
                }
            }
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveProduct.Visible = true;
        }
    }
}
