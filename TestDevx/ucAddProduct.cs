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
    public partial class ucAddProduct : DevExpress.XtraEditors.XtraUserControl
    {
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
            int purchaseID = 6;
           //TODO:KULLAN BUNU int addedBy = 1;
            product p = new product();
            purchase purc = new purchase();
            p.productName = txtProductName.Text;
            p.productFeatures = txtProductFeatures.Text;
            purc.purchasedDate = datePurchasedDate.Text;
            p.pieces = int.Parse(txtPiece.Text);
            purc.purchasedByID = purchaseID;
            purc.purchasePrice = int.Parse(txtPrice.Text);
            using (var context = new STOK_TAKIPEntities())
            {
                var productName = new SqlParameter("@productName", p.productName);
                var productFeatures = new SqlParameter("@productFeatures", p.productFeatures);
                var purchasedDate = new SqlParameter("@purchasedDate", purc.purchasedDate);
                var purchasedByID = new SqlParameter("@purchasedByID", purc.purchasedByID);
                var purchasedPrice = new SqlParameter("@purchasedPrice", purc.purchasePrice);
                var pieces = new SqlParameter("@pieces", p.pieces);

                context.Database.ExecuteSqlCommand("exec createNewProduct @productName , @productFeatures , @purchasedDate , @purchasedByID, @purchasedPrice, @pieces",
                productName, productFeatures, purchasedDate, purchasedByID, purchasedPrice, pieces);

            }

        }
    }
}
