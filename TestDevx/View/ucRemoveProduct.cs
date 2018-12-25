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
using TestDevx.Model;

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
            cbRemoveProducts.Items.Clear();
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            foreach (var item in db.products)
            {
                if (item.isAvailable == 1)
                {
                    cbRemoveProducts.Items.Add(item.productName);
                    productList.Add(item);
                }
            }
        }
        private void ucRemoveProduct_Load(object sender, EventArgs e)
        {
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {
            
            if(cbRemoveProducts.SelectedIndex==-1)
            {
                MessageBox.Show("You must fill in the required fields!");
                return;
            }
            
                product p = new product();
                var result = productList.Find(x => x.productName == cbRemoveProducts.SelectedItem.ToString());
                try
                {
                using (var context2 = new STOK_TAKIPEntities())
                {
                    //Delete Product from stored procedure
                    var productID = new SqlParameter("@productID", result.productID);
                    context2.Database.ExecuteSqlCommand("exec removeProduct @productID",productID);
                    MessageBox.Show("The transaction was successful!");
                    getData();
                    gridRegistered.Visible = false;
                    //Refresh related instance
                    ucProduct.Instance = null;
                    ucLoantoUser.Instance = null;
                    ucUnusedProducts.Instance = null;
                    cbRemoveProducts.SelectedIndex = -1;

                }


            }
                catch (SqlException err)
                {
                    formLogin.Instance = null;
                    switch (err.Number)
                    {
                        //If the product registered before
                        case 35100:
                            {
                                MessageBox.Show("There are users associated with this product!");
                                
                                STOK_TAKIPEntities db = new STOK_TAKIPEntities();
                            var model = from l in db.loanDetails
                                        join pr in db.products on l.productID equals pr.productID
                                        join u in db.users on l.userID equals u.id
                                        where l.loanPieces >= 1
                                        where pr.productID == result.productID
                                        select new
                                        {
                                            pr.productName,
                                            pr.productFeatures,
                                            Who = u.name + " " + u.lastName,
                                            l.loanDate,
                                            How_Many = l.loanPieces
                                        };
                            gridRegistered.Visible = true;
                            gridRegistered.DataSource = model.ToList();
                            }
                        break;
                        default:
                            MessageBox.Show("This product is not deleting!");
                            throw;
                    }
                }
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoveProduct.Visible = true;
        }
    }
}
