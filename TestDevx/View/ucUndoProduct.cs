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
using DevExpress.Data.Extensions;
using TestDevx.Model;

namespace TestDevx
{
    public partial class ucUndoProduct : DevExpress.XtraEditors.XtraUserControl
    {
        private List<int> productList= new List<int>();
        private string[] list;
        private static ucUndoProduct _instance;
        public static ucUndoProduct Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUndoProduct();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public ucUndoProduct()
        {
            InitializeComponent();

            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            foreach (var item in db.users)
            {
                cbUser.Items.Add(item.id + " - " + item.name + " " + item.lastName);
            }
           
        }

        private void ucUndoProduct_Load(object sender, EventArgs e)
        {

        }
        

        private void cbUser_SelectedValueChanged(object sender, EventArgs e)
        {
            list = cbUser.SelectedItem.ToString().Split('-');
            cbProducts.SelectedIndex = -1;
            cbProducts.Items.Clear();

           
            using (STOK_TAKIPEntities db = new STOK_TAKIPEntities()) {
               var products = db.getLoanbyUserID3(int.Parse(list[0]));
                foreach(var i in products)
                {
                    cbProducts.Items.Add(i.Pieces+" - "+i.productName+"-"+i.productID);
                    lblAvailable.Text = i.Pieces.ToString();
                }
            }
            
            
        }

        private void cbProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbProducts.SelectedIndex != -1)
            {
                lblAvailable.Text = cbProducts.SelectedItem.ToString().Split('-')[0];
                tableLayoutPanel1.Visible = true;
            }
            else
                tableLayoutPanel1.Visible = true;

        }

        private void ucUndoProduct_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void btnUndoLoan_Click(object sender, EventArgs e)
        {
            int oProp= cbProducts.SelectedIndex;
            if (cbProducts.SelectedIndex != -1 && cbUser.SelectedIndex!=-1 && txtPiece.Text != "")
            {

                using (var context = new STOK_TAKIPEntities())
                {
                    string txtuserID= cbUser.SelectedItem.ToString().Split('-')[0];
                    string txtProductID = cbProducts.SelectedItem.ToString().Split('-')[2];
                    string txtpieces = txtPiece.Text;
                    //get sql parameters for addLoan procedure
                    var userID = new SqlParameter("@userID", int.Parse(txtuserID));
                    var productID = new SqlParameter("@productID", int.Parse(txtProductID));
                    var piece = new SqlParameter("@piece", int.Parse(txtpieces));
                    try
                    {
                        //execute addLoan stored procedure
                        context.Database.ExecuteSqlCommand("exec undoProduct @userID , @productID , @piece",
                        userID, productID,piece);
                        MessageBox.Show("The transaction was successful!");
                        txtPiece.Text = "";
                        ucLoans.Instance = null;
                        ucProduct.Instance = null;
                        ucLoantoUser.Instance = null;
                        ucRemoveProduct.Instance = null;
                    }
                    catch
                    {
                        MessageBox.Show("The transaction was failed!");
                    }
                }
            }
            else
                MessageBox.Show("You must fill in the required fields");
        }
    }
}
