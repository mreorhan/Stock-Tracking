using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;
using System.Data.SqlClient;
using TestDevx.Model;

namespace TestDevx
{
    public partial class formLogin : DevExpress.XtraEditors.XtraForm
    {
        private static formLogin _instance;
        public static formLogin Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new formLogin();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            user user1 = new user();
            user1.username = txtUsername.Text;
            user1.password = txtPassword.Text;
            Controller.UserController.checkUser(user1);

        }

        private void formLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}