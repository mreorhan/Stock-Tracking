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
                var model = from m in db.products
                            join purc in db.purchases on m.purchaseID equals purc.purchaseID
                            join u in db.users on purc.purchasedByID equals u.id
                            where m.isAvailable == 1
                            select new
                            {
                                m.productName,
                                m.productFeatures,
                                m.purchase.purchasedDate,
                                m.purchase.purchasePrice,
                                Purchased_By = u.name + " " + u.lastName,
                                Number = m.pieces,
                                In_Stock = m.purchase.isDeleted == false ? "Yes" : "No"
                            };
               
                gridControl1.DataSource = model.ToList();
            }
        }

        private void ucProduct_Load(object sender, EventArgs e)
        {
            ucUndoProduct.Instance = null;
        }
    }
}
