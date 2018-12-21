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
            set
            {
                _instance = value;
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
            //zimmetlenen ürünleri görüntülüyoruz
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            var model = from l in db.loanDetails
                        join p in db.products on l.productID equals p.productID
                        join u in db.users on l.userID equals u.id
                        select new
                        {
                            p.productName,
                            p.productFeatures,
                            Who = u.name + " " + u.lastName,
                            l.loanDate,
                            byd = u.username,
                            How_Many = l.loanPieces
                        };

            gridControl1.DataSource = model.ToList();
        }
    }
}
