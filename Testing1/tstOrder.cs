using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstOrder
    {

        [TestMethod]
        public void InstanceOK()
        {
            clsOrder AnOrder = new clsOrder();
            Assert.IsNotNull(AnOrder);
        }
        [TestMethod]
        public void tstDeliveryDate()
        {

            clsOrder AnOrder = new clsOrder();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DeliveryDate = TestData;
            Assert.AreEqual(AnOrder.DeliveryDate, TestData);
        }

        [TestMethod]
        public void tstOrderId()
        {
            clsOrder AnOrder = new clsOrder();
            int TestData = 5;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void tstCustomerName()
        {

            clsOrder AnOrder = new clsOrder();
            String TestData = "Zain Malik";
            AnOrder.CustomerName = TestData;
            Assert.AreEqual(AnOrder.CustomerName, TestData);
        }

        [TestMethod]
        public void tstTotalAmount()
        {

            clsOrder AnOrder = new clsOrder();
            Double TestData = 25.50;
            AnOrder.TotalAmount = TestData;
            Assert.AreEqual(AnOrder.TotalAmount, TestData);
        }

        String CustomerName = "Zain Malik";
        String TotalAmount = "58.65";
        String OrderDescription = "Fragile Inside! Be careful";
        String DeliveryDate = DateTime.Now.Date.ToString();
        String DeliveryStatus = Convert.ToString(true);

        [TestMethod]
        public void tstDeliveryStatus()
        {

            clsOrder AnOrder = new clsOrder();
            Boolean TestData = true;
            AnOrder.DeliveryStatus = TestData;
            Assert.AreEqual(AnOrder.DeliveryStatus, TestData);
        }


        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AOrder.Find(OrderID);
            if (AOrder.OrderID != 3)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void tstOrderDescription()
        {

            clsOrder AnOrder = new clsOrder();
            String TestData = "Order should be Delievered by today.";
            AnOrder.OrderDescription = TestData;
            Assert.AreEqual(AnOrder.OrderDescription, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {

            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Int32 OrderID = 3;
            Found = AOrder.Find(OrderID);
            Assert.IsTrue(Found);

        }

        [TestMethod]
        public void TestCustomerNameFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AOrder.Find(OrderID);
            if (AOrder.CustomerName != "Alice Johnson")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestDeliveryDateFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AOrder.Find(OrderID);
            if (AOrder.DeliveryDate != Convert.ToDateTime("05/08/2024"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestTotalAmountFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AOrder.Find(OrderID);
            if (AOrder.TotalAmount != 89.75)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDeliveryStatusFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AOrder.Find(OrderID);
            if (AOrder.DeliveryStatus != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestOrderDescriptionFound()
        {
            clsOrder AOrder = new clsOrder();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 3;
            Found = AOrder.Find(OrderID);
            if (AOrder.OrderDescription != "Books and stationery")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CustomerNameMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerName = "";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerName = "z";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerName = "za";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerName = "";
            CustomerName = CustomerName.PadRight(49, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerName = "";
            CustomerName = CustomerName.PadRight(50, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerName = "";
            CustomerName = CustomerName.PadRight(51, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerName = "";
            CustomerName = CustomerName.PadRight(25, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CustomerNameExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String CustomerName = "";
            CustomerName = CustomerName.PadRight(500, 'z');
            Error = AnOrder.Valid(CustomerName, TotalAmount, DeliveryStatus, DeliveryDate,OrderDescription);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void TotalAmountExtremeMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double TestTotalAmount = -169.5752;
            String TotalAmount = TestTotalAmount.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double TestTotalAmount = 0;
            String TotalAmount = TestTotalAmount.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double TestTotalAmount = 1.00;
            String TotalAmount = TestTotalAmount.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            Double TestTotalAmount = 2.00;
            String TotalAmount = TestTotalAmount.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalAmountInvalidData()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String TotalAmount = "Invalid data Inserted.";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void DeliveryDateExtremeMinimum()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DeliveryDate = TestDate.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string DeliveryDate = TestDate.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            string DeliveryDate = TestDate.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string DeliveryDate = TestDate.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateExtremeMaximum()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            DateTime TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DeliveryDate = TestDate.ToString();
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DeliveryDateInvalidDataType()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            string DeliveryDate = "Date is Invalid.";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }



        [TestMethod]
        public void OrderDescriptionMinLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionMin()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "Z";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionMinPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "za";
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionMaxLessOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(249, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(250, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionMaxPlusOne()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(251, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionMid()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(125, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void OrderDescriptionExtremeMax()
        {
            clsOrder AnOrder = new clsOrder();
            String Error = "";
            String OrderDescription = "";
            OrderDescription = OrderDescription.PadRight(2500, 'z');
            Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);
            Assert.AreNotEqual(Error, "");
        }


    }
}
