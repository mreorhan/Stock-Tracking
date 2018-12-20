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
        public frm()
        {
            InitializeComponent();
            /* WHY AM I USING SINGLETON WITH GENERIC METHOD: (stackoverflow)
             * If a user can provide a type to as a generic type argument then
             * they can also create instances of that type. In other words,
             * you cannot create a generic singleton factory - it undermines the pattern itself.
             */
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

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
    }
}
