using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestDevx.Controller
{
    public static class LoanController
    {
        public static void loanToUser(loanDetail l)
        {
            using (var context = new STOK_TAKIPEntities())
            {
                //get sql parameters for addLoan procedure
                var userID = new SqlParameter("@userID", l.userID);
                var loanByID = new SqlParameter("@loanByID", l.loanByID);
                var productID = new SqlParameter("@productID", l.productID);
                var loanDate = new SqlParameter("@loanDate", l.loanDate);
                var pieces = new SqlParameter("@loanPieces", l.loanPieces);

                try
                {
                    //execute addLoan stored procedure
                    context.Database.ExecuteSqlCommand("exec addLoan @userID , @loanByID , @productID , @loanDate, @loanPieces",
                    userID, loanByID, productID, loanDate, pieces);
                    MessageBox.Show("The transaction (Loan) was successful!");
                    ucLoans.Instance = null;
                    ucProduct.Instance = null;
                    ucRemoveProduct.Instance = null;
                    ucUndoProduct.Instance = null;
                    ucDepartmentChief.Instance = null;

                }
                catch
                {
                    MessageBox.Show("The transaction (Loan) was failed!");
                }

            }
        }
    }
}
