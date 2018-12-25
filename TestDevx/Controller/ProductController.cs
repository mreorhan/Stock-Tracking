using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestDevx.Model;

namespace TestDevx.Controller
{
    public static class ProductController
    {
        public static void addProduct(product p,purchase purc)
        {
            using (var context = new STOK_TAKIPEntities())
            {
                var productName = new SqlParameter("@productName", p.productName);
                var productFeatures = new SqlParameter("@productFeatures", p.productFeatures);
                var purchasedDate = new SqlParameter("@purchasedDate", purc.purchasedDate);
                var purchasedByID = new SqlParameter("@purchasedByID", purc.purchasedByID);
                var purchasedPrice = new SqlParameter("@purchasedPrice", purc.purchasePrice);
                var pieces = new SqlParameter("@pieces", p.pieces);

                try
                {
                    context.Database.ExecuteSqlCommand("exec createNewProduct @productName , @productFeatures , @purchasedDate , @purchasedByID, @purchasedPrice, @pieces",
                    productName, productFeatures, purchasedDate, purchasedByID, purchasedPrice, pieces);

                    MessageBox.Show("The transaction was successful!");
                    ucProduct.Instance = null;
                    ucRemoveProduct.Instance = null;
                    ucLoantoUser.Instance = null;
                    ucEditProduct.Instance = null;
                }
                catch
                {
                    MessageBox.Show("The transaction was failed!");
                }

            }
        }
    }
}