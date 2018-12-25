using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using TestDevx.Model;

namespace TestDevx
{
    public partial class ucEditUser : DevExpress.XtraEditors.XtraUserControl
    {
        private List<user> userList = new List<user>();
        private static ucEditUser _instance;
        public static ucEditUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucEditUser();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public ucEditUser()
        {
            InitializeComponent();
        }

        private void ucEditUser_Load(object sender, EventArgs e)
        {
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();

            foreach (var item in db.users)
            {
                    cbUsers.Items.Add(item.id+"-"+item.name +" " +item.lastName);
                    userList.Add(item);
            }
        }

        private void cbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] user = cbUsers.SelectedItem.ToString().Split('-');
            var result = userList.Find(x => x.id == int.Parse(user[0]));
            txtUserName.Text = result.username;
            tableLayoutPanel1.Visible = true;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            string[] user = cbUsers.SelectedItem.ToString().Split('-');
            var result = userList.Find(x => x.id == int.Parse(user[0]));
            if(txtPassword.Text != txtPasswordRetry.Text)
            {
                MessageBox.Show("Passwords don't match!");
                return;
            }
            if(result.id.ToString()!="" && txtUserName.Text!="" && txtPassword.Text != "") {
                user user1 = new user();
                user1.username = txtUserName.Text;
                user1.id = result.id;
                user1.password = txtPassword.Text;
                Controller.UserController.editUser(user1);

            }
            else
                MessageBox.Show("You must fill the required fields!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string[] user = cbUsers.SelectedItem.ToString().Split('-');
            var result = userList.Find(x => x.id == int.Parse(user[0]));
            if (result.id.ToString() != "")
            {

                using (var context = new STOK_TAKIPEntities())
                {
                    //get sql parameters for deleteuser procedure
                    var userID = new SqlParameter("@userID", result.id);

                    try
                    {
                        //execute deleteuser stored procedure
                        context.Database.ExecuteSqlCommand("exec deleteUser @userID",
                        userID);
                        MessageBox.Show("The transaction was successful!");
                        ucLoans.Instance = null;
                        ucProduct.Instance = null;
                        ucRemoveProduct.Instance = null;
                        ucUndoProduct.Instance = null;
                        ucDepartmentChief.Instance = null;
                    }
                    catch
                    {
                        MessageBox.Show("There are products with this user!");
                    }

                }

            }
            else
                MessageBox.Show("You must fill the required fields!");
        }
    }
}
