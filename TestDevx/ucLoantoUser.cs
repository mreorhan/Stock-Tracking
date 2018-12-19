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
    public partial class ucLoantoUser : DevExpress.XtraEditors.XtraUserControl
    {
        private static ucLoantoUser _instance;
        public static ucLoantoUser Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucLoantoUser();
                return _instance;
            }
        }
        
        public ucLoantoUser()
        {
            InitializeComponent();
            STOK_TAKIPEntities db = new STOK_TAKIPEntities();
            foreach (var item in db.users)
            {
                cbUser.Items.Add(item.id+" - "+item.name +" " + item.lastName);
            }
            foreach (var item in db.products)
            {
                if(item.isAvailable==1)
                    cbProducts.Items.Add(item.productID + " - " + item.productName);
            }
        }

        private void ucLoantoUser_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] list = cbUser.SelectedItem.ToString().Split('-');
            MessageBox.Show(list[0]);
        }

        private void btnAddLoan_Click(object sender, EventArgs e)
        {
            string[] user = cbUser.SelectedItem.ToString().Split('-');
            string[] product = cbProducts.SelectedItem.ToString().Split('-');
            loanDetail l = new loanDetail();
            l.productID = int.Parse(product[0]);
            l.loanDate = DateTime.Now;
            l.userID = int.Parse(user[0]);
            l.loanByID = 1; // sonradan değiştir.
            
        }
    }
}
