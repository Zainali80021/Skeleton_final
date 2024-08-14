using System;

namespace ClassLibrary
{
    public class clsSupplier
    {
        private bool mActive;
        private Int32 mSupplierID;
        private String mName;
        private String mAddress;
        private String mEmail;
        private String mPhone;
        private DateTime mDate;

        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }

        public int SupplierID
        {
            get
            {
                return mSupplierID;
            }
            set
            {
                mSupplierID = value;
            }


        }
        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
            }
        }


        public string Address
        {
            get
            {
                return mAddress;
            }
            set
            {
                mAddress = value;
            }
        }

        public string Email
        {
            get
            {
                return mEmail;
            }
            set
            {
                mEmail = value;
            }
        }

        public string Phone
        {
            get
            {
                return mPhone;
            }
            set
            {
                mPhone = value;
            }
        }

        public DateTime RegisteredDate
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
            }
        }

        public bool Find(int SupplierID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", SupplierID);
            DB.Execute("sproc_tblSupplier_FilterBySupplierID");

            if (DB.Count == 1)
            {
                mSupplierID = Convert.ToInt32(DB.DataTable.Rows[0]["SupplierID"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["SupplierName"]);
                mAddress = Convert.ToString(DB.DataTable.Rows[0]["SupplierAddress"]);
                mEmail = Convert.ToString(DB.DataTable.Rows[0]["ContactEmail"]);
                mPhone = Convert.ToString(DB.DataTable.Rows[0]["ContactPhone"]);
                mDate = Convert.ToDateTime(DB.DataTable.Rows[0]["RegisteredDate"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["ActiveStatus"]);
                return true;
            }

            else
            {
                return false;
            }

        }

        public string Valid(string name, string address, string email, string phone, string registeredDate)
        {
            String Error = "";
            DateTime CheckDate;
            if (address.Length == 0)
            {
                Error = Error + "Address must not be empty";
            }
            if (address.Length > 255)
            {
                Error = Error + "Address must be Less 255";
            }
            if (phone.Length <= 5)
            {
                Error = Error + "phone mustnot be empty or less than 5 digit ";
            }
            if (phone.Length > 20)
            {
                Error = Error + "phone must be less than 20";
            }
            if (name.Length == 0)
            {
                Error = Error + "Name must not be empty";
            }
            if (name.Length > 30)
            {
                Error = Error + "Name Must be less than 30.";
            }
            if (email.Length == 0)
            {
                Error = Error + "Email Must not be Empty.";
            }
            if (email.Length > 50)
            {
                Error = Error + "Email Must be lesser than 50 characters.";
            }
            DateTime CoDate = DateTime.Now.Date;
            try
            {
                CheckDate = Convert.ToDateTime(registeredDate);
                if (CheckDate < CoDate)
                {
                    Error = Error + "The Date mustnot be in the past";
                }
                if (CheckDate > DateTime.Now.Date)
                {
                    Error = Error + "The Date mustnot be in the Future";
                }
            }
            catch
            {
                Error = Error + "The Date is Invalid.";
            }

            return Error;

        }
    }
}