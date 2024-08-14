using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing6
{
    [TestClass]
    public class tstSupplierUser
    {





        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Assert.IsNotNull(AnUser);
        }







        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Int32 TestData = 5;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }
        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Bista";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }


        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Suman";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }


        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            string TestData = "Suppliers";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        [TestMethod]

        public void FindUserMethodOK()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = false;
            string UserName = "Suman Bista";
            string Password = "123456";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }

        [TestMethod]

        public void TestUserNamePWFound()
        {
            clsSupplierUser AnUser = new clsSupplierUser();
            Boolean Found = false;
            Boolean Ok = true;
            string UserName = "Suman Bista";
            string Password = "123456";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }     
    }
}
