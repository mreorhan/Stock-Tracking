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
using TestDevx.Model;

namespace TestDevx
{
    public partial class ucUnusedProducts : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucUnusedProducts _instance;
        public static ucUnusedProducts Instance
        {
            get
            {
               if(_instance==null)
                   _instance = new ucUnusedProducts();
               return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        
        public ucUnusedProducts()
        {
            InitializeComponent();

            
        }

        private void ucUnusedProducts_Load(object sender, EventArgs e)
        {
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            var model = db.products.Select(m => new
            {
                m.productName,
                m.productFeatures,
                m.pieces,
                m.isAvailable
            }).Where(x => x.isAvailable == 0);
            gridUnused.DataSource = model.ToList();
        }
    }
}
