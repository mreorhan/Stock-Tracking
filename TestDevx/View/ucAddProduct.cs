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
using System.Globalization;
using TestDevx.Model;

namespace TestDevx
{
    public partial class ucAddProduct : DevExpress.XtraEditors.XtraUserControl
    {
        public int userID;
        //Using Singleton 
        private static ucAddProduct _instance;
        public static ucAddProduct Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAddProduct();
                return _instance;
            }
        }
        public ucAddProduct()
        {
            InitializeComponent();
        }

        private void btnAddPRoduct_Click(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtProductFeatures.Text) || string.IsNullOrWhiteSpace(txtPrice.Text)|| string.IsNullOrWhiteSpace(datePurchasedDate.Text))
            {
                MessageBox.Show("You must fill in the required fields");
                return;

            }
            if(txtPiece.Text=="0")
            {
                MessageBox.Show("You need to write minimum 1 for pieces");
                return;
            }
            if (int.Parse(txtPrice.Text) < 0)
            {
                MessageBox.Show("You need to write positive value for price");
                return;
            }

            //Change To Upper Case First Letter
            txtProductName.Text = textInfo.ToTitleCase(txtProductName.Text.ToLower());
            txtProductName.Select(txtProductName.Text.Length, 0);

            txtProductFeatures.Text = textInfo.ToTitleCase(txtProductFeatures.Text.ToLower());
            txtProductFeatures.Select(txtProductFeatures.Text.Length, 0);


            //TODO:KULLAN BUNU int addedBy = 1;
            product p = new product();
            purchase purc = new purchase();
            p.productName = txtProductName.Text;
            p.productFeatures = txtProductFeatures.Text;
            purc.purchasedDate = datePurchasedDate.Text;
            p.pieces = int.Parse(txtPiece.Text);
            purc.purchasedByID = userID;
            purc.purchasePrice = int.Parse(txtPrice.Text);

            Controller.ProductController.addProduct(p, purc);

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
