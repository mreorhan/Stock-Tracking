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
    public partial class ucAccount : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucAccount _instance;
        public static ucAccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAccount();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public static string[] user;

        public static void getUser(string[] u)
        {
            user = u;
        }

        public ucAccount()
        {
            InitializeComponent();
        }

        private void ucAccount_Load(object sender, EventArgs e)
        {
            lblUsername.Text = user[0];
            lblName.Text = user[1];
            lblLastName.Text = user[2];
        }
    }
}
