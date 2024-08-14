using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrderUser
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrdersUser AnUser = new clsOrdersUser();
            Assert.IsNotNull(AnUser);
        }


        [TestMethod]
        public void UserIDPropertyOK()
        {
            clsOrdersUser AnUser = new clsOrdersUser();
            Int32 TestData = 2;
            AnUser.UserID = TestData;
            Assert.AreEqual(AnUser.UserID, TestData);
        }

        [TestMethod]
        public void UserNamePropertyOK()
        {
            clsOrdersUser AnUser = new clsOrdersUser();
            string TestData = "Malik";
            AnUser.UserName = TestData;
            Assert.AreEqual(AnUser.UserName, TestData);
        }

        [TestMethod]
        public void PasswordPropertyOK()
        {
            clsOrdersUser AnUser = new clsOrdersUser();
            string TestData = "Zain Malik";
            AnUser.Password = TestData;
            Assert.AreEqual(AnUser.Password, TestData);
        }


        [TestMethod]
        public void DepartmentPropertyOK()
        {
            clsOrdersUser AnUser = new clsOrdersUser();
            string TestData = "Orders Component";
            AnUser.Department = TestData;
            Assert.AreEqual(AnUser.Department, TestData);
        }

        
        [TestMethod]

        public void FindUserMethodOK()
        {
            clsOrdersUser AnUser = new clsOrdersUser();
            Boolean Found = false;
            string UserName = "Zain Malik";
            string Password = "Zain";
            Found = AnUser.FindUser(UserName, Password);
            Assert.IsTrue(Found);
        }


        [TestMethod]

        public void TestUserNamePasswordFound()
        {
            clsOrdersUser AnUser = new clsOrdersUser();
            Boolean Found = false;
            Boolean Ok = true;
            string UserName = "Zain Malik";
            string Password = "Zain";
            Found = AnUser.FindUser(UserName, Password);
            if (AnUser.UserName != UserName && AnUser.Password != Password)
            {
                Ok = false;
            }
            Assert.IsTrue(Ok);
        }

    }
}
