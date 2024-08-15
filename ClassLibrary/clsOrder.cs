using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }




        public string CustomerName
        {
            get
            {
                return mCustomerName;
            }
            set
            {
                mCustomerName = value;
            }
        }

        private int mOrderID;
        private String mCustomerName;
        private Double mTotalAmount;
        private DateTime mDeliveryDate;
        private bool mDeliveryStaus;
        private string mOrderDescription;

        public Double TotalAmount
        {
            get
            {
                return mTotalAmount;
            }
            set
            {
                mTotalAmount = value;
            }
        }




        public DateTime DeliveryDate
        {
            get
            {
                return mDeliveryDate;
            }
            set
            {
                mDeliveryDate = value;
            }
        }

        public bool DeliveryStatus
        {
            get
            {
                return mDeliveryStaus;
            }
            set
            {
                mDeliveryStaus = value;
            }
        }

        public string OrderDescription
        {
            get
            {
                return mOrderDescription;
            }
            set
            {
                mOrderDescription = value;
            }
        }

        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderID", orderID);
            DB.Execute("sproc_tblOrder_FilterByOrderID");

            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderID"]);
                mCustomerName = Convert.ToString(DB.DataTable.Rows[0]["CustomerName"]);
                mTotalAmount = Convert.ToDouble(DB.DataTable.Rows[0]["TotalAmount"]);
                mDeliveryStaus = Convert.ToBoolean(DB.DataTable.Rows[0]["DeliveryStatus"]);
                mDeliveryDate = Convert.ToDateTime(DB.DataTable.Rows[0]["DeliveryDate"]);
                mOrderDescription = Convert.ToString(DB.DataTable.Rows[0]["OrderDescription"]);
                return true;

            }

            else
            {
                return false;
            }
        }

        public string Valid(string totalAmount, string deliveryStatus, string orderDescription, string customerName, string deliveryDate)
        {
            String Error = "";
            if (customerName.Length == 0)
            {
                Error = Error + "Cusotmer Name shouldnt Empty.";
            }
            if (customerName.Length > 50)
            {
                Error = Error + "Customer Name shouldnot be more than 50 Charcters.";
            }






            Double TestAmount;
            try
            {
                TestAmount = Convert.ToDouble(totalAmount);
                if (TestAmount <= 0)
                {
                    Error += "Amount must not be zero or null";
                }

            }
            catch
            {
                Error += "Invalid Amount Entred.";
            }

            DateTime TestDate;
            try
            {
                TestDate = Convert.ToDateTime(deliveryDate);
                if (TestDate < DateTime.Now.Date)
                {
                    Error = Error + "Darecant be in the past";
                }
                if (TestDate > DateTime.Now.Date)
                {
                    Error = Error + "Date cant be in the future";
                }
            }
            catch
            {
                Error = Error + "Invalid Date Inseerted";
            }


            if (orderDescription.Length == 0)
            {
                Error = Error + "Order Description Must not Empty.";
            }
            if (orderDescription.Length > 250)
            {
                Error = Error + "Order Description msut not be more than 250 Charcters.";
            }


            return Error;
        }
    }
}