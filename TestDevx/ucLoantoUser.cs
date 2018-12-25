using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestDevx
{
    public partial class ucLoantoUser : DevExpress.XtraEditors.XtraUserControl
    {
        private List<product> productList = new List<product>();
        private static ucLoantoUser _instance;
        public static ucLoantoUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLoantoUser();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public ucLoantoUser()
        {
            InitializeComponent();
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            
            foreach (var item in db.users)
            {
                cbUser.Items.Add(item.id+" - "+item.name +" " + item.lastName);
            }
            foreach (var item in db.products)
            {
                if (item.isAvailable == 1) { 
                    cbProducts.Items.Add(item.productName);
                    productList.Add(item);
                }
            }
        }

        private void ucLoantoUser_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] list = cbUser.SelectedItem.ToString().Split('-');
            MessageBox.Show(list[0]);
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            if (txtPiece.Text == "" || cbUser.SelectedIndex==-1 || string.IsNullOrWhiteSpace(cbProducts.Text.ToString()))
            {
                MessageBox.Show("You must fill in the required fields");
            }
            else { 
            if (int.Parse(lblAvailable.Text) >= int.Parse(txtPiece.Text))
            {
                // Zimmetleme işlemleri burada gerçekleştiriliyor
                string[] user = cbUser.SelectedItem.ToString().Split('-');
                string[] product = cbProducts.SelectedItem.ToString().Split('-');
                var result = productList.Find(x => x.productName == cbProducts.SelectedItem.ToString());
                loanDetail l = new loanDetail();
                product p = new product();
                l.productID = result.productID;
                l.loanDate = DateTime.Now.ToString();
                l.userID = int.Parse(user[0]);
                l.loanPieces = int.Parse(txtPiece.Text);
                l.loanByID = 1;

                //Send Loan Controller
                Controller.LoanController.loanToUser(l);
                txtPiece.Text = "";
                cbUser.SelectedIndex = -1;
                }
            else
                MessageBox.Show("You can't write more than the maximum number of products!");
            }
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] product = cbProducts.SelectedItem.ToString().Split('-');
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            var result = productList.Find(x => x.productName == cbProducts.SelectedItem.ToString());
            if (result.pieces == 0) { 
                txtPiece.Visible = false;
                label5.Text = "";
                lblAvailable.Text = "Not available";
                tableLayoutPanel1.Visible = false;
            }
            else
            {
                txtPiece.Visible = true;
                label5.Text = "Piece";
                lblAvailable.Text = result.pieces.ToString();
                tableLayoutPanel1.Visible = true;
            }


        }

        private void txtPiece_KeyPress(object sender, KeyPressEventArgs e)
        {
        }
    }
}
