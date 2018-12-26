using System;
using System.Windows.Forms;
using System.Globalization;
using TestDevx.Model;

namespace TestDevx
{
    public partial class ucAddUser : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucAddUser _instance;
        public static ucAddUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucAddUser();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public ucAddUser()
        {
            InitializeComponent();
        }

        private void btnAddPRoduct_Click(object sender, EventArgs e)
        {
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            //Change To Upper Case First Letter
            txtName.Text = textInfo.ToTitleCase(txtName.Text.ToLower());
            txtName.Select(txtName.Text.Length, 0);

            txtLastName.Text = textInfo.ToTitleCase(txtLastName.Text.ToLower());
            txtLastName.Select(txtLastName.Text.Length, 0);

            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string lastname = txtLastName.Text;
            int userRole = cbUserRole.SelectedIndex+1;

            if (username!="" && password!="" && name!="" && lastname!="" && cbUserRole.SelectedIndex != -1) {

                user user1 = new user();
                user1.username = txtUsername.Text;
                user1.name = txtName.Text;
                user1.lastName = txtLastName.Text;
                user1.password = txtPassword.Text;
                user1.userTypeID = cbUserRole.SelectedIndex + 1;

                //Call addUser method from controller
                Controller.UserController.addUser(user1);

                txtName.Text = "";
                txtLastName.Text = "";
                txtPassword.Text = "";
                txtUsername.Text = "";
                cbUserRole.SelectedIndex = -1;

            }
            else
                MessageBox.Show("You must fill in the required fields");

        }

        private void ucAddUser_Load(object sender, EventArgs e)
        {
            // Get whole users from database
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            foreach (var item in db.userTypes)
                    cbUserRole.Items.Add(item.userType1);
        }
    }
}
