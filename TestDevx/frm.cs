using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestDevx
{
    public partial class frm : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        private string[] getUser;
        public string[] GetUser
        {
            get { return getUser; }
            set { getUser = value; }
        }
        public frm()
        {
            InitializeComponent();
            /* WHY AM I USING SINGLETON WITH GENERIC METHOD: (stackoverflow)
             * If a user can provide a type to as a generic type argument then
             * they can also create instances of that type. In other words,
             * you cannot create a generic singleton factory - it undermines the pattern itself.
             */
        }
        

        private void aceCategories_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucProduct.Instance))
            {
                container.Controls.Add(ucProduct.Instance);
                ucProduct.Instance.Dock = DockStyle.Fill;
                ucProduct.Instance.BringToFront();
            }
            ucProduct.Instance.BringToFront();
        }

        private void aceProducts_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucLoans.Instance))
            {
                container.Controls.Add(ucLoans.Instance);
                ucLoans.Instance.Dock = DockStyle.Fill;
                ucLoans.Instance.BringToFront();
            }
            ucLoans.Instance.BringToFront();
        }

        private void btnAddNewProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(ucAddProduct.Instance))
            {
                container.Controls.Add(ucAddProduct.Instance);
                ucAddProduct.Instance.Dock = DockStyle.Fill;
                ucAddProduct.Instance.BringToFront();
            }
            ucAddProduct.Instance.BringToFront();
            ucAddProduct.Instance.userID =int.Parse(getUser[3]);
        }

        private void accordionControlElement4_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucUsers.Instance))
            {
                container.Controls.Add(ucUsers.Instance);
                ucUsers.Instance.Dock = DockStyle.Fill;
                ucUsers.Instance.BringToFront();
            }
            ucUsers.Instance.BringToFront();
        }

        private void btnProductEmbezzle_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(ucLoantoUser.Instance))
            {
                container.Controls.Add(ucLoantoUser.Instance);
                ucLoantoUser.Instance.Dock = DockStyle.Fill;
                ucLoantoUser.Instance.BringToFront();
            }
            ucLoantoUser.Instance.BringToFront();
        }

        private void acUnused_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucUnusedProducts.Instance))
            {
                container.Controls.Add(ucUnusedProducts.Instance);
                ucUnusedProducts.Instance.Dock = DockStyle.Fill;
                ucUnusedProducts.Instance.BringToFront();
            }
            ucUnusedProducts.Instance.BringToFront();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(ucRemoveProduct.Instance))
            {
                container.Controls.Add(ucRemoveProduct.Instance);
                ucRemoveProduct.Instance.Dock = DockStyle.Fill;
                ucRemoveProduct.Instance.BringToFront();
            }
            ucRemoveProduct.Instance.BringToFront();
        }
        

        private void btnLogout_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            this.Visible = false;
            formLogin login = new formLogin();
            login.ShowDialog();
        }

        private void frm_Load(object sender, EventArgs e)
        {
            if (getUser[4].ToString() == "2")
            {
                btnAddUser.Links[0].Visible = false;
            }
            else if(getUser[4].ToString() == "3")
            {
                accordionControl1.Visible = false;
                btnAddUser.Links[0].Visible = false;

                ribbonPageGroup1.Visible = false;
                if (!container.Controls.Contains(ucLoans.Instance))
                {
                    container.Controls.Add(ucLoans.Instance);
                    ucLoans.Instance.Dock = DockStyle.Fill;
                    ucLoans.Instance.BringToFront();
                }
                ucLoans.Instance.BringToFront();
            }
            lblName.Text = getUser[1].ToString() + " " + getUser[2].ToString() + "(" + getUser[0].ToString() + ")";
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(ucAccount.Instance))
            {
                container.Controls.Add(ucAccount.Instance);
                ucAccount.Instance.Dock = DockStyle.Fill;
                ucAccount.Instance.BringToFront();
            }
            ucAccount.Instance.BringToFront();
        }

        private void btnEditProduct_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(ucEditProduct.Instance))
            {
                container.Controls.Add(ucEditProduct.Instance);
                ucEditProduct.Instance.Dock = DockStyle.Fill;
                ucEditProduct.Instance.BringToFront();
            }
            ucEditProduct.Instance.BringToFront();
        }

        private void btnAddUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(ucAddUser.Instance))
            {
                container.Controls.Add(ucAddUser.Instance);
                ucAddUser.Instance.Dock = DockStyle.Fill;
                ucAddUser.Instance.BringToFront();
            }
            ucAddUser.Instance.BringToFront();
        }

        private void btnProductCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (!container.Controls.Contains(ucUndoProduct.Instance))
            {
                container.Controls.Add(ucUndoProduct.Instance);
                ucUndoProduct.Instance.Dock = DockStyle.Fill;
                ucUndoProduct.Instance.BringToFront();
            }
            ucUndoProduct.Instance.BringToFront();
        }
    }
}
