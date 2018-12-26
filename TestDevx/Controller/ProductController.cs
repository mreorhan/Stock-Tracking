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

        public static void editProduct(purchase purc, product p)
        {

            using (var context = new STOK_TAKIPEntities())
            {
                //get sql parameters for addLoan procedure
                var productID = new SqlParameter("@productID", p.productID);
                var productName = new SqlParameter("@productName", p.productName);
                var productFeatures = new SqlParameter("@productFeatures", p.productFeatures);
                var productPiece = new SqlParameter("@productPiece", purc.purchasePrice);

                try
                {
                    //execute addLoan stored procedure
                    context.Database.ExecuteSqlCommand("exec editProduct @productID , @productName , @productFeatures , @productPiece",
                    productID, productName, productFeatures, productPiece);
                    MessageBox.Show("The transaction was successful!");
                    ucLoans.Instance = null;
                    ucProduct.Instance = null;
                    ucRemoveProduct.Instance = null;
                    ucUndoProduct.Instance = null;
                    ucDepartmentChief.Instance = null;
                }
                catch
                {
                    MessageBox.Show("The transaction was failed!");
                }

            }
        }
    }
}