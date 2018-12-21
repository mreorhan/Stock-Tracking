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
            using (var context = new STOK_TAKIPEntities())
            {

            }
        }
    }
}
