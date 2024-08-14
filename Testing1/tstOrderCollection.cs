using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstOrderCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            Assert.IsNotNull(ORDERS);
        }

        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 3;
            TestItem.CustomerName = "Malik";
            TestItem.TotalAmount = 854.32;
            TestItem.DeliveryStatus = true;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            ORDERS.OrderList = TestList;
            Assert.AreEqual(ORDERS.OrderList, TestList);
        }


        [TestMethod]
        public void CountPropertyOK()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            Int32 SomeCount = 3;
            ORDERS.Count = SomeCount;
            Assert.AreNotEqual(ORDERS.Count, SomeCount);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 3;
            TestItem.CustomerName = "Malik";
            TestItem.TotalAmount = 8752.86;
            TestItem.DeliveryStatus = true;
            TestItem.DeliveryDate = DateTime.Now.Date;
            ORDERS.ThisOrder = TestItem;

            Assert.AreEqual(ORDERS.ThisOrder, TestItem);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            List<clsOrder> TestList = new List<clsOrder>();
            clsOrder TestItem = new clsOrder();
            TestItem.OrderID = 5;
            TestItem.CustomerName = "Malik";
            TestItem.TotalAmount = 8785.25;
            TestItem.DeliveryStatus = true;
            TestItem.DeliveryDate = DateTime.Now.Date;
            TestList.Add(TestItem);
            ORDERS.OrderList = TestList;
            Assert.AreEqual(ORDERS.Count, TestList.Count);
        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            Assert.AreNotEqual(ORDERS.Count, 2);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.CustomerName = "Zain Malik";
            TestOrder.TotalAmount = 854.25;
            TestOrder.DeliveryStatus = true;
            TestOrder.DeliveryDate = DateTime.Now;
            TestOrder.OrderDescription = "Order is FRAGILE";
            ORDERS.ThisOrder = TestOrder;
            PrimaryKey = ORDERS.Add();
            TestOrder.OrderID = PrimaryKey;
            ORDERS.ThisOrder.Find(PrimaryKey);
            ORDERS.Delete();
            Boolean Found = ORDERS.ThisOrder.Find(PrimaryKey);

            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void EditMethodOK()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.CustomerName = "Zain Malik";
            TestOrder.TotalAmount = 854.25;
            TestOrder.DeliveryStatus = true;
            TestOrder.DeliveryDate = DateTime.Now;
            TestOrder.OrderDescription = "Order is FRAGILE";
            ORDERS.ThisOrder = TestOrder;
            PrimaryKey = ORDERS.Add();
            TestOrder.OrderID = PrimaryKey;
            TestOrder.CustomerName = "PAKISTAN";
            TestOrder.TotalAmount = 745.2598741;
            TestOrder.DeliveryStatus = false;
            TestOrder.DeliveryDate = DateTime.Now;
            TestOrder.OrderDescription = "ORDER CONTAINS FOOD.";
            ORDERS.ThisOrder = TestOrder;
            ORDERS.ThisOrder = TestOrder;
            ORDERS.Update();
            ORDERS.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(ORDERS.ThisOrder, TestOrder);
        }

        [TestMethod]

        public void ReportByOrderNameTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByCustomerName("PAKISTAN");

            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 24)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[0].OrderID != 25)
                {
                    OK = false;
                }

            }
            else
            {
                OK = false;
            }
            Assert.IsFalse(OK);
        }

        [TestMethod]
        public void ReportByOrderNameMethodOK()
        {

            clsOrderCollection ORDERS = new clsOrderCollection();

            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByCustomerName("");

            Assert.AreEqual(ORDERS.Count, FilteredOrders.Count);


        }

        [TestMethod]
        public void ReportByOrderNameNoneFound()
        {

            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByCustomerName("KAJSHDJCBKC");

            Assert.AreEqual(0, FilteredOrders.Count);


        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection ORDERS = new clsOrderCollection();
            clsOrder TestOrder = new clsOrder();
            Int32 PrimaryKey = 0;
            TestOrder.CustomerName = "Zain Malik";
            TestOrder.TotalAmount = 854.25;
            TestOrder.DeliveryStatus = true;
            TestOrder.DeliveryDate = DateTime.Now;
            TestOrder.OrderDescription = "Order is FRAGILE";
            ORDERS.ThisOrder = TestOrder;
            PrimaryKey = ORDERS.Add();
            TestOrder.OrderID = PrimaryKey;
            ORDERS.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(ORDERS.ThisOrder, TestOrder);

        }
    }
}
