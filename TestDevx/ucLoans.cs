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
            var model = from l in db.loanDetails
                        join p in db.products on l.productID equals p.productID
                        join u in db.users on l.userID equals u.id
                        select new
                        {
                           p.productName,
                           p.pieces,
                          Who= u.name+" "+u.lastName,
                          l.loanDate,
                         How_Many= l.loanPieces
                        };
            var model2 = db.loanDetails
                .Join(db.products, p => p.productID, l => l.productID,
                (l, p) => new { l, p })

                .Join(db.users, u => u.l.userID, p => p.id,
                (u, l) => new { u, l })

                .Select(m => new {
                    m.l.name,
                    m.l.lastName,
                    

            });
            gridControl1.DataSource = model.ToList();
        }
    }
}
