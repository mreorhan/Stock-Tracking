﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

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
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string name = txtName.Text;
            string lastname = txtLastName.Text;
            int userRole = cbUserRole.SelectedIndex+1;


            using (var context = new STOK_TAKIPEntities())
            {
                try
                {
                    using (MD5 md5 = MD5.Create())
                    {
                        string strHashedPassword = md5.Hash(password);
                        context.addUser(name, lastname, username, strHashedPassword, userRole);
                        ucUsers.Instance = null;
                        ucLoantoUser.Instance = null;
                        MessageBox.Show("User Created");
                        txtName.Text = "";
                        txtLastName.Text = "";
                        txtPassword.Text = "";
                        txtUsername.Text = "";
                        cbUserRole.SelectedIndex = -1;
                    }
                }
                catch
                {
                    MessageBox.Show("Username or password wrong!");
                }

            }
        }

        private void ucAddUser_Load(object sender, EventArgs e)
        {
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            foreach (var item in db.userTypes)
                    cbUserRole.Items.Add(item.userType1);
           
        }
    }
}
