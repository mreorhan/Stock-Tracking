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
    public partial class ucProduct : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucProduct _instance;
        public static ucProduct Instance {
            get
            {
                if (_instance == null)
                    _instance = new ucProduct();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public ucProduct()
        {
            InitializeComponent();
            this.Refresh();
            gridControl1.Refresh();
           
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            using (STOK_TAKIPEntities db = new STOK_TAKIPEntities()) { 
                var model2 = db.products.Select(m => new
                {
                    m.productName,
                    m.productFeatures,
                    m.purchase.purchasedDate,
                    m.purchase.purchasePrice,
                    m.purchase.purchasedByID,
                    m.pieces,
                    In_Stock = m.purchase.isDeleted == false ? "Yes" : "No"

                });
            gridControl1.DataSource = model2.ToList();
            }
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
