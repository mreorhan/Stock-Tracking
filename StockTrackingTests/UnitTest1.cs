using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestDevx.Model;
using TestDevx.Controller;
namespace StockTrackingTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateProduct()
        {
           TestDevx.Model.purchase purchaseTest = new TestDevx.Model.purchase
            {
                purchasedByID = 1,
                purchasePrice = 4000,
                purchasedDate = DateTime.Now.ToString(),
                isDeleted=false

            };
            TestDevx.Model.product productTest = new TestDevx.Model.product {
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
            user user1 = new user();
            user1.username = "testhesabi";
            user1.name = "Test";
            user1.lastName = "Hesabı";
            user1.password = "1234";
            user1.userTypeID = 3; //Chief

            UserController.addUser(user1);
        }
        [TestMethod]
        public void editUser()
        {
            user user1 = new user
            {
                id=42,
                username = "test deneme hesabi",
                password = "1234"
            };

            UserController.editUser(user1);
        }
        [TestMethod]
        public void Login()
        {
            user user1 = new user
            {
                username = "emre",
                password = "12345" // Yanlış şifre girdim ! Doğru şifre 1234
            };
            UserController.checkUser(user1);
        }
        [TestMethod]
        public void loanToUser()
        {
            loanDetail loanDetail = new loanDetail
            {
                loanByID=1,
                loanDate=DateTime.Now.ToString(),
                loanPieces=5,
                productID=2,
                userID=44,

            };
            LoanController.loanToUser(loanDetail);
        }
    }
}
