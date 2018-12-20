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
    public partial class ucUsers : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucUsers _instance;
        public static ucUsers Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUsers();
                return _instance;
            }
        }
        public ucUsers()
        {
            InitializeComponent();
        }


        private void ucUsers_Load(object sender, EventArgs e)
        {
            using (STOK_TAKIPEntities db = new STOK_TAKIPEntities())
            {
                var model = db.users.Select(m => new
                {
                   Username= m.username,
                   Name= m.name,
                   Last_Name = m.lastName,
                   User_Type = m.userType.userType1,
                   m.lastLogin
                });
                gridControl1.DataSource = model.ToList();
            }
        }
    }
}
