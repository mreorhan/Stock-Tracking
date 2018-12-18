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
    public partial class ucLoans : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucLoans _instance;
        public static ucLoans Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLoans();
                return _instance;
            }
        }
        public ucLoans()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {

        }

        private void ucLoans_Load(object sender, EventArgs e)
        {
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            var model = from p in db.products
                        join l in db.loanDetails on p.loanID equals l.loanID
                        select new
                        {
                            name = p.productName,
                            loan = l.loanID

                        };
            var model2 = db.products
                .Join(db.loanDetails, l => l.loanID, p => p.loanID,
                (l, p) => new { l, p })
                .Select(m => new {
                m.p.user.name,
                m.p.user.lastName,
                m.p.loanDate,
                m.l.productName,
                m.l.productFeatures,
            });
            gridControl1.DataSource = model2.ToList();
        }
    }
}
