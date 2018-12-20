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

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            
            using (var context = new STOK_TAKIPEntities())
            {
                try
                {
                    using (MD5 md5 = MD5.Create())
                    {
                        string strHashedPassword = md5.Hash(password);
                        context.loginCheck(username, strHashedPassword);
                        using (STOK_TAKIPEntities db = new STOK_TAKIPEntities())
                        {
                            var result = db.users.Select(s => s).Where(x => x.username == username);
                            ucProduct.Instance = null;
                            ucLoans.Instance = null;
                            frm login = new frm();
                            string[] authors = {
                                result.First().username,
                                result.First().name,
                                result.First().lastName,
                                result.First().id.ToString(),
                                result.First().userTypeID.ToString()
                            };
                            login.GetUser = authors;
                            this.Visible = false;
                            login.ShowDialog();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Username or password wrong!");
                }

            }
        }
    }
}