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
using System.Data.SqlClient;

namespace TestDevx
{
    public partial class ucUndoProduct : DevExpress.XtraEditors.XtraUserControl
    {

        private string[] list;
        private static ucUndoProduct _instance;
        public static ucUndoProduct Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucUndoProduct();
                return _instance;
            }
            set
            {
                _instance = value;
            }
        }
        public ucUndoProduct()
        {
            InitializeComponent();

            STOK_TAKIPEntities db = new STOK_TAKIPEntities();

            foreach (var item in db.users)
            {
                cbUser.Items.Add(item.id + " - " + item.name + " " + item.lastName);
            }
           
        }

        private void ucUndoProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnRemoveLoan_Click(object sender, EventArgs e)
        {

        }

        private void cbUser_SelectedValueChanged(object sender, EventArgs e)
        {
            list = cbUser.SelectedItem.ToString().Split('-');
            cbProducts.Items.Clear();
            using (STOK_TAKIPEntities db = new STOK_TAKIPEntities()) {
               var products = db.getLoanbyUserID2(int.Parse(list[0]));

                foreach(var i in products)
                {
                    cbProducts.Items.Add(i.productName);
                    lblAvailable.Text = i.Pieces.ToString();
                }
            }
            
        }

        private void cbProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            list = cbUser.SelectedItem.ToString().Split('-');
            using (STOK_TAKIPEntities db = new STOK_TAKIPEntities())
            {
                
                var products = db.getLoanbyUserID2(int.Parse(list[0]));
            }
        }
    }
}
