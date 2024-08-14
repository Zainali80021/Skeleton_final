using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 SupplierID;
    protected void Page_Load(object sender, EventArgs e)
    {
        SupplierID = Convert.ToInt32(Session["SupplierID"]);
        if (IsPostBack == false)
        {
            if (SupplierID != -1)
            {
                DisplaySupplier();

            }

            clsSupplierUser AnUser = new clsSupplierUser();
            AnUser = (clsSupplierUser)Session["AnUser"];
            Response.Write("Logged in as : " + AnUser.UserName);
        }
    }
    void DisplaySupplier()
    {
        clsSupplierCollection SupplierCollection = new clsSupplierCollection();
        SupplierCollection.ThisSupplier.Find(SupplierID);

        txtSupplierID.Text = SupplierCollection.ThisSupplier.SupplierID.ToString();
        txtName.Text = SupplierCollection.ThisSupplier.Name.ToString();
        txtAddress.Text = SupplierCollection.ThisSupplier.Address.ToString();
        txtEmail.Text = SupplierCollection.ThisSupplier.Email.ToString();
        txtPhone.Text = SupplierCollection.ThisSupplier.Phone.ToString();
        chkActive.Checked = SupplierCollection.ThisSupplier.Active;
        txtDate.Text = SupplierCollection.ThisSupplier.RegisteredDate.ToString();
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsSupplier ASupplier = new clsSupplier();
        string Name = txtName.Text;
        string Address = txtAddress.Text;
        string Email = Convert.ToString(txtEmail.Text);
        string Phone = txtPhone.Text;
        string Active = Convert.ToString(chkActive.Checked);
        string RegisteredDate = txtDate.Text;

        string Error = "";
        Error = ASupplier.Valid(Name, Address, Email, Phone, RegisteredDate);
        if (Error == "")
        {
            ASupplier.SupplierID = SupplierID;
            ASupplier.Name = Name;
            ASupplier.Address = Address;
            ASupplier.Email = Email;
            ASupplier.Phone = Phone;
            ASupplier.Active = Convert.ToBoolean(Active);
            ASupplier.RegisteredDate = Convert.ToDateTime(RegisteredDate);

            clsSupplierCollection SupplierList = new clsSupplierCollection();

            if (SupplierID == -1)
            {
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Add();
            }
            else
            {
                SupplierList.ThisSupplier.Find(SupplierID);
                SupplierList.ThisSupplier = ASupplier;
                SupplierList.Update();

            }
            Response.Redirect("SupplierList.aspx");

        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("SupplierList.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsSupplier ASupplier = new clsSupplier();
        Int32 SupplierID;
        Boolean Found = false;
        SupplierID = Convert.ToInt32(txtSupplierID.Text);

        Found = ASupplier.Find(SupplierID);

        if (Found == true)
        {
            txtName.Text = ASupplier.Name;
            txtAddress.Text = ASupplier.Address;
            txtEmail.Text = ASupplier.Email;
            txtPhone.Text = ASupplier.Phone;
            txtDate.Text = ASupplier.RegisteredDate.ToString();
            chkActive.Checked = ASupplier.Active;
        }

    }

    protected void btnMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}