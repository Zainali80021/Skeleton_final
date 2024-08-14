using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsOrderCollection
    {
        private List<clsOrder> mOrderList = new List<clsOrder>();
        private clsOrder mThisOrder = new clsOrder();

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblOrder_SelectALl");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrder>();

            while (Index < RecordCount)
            {
                clsOrder AnOrder = new clsOrder();

                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderID"]);
                AnOrder.CustomerName = Convert.ToString(DB.DataTable.Rows[Index]["CustomerName"]);
                AnOrder.TotalAmount = Convert.ToDouble(DB.DataTable.Rows[Index]["TotalAmount"]);
                AnOrder.DeliveryStatus = Convert.ToBoolean(DB.DataTable.Rows[Index]["DeliveryStatus"]);
                AnOrder.DeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["DeliveryDate"]);

                mOrderList.Add(AnOrder);
                Index++;
            }
        }

        public List<clsOrder> OrderList
        {
            get { return mOrderList; }
            set { mOrderList = value; }
        }
        public int Count
        {
            get { return mOrderList.Count; }
            set { }
        }
        public clsOrder ThisOrder
        {
            get { return mThisOrder; }
            set { mThisOrder = value; }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@DeliveryStatus", mThisOrder.DeliveryStatus);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@OrderDescription", mThisOrder.OrderDescription);
            return DB.Execute("sproc_tblOrder_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrder_Delete");
        }

        public void ReportByCustomerName(string CustomerName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerName", CustomerName);
            DB.Execute("sproc_tblOrder_FilterByCustomerName");

            PopulateArray(DB);
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", mThisOrder.OrderID);
            DB.AddParameter("@CustomerName", mThisOrder.CustomerName);
            DB.AddParameter("@TotalAmount", mThisOrder.TotalAmount);
            DB.AddParameter("@DeliveryStatus", mThisOrder.DeliveryStatus);
            DB.AddParameter("@DeliveryDate", mThisOrder.DeliveryDate);
            DB.AddParameter("@OrderDescription", mThisOrder.OrderDescription);
            DB.Execute("sproc_tblOrder_Update");
        }
    }
}