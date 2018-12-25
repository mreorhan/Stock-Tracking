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
    public partial class ucDepartmentChief : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucDepartmentChief _instance;
        public static ucDepartmentChief Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucDepartmentChief();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public ucDepartmentChief()
        {
            InitializeComponent();
        }

        private void ucDepartmentChief_Load(object sender, EventArgs e)
        {
            ucLoantoUser.Instance = null;
            //We can see registered products in here (department chief)
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            var model = from l in db.loanDetails
                        join p in db.products on l.productID equals p.productID
                        join u in db.users on l.userID equals u.id
                        where (l.loanPieces >= 1)
                        where (u.userTypeID==3)
                        select new
                        {
                            p.productName,
                            p.productFeatures,
                            Who = u.name + " " + u.lastName,
                            l.loanDate,
                            How_Many = l.loanPieces
                        };

            gridControl1.DataSource = model.ToList();
        }
    }
}
