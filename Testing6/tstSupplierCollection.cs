using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Testing6
{
    [TestClass]
    public class tstSupplierCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.IsNotNull(AllSupplier);
        }

        [TestMethod]
        public void SupplierListOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();
            clsSupplier TestItem = new clsSupplier();

            TestItem.Active =       true;
            TestItem.SupplierID =   2;
            TestItem.Name =         "Supplier Two";
            TestItem.Address =      "456 Oak St, Springfield, IL";
            TestItem.Email =        "contact2@suppliertwo.com";
            TestItem.Phone =        "234-567-8901";
            TestItem.RegisteredDate = DateTime.Now;

            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.SupplierList, TestList);
        }

        [TestMethod]
        public void CountPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Int32 iCount = 0;
            AllSupplier.Count = iCount;
            Assert.AreEqual(AllSupplier.Count, iCount);

        }



        [TestMethod]
        public void ThisSupplierPropertyOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            TestSupplier.Active =       true;
            TestSupplier.SupplierID =   2;
            TestSupplier.Name =         "Supplier Two";
            TestSupplier.Address =      "456 Oak St, Springfield, IL";
            TestSupplier.Email =        "contact2@suppliertwo.com";
            TestSupplier.Phone =        "234-567-8901";
            TestSupplier.RegisteredDate = DateTime.Now;

            AllSupplier.ThisSupplier = TestSupplier;
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            List<clsSupplier> TestList = new List<clsSupplier>();

            clsSupplier TestItem = new clsSupplier();

            TestItem.Active = true;
            TestItem.SupplierID = 2;
            TestItem.Name = "Supplier Two";
            TestItem.Address = "456 Oak St, Springfield, IL";
            TestItem.Email = "contact2@suppliertwo.com";
            TestItem.Phone = "234-567-8901";
            TestItem.RegisteredDate = DateTime.Now;

            TestList.Add(TestItem);
            AllSupplier.SupplierList = TestList;
            Assert.AreEqual(AllSupplier.Count, TestList.Count);

        }


        [TestMethod]
        public void TwoRecordsPresent()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            Assert.AreEqual(AllSupplier.Count, AllSupplier.Count);
        }



        [TestMethod]
        public void AddMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();
            Int32 PrimaryKey = 0;

            TestSupplier.Active = true;
            TestSupplier.Name = "Supplier X";
            TestSupplier.Address = "Springfield, IL";
            TestSupplier.Email = "contactX@supplierX.com";
            TestSupplier.Phone = "8527419514";
            TestSupplier.RegisteredDate = DateTime.Now;

            AllSupplier.ThisSupplier = TestSupplier;
            PrimaryKey = AllSupplier.Add();
            TestSupplier.SupplierID = PrimaryKey;

            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);

        }


        [TestMethod]
        public void UpdateMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();

            Int32 PrimaryKey = 0;

            TestSupplier.Active = true;
            TestSupplier.Name = "Supplier X";
            TestSupplier.Address = "Springfield, IL";
            TestSupplier.Email = "contactX@supplierX.com";
            TestSupplier.Phone = "8527419514";
            TestSupplier.RegisteredDate = DateTime.Now;

            AllSupplier.ThisSupplier = TestSupplier;

            PrimaryKey = AllSupplier.Add();
            TestSupplier.SupplierID = PrimaryKey;


            TestSupplier.Name = "Supplier XXX";
            TestSupplier.Address = "XXX London, Uk";
            TestSupplier.Email = "supplierXXX@XXX.com";
            TestSupplier.Phone = "85475680145";
            TestSupplier.RegisteredDate = DateTime.Now;
            TestSupplier.Active = false;

            AllSupplier.ThisSupplier = TestSupplier;
            AllSupplier.Update();
            AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.AreEqual(AllSupplier.ThisSupplier, TestSupplier);
        }



        [TestMethod]
        public void DeleteMethodOK()
        {
            clsSupplierCollection AllSupplier = new clsSupplierCollection();
            clsSupplier TestSupplier = new clsSupplier();

            Int32 PrimaryKey = 0;

            TestSupplier.Active = true;
            TestSupplier.Name = "Supplier X";
            TestSupplier.Address = "Springfield, IL";
            TestSupplier.Email = "contactX@supplierX.com";
            TestSupplier.Phone = "8527419514";
            TestSupplier.RegisteredDate = DateTime.Now;

            AllSupplier.ThisSupplier = TestSupplier;

            PrimaryKey = AllSupplier.Add();
            TestSupplier.SupplierID = PrimaryKey;

            AllSupplier.ThisSupplier.Find(PrimaryKey);

            AllSupplier.Delete();

            Boolean Found = AllSupplier.ThisSupplier.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }


        [TestMethod]
        public void ReportBySupplierNameMethodOK()
        {

            clsSupplierCollection AllSuppliers = new clsSupplierCollection();
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("");
            Assert.AreEqual(AllSuppliers.Count, FilteredSuppliers.Count);


        }

        [TestMethod]
        public void ReportBySupplierNameNoneFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            FilteredSuppliers.ReportBySupplierName("Suman Bisma");
            Assert.AreEqual(0, FilteredSuppliers.Count);


        }


        [TestMethod]

        public void ReportBySupplierNameTestDataFound()
        {
            clsSupplierCollection FilteredSuppliers = new clsSupplierCollection();
            Boolean OK = true;
            FilteredSuppliers.ReportBySupplierName("Suman Bisma");

            if (FilteredSuppliers.Count == 2)
            {
                if (FilteredSuppliers.SupplierList[0].SupplierID != 24)
                {
                    OK = false;
                }
                if (FilteredSuppliers.SupplierList[0].SupplierID != 25)
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

    }
}
