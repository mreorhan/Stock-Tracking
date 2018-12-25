using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TestDevx.Controller
{
    public static class UserController
    {
        public static void checkUser(user model)
        {
            using (var context = new STOK_TAKIPEntities())
            {
                try
                {
                    using (MD5 md5 = MD5.Create())
                    {
                        //Hashing with MD5
                        string strHashedPassword = md5.Hash(model.password);
                        using (var db = new STOK_TAKIPEntities())
                        {
                           
                            var result = db.users.Select(s => s)
                                .Where(x => x.username == model.username)
                                .Where(x => x.password == strHashedPassword);
                            ucProduct.Instance = null;
                            ucLoans.Instance = null;
                            frm login = new frm();
                            string[] authors = {
                                result.First().username,
                                result.First().name,
                                result.First().lastName,
                                result.First().id.ToString(),
                                result.First().userTypeID.ToString()
                            };
                            login.GetUser = authors;
                            login.ShowDialog();
                            return;
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Username or password wrong!");
                }

            }
        }

        public static void addUser(user u)
        {
            using (var context = new STOK_TAKIPEntities())
            {
                try
                {
                    using (MD5 md5 = MD5.Create())
                    {
                        string strHashedPassword = md5.Hash(u.password);
                        context.addUser(u.name, u.lastName, u.username, strHashedPassword, u.userTypeID);
                        ucUsers.Instance = null;
                        ucLoantoUser.Instance = null;
                        ucEditUser.Instance = null;

                        MessageBox.Show("User Created");
                    }
                }
                catch
                {
                    MessageBox.Show("Something went wrong!");
                }

            }
        }

        public static void editUser(user u)
        {
            using (var context = new STOK_TAKIPEntities())
            {
                //get sql parameters for edituser procedure
                using (MD5 md5 = MD5.Create())
                {
                    //Hashing with MD5
                    string strHashedPassword = md5.Hash(u.password);
                    var userID = new SqlParameter("@userID", u.id);
                    var userName = new SqlParameter("@username", u.username);
                    var userPassword = new SqlParameter("@password", strHashedPassword);

                    try
                    {
                        //execute edituser stored procedure
                        context.Database.ExecuteSqlCommand("exec editUser @userID , @username , @password",
                        userID, userName, userPassword);
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
}
