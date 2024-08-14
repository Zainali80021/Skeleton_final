using System;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class clsSupplierCollection
    {

        List<clsSupplier> mSupplierList = new List<clsSupplier>();
        clsSupplier mThisSupplier = new clsSupplier();

        public List<clsSupplier> SupplierList
        {
            get
            {
                return mSupplierList;
            }
            set
            {
                mSupplierList = value;
            }
        }
        public clsSupplier ThisSupplier
        {
            get
            {
                return mThisSupplier;
            }
            set
            {
                mThisSupplier = value;
            }
        }

        public int Count
        {
            get
            {
                return mSupplierList.Count;
            }
            set
            {
                mSupplierList.Clear();
            }
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", mThisSupplier.Name);
            DB.AddParameter("@SupplierAddress", mThisSupplier.Address);
            DB.AddParameter("@ContactEmail", mThisSupplier.Email);
            DB.AddParameter("@ContactPhone", mThisSupplier.Phone);
            DB.AddParameter("@ActiveStatus", mThisSupplier.Active);
            DB.AddParameter("@RegisteredDate", mThisSupplier.RegisteredDate);

            return DB.Execute("sproc_tblSupplier_Insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.Execute("sproc_tblSupplier_Delete");

        }

        public void ReportBySupplierName(string SupplierName)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierName", SupplierName);
            DB.Execute("sproc_tblSupplier_FilterbySupplierName");
            PopulateArray(DB);

        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@SupplierID", mThisSupplier.SupplierID);
            DB.AddParameter("@SupplierName", mThisSupplier.Name);
            DB.AddParameter("@SupplierAddress", mThisSupplier.Address);
            DB.AddParameter("@ContactEmail", mThisSupplier.Email);
            DB.AddParameter("@ContactPhone", mThisSupplier.Phone);
            DB.AddParameter("@ActiveStatus", mThisSupplier.Active);
            DB.AddParameter("@RegisteredDate", mThisSupplier.RegisteredDate);

            DB.Execute("sproc_tblSupplier_Update");

        }


        public clsSupplierCollection()
        {

            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblSupplier_SelectAll");
            PopulateArray(DB);

        }


        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordsCount;

            RecordsCount = DB.Count;
            mSupplierList = new List<clsSupplier>();
            while (Index < RecordsCount)
            {
                clsSupplier ASupplier = new clsSupplier();
                ASupplier.SupplierID = Convert.ToInt32(DB.DataTable.Rows[Index]["SupplierID"]);
                ASupplier.Name = Convert.ToString(DB.DataTable.Rows[Index]["SupplierName"]);
                ASupplier.Address = Convert.ToString(DB.DataTable.Rows[Index]["SupplierAddress"]);
                ASupplier.Email = Convert.ToString(DB.DataTable.Rows[Index]["ContactEmail"]);
                ASupplier.Phone = Convert.ToString(DB.DataTable.Rows[Index]["ContactPhone"]);
                ASupplier.RegisteredDate = Convert.ToDateTime(DB.DataTable.Rows[Index]["RegisteredDate"]);
                ASupplier.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["ActiveStatus"]);

                mSupplierList.Add(ASupplier);
                Index++;
            }
        }

    }
}