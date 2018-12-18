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
        }

        private void fluentDesignFormContainer1_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
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
    }
}
