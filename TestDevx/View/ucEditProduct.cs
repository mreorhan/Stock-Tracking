﻿using System;
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
    public partial class ucEditProduct : DevExpress.XtraEditors.XtraUserControl
    {
        private List<product> productList = new List<product>();
        private static ucEditProduct _instance;
        public static ucEditProduct Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEditProduct();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public ucEditProduct()
        {
            InitializeComponent();
        }

        private void ucEditProduct_Load(object sender, EventArgs e)
        {
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
        
        private void cbProducts_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var result = productList.Find(x => x.productName == cbProducts.SelectedItem.ToString());
            txtProductName.Text = result.productName.ToString();
            txtProductFeatures.Text = result.productFeatures.ToString();
            txtPiece.Text = result.pieces.ToString();
            datePurchasedDate.Text = result.purchase.purchasedDate;
            tableLayoutPanel1.Visible = true;
        }

        private void btnRemoveProduct_Click(object sender, EventArgs e)
        {

            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            //Change To Upper Case First Letter
            txtProductName.Text = textInfo.ToTitleCase(txtProductName.Text.ToLower());
            txtProductName.Select(txtProductName.Text.Length, 0);

            txtProductFeatures.Text = textInfo.ToTitleCase(txtProductFeatures.Text.ToLower());
            txtProductFeatures.Select(txtProductFeatures.Text.Length, 0);

            if (string.IsNullOrWhiteSpace(txtProductName.Text) || string.IsNullOrWhiteSpace(txtProductFeatures.Text))
            {
                MessageBox.Show("You must fill in the required fields");
                return;
            }
            if (txtPiece.Text=="0" || txtPiece.Text == "")
            {
                MessageBox.Show("You need to write minimum 1 for number.");
                return;
            }
            var result = productList.Find(x => x.productName == cbProducts.SelectedItem.ToString());

            using (var context = new STOK_TAKIPEntities())
            {
                //get sql parameters for addLoan procedure
                var productID = new SqlParameter("@productID", result.productID);
                var productName = new SqlParameter("@productName", txtProductName.Text);
                var productFeatures = new SqlParameter("@productFeatures", txtProductFeatures.Text);
                var productPiece = new SqlParameter("@productPiece", txtPiece.Text);

                try
                {
                    //execute addLoan stored procedure
                    context.Database.ExecuteSqlCommand("exec editProduct @productID , @productName , @productFeatures , @productPiece",
                    productID, productName, productFeatures, productPiece);
                    MessageBox.Show("The transaction was successful!");
                    txtPiece.Text = "";
                    ucLoans.Instance = null;
                    ucProduct.Instance = null;
                    ucRemoveProduct.Instance = null;
                    ucUndoProduct.Instance = null;
                    ucDepartmentChief.Instance = null;
                }
                catch
                {
                    MessageBox.Show("The transaction was failed!");
                }

            }
        }
    }
}
