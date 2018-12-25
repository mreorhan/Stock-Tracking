using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace StockTrackingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateProduct()
        {
            TestDevx.purchase purchaseTest = new TestDevx.purchase
            {
                purchasedByID = 1,
                purchasePrice = 4000,
                purchasedDate = DateTime.Now.ToString(),
                isDeleted=false

            };
            TestDevx.product productTest = new TestDevx.product {
                productName = "Test product",
                productFeatures = "Test Features",
                pieces=5,
                purchaseID=purchaseTest.purchaseID,
                isAvailable=1
            };
            TestDevx.Controller.ProductController.addProduct(productTest, purchaseTest);
        }

        [TestMethod]
        public void addUser()
        {
            TestDevx.user user1 = new TestDevx.user();
            user1.username = "testhesabi";
            user1.name = "Test";
            user1.lastName = "Hesabı";
            user1.password = "1234";
            user1.userTypeID = 3; //Chief

            TestDevx.Controller.UserController.addUser(user1);
        }
        [TestMethod]
        public void editUser()
        {
            TestDevx.user user1 = new TestDevx.user
            {
                id=42,
                username = "test deneme hesabi",
                password = "1234"
            };

            TestDevx.Controller.UserController.editUser(user1);
        }
        [TestMethod]
        public void Login()
        {
            TestDevx.user user1 = new TestDevx.user
            {
                username = "emre",
                password = "12345" // Yanlış şifre girdim ! Doğru şifre 1234
            };
            TestDevx.Controller.UserController.checkUser(user1);
        }
        [TestMethod]
        public void loanToUser()
        {
            TestDevx.loanDetail loanDetail = new TestDevx.loanDetail
            {
                loanByID=1,
                loanDate=DateTime.Now.ToString(),
                loanPieces=5,
                productID=2,
                userID=44,

            };
            TestDevx.Controller.LoanController.loanToUser(loanDetail);
        }
    }
}
