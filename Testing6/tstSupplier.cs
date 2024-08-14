using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Security.Policy;

namespace Testing6
{
    [TestClass]
    public class tstSupplier
    {

        string Name = "Suman";
        string Address = "London , England ";
        string Email = "Bisma@hotmail.com";
        string Phone = "12549856316";
        string RegisteredDate = DateTime.Now.ToShortDateString();


        [TestMethod]
        public void ValidMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NameMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Name = "B";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void NameMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Name = "Bi";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(29, 'S');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(30, 'S');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void NameMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(31, 'S');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void NameMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(15, 'S');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void NameExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Name = "";
            Name = Name.PadRight(3000, 'B');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }




        [TestMethod]
        public void InstanceOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Assert.IsNotNull(AnSupplier);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean TestData = true;
            AnSupplier.Active = TestData;
            Assert.AreEqual(AnSupplier.Active, TestData);
        }




        [TestMethod]
        public void AddressMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "A";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void AddressMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "SB";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(254, 'S');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(255, 'B');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void AddressMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(256, 'V');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void AddressMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(127, 'B');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void AddressExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Address = "";
            Address = Address.PadRight(2555, 'A');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PhoneMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Phone = "8524";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Phone = "47521";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Phone = "741852";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Phone = "7418529637418585476";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Phone = "789456123789456786541";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Phone = "951753852456963485214";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void PhoneMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Phone = "78985245";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void PhoneExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Phone = "1234567891234567852222222222912";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }





        [TestMethod]
        public void SupplierIDPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Int32 TestData = 2;
            AnSupplier.SupplierID = TestData;
            Assert.AreEqual(AnSupplier.SupplierID, TestData);
        }

        [TestMethod]
        public void NamePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String TestData = "Suman Bista";
            AnSupplier.Name = TestData;
            Assert.AreEqual(AnSupplier.Name, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String TestData = "Hello World From the Universe.";
            AnSupplier.Address = TestData;
            Assert.AreEqual(AnSupplier.Address, TestData);
        }

        [TestMethod]
        public void EmailPropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String TestData = "bista@hotmail.com";
            AnSupplier.Email = TestData;
            Assert.AreEqual(AnSupplier.Email, TestData);
        }


        [TestMethod]
        public void EmailMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "g";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void EmailMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "ih";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMaxLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(49, 'b');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(50, 'b');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailMaxPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(51, 'b');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void EmailMid()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(25, 'b');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void EmailExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            string Email = "";
            Email = Email.PadRight(2555, 'B');
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DateExtremeMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TDate;
            TDate = DateTime.Now.Date;
            TDate = TDate.AddYears(-100);
            String RegisteredDate = TDate.ToString();
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateMinLessOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TDate;
            TDate = DateTime.Now.Date;
            TDate = TDate.AddDays(-1);
            String RegisteredDate = TDate.ToString();
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateMin()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TDate;
            TDate = DateTime.Now.Date;
            String RegisteredDate = TDate.ToString();
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreEqual(Error, "");
        }



        [TestMethod]
        public void DateMinPlusOne()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TDate;
            TDate = DateTime.Now.Date;
            TDate = TDate.AddDays(1);
            String RegisteredDate = TDate.ToString();
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateExtremeMax()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            DateTime TDate;
            TDate = DateTime.Now.Date;
            TDate = TDate.AddYears(100);
            String RegisteredDate = TDate.ToString();
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateInvalidData()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String Error = "";
            String RegisteredDate = "Date is in incorrect format.";
            Error = AnSupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void PhonePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            String TestData = "1234567891";
            AnSupplier.Phone = TestData;
            Assert.AreEqual(AnSupplier.Phone, TestData);
        }

        [TestMethod]
        public void RegisteredDatePropertyOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            DateTime TestData = DateTime.Now.Date;
            AnSupplier.RegisteredDate = TestData;
            Assert.AreEqual(AnSupplier.RegisteredDate, TestData);
        }



        [TestMethod]
        public void FindMethodOK()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Int32 SupplierID = 2;
            Found = AnSupplier.Find(SupplierID);
            Assert.IsTrue(Found);
        }



        [TestMethod]
        public void TestSupplierIDFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = AnSupplier.Find(SupplierID);

            if (AnSupplier.SupplierID != 2)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }




        [TestMethod]
        public void TestNameFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = AnSupplier.Find(SupplierID);

            if (AnSupplier.Name != "Supplier Two")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }



        [TestMethod]
        public void TestAddressFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = AnSupplier.Find(SupplierID);

            if (AnSupplier.Address != "456 Oak St, Springfield, IL")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestEmailFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = AnSupplier.Find(SupplierID);

            if (AnSupplier.Email != "contact2@suppliertwo.com")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestPhoneFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = AnSupplier.Find(SupplierID);

            if (AnSupplier.Phone != "234-567-8901")
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = AnSupplier.Find(SupplierID);

            if (AnSupplier.RegisteredDate != Convert.ToDateTime("12-08-2024"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            clsSupplier AnSupplier = new clsSupplier();
            Boolean Found = false;
            Boolean OK = true;
            Int32 SupplierID = 2;
            Found = AnSupplier.Find(SupplierID);

            if (AnSupplier.Active != true)
            {
                OK = false;
            }

            Assert.IsTrue(OK);
        }


    }
}
