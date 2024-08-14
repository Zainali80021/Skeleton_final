using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{

    void DisplaySuppliers()
    {
        clsSupplierCollection AllSuppliers = new clsSupplierCollection();
        lstSupplierList.DataSource = AllSuppliers.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "Name";
        lstSupplierList.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplaySuppliers();
        }
        clsSupplierUser AnUser = new clsSupplierUser();
        AnUser = (clsSupplierUser)Session["AnUser"];
        Response.Write("Logged in as : " + AnUser.UserName);
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["SupplierID"] = -1;
        Response.Redirect("SupplierDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;

        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierDataEntry.aspx");


        }
        else
        {
            lblError.Text = "Please select a Record to edit.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 SupplierID;

        if (lstSupplierList.SelectedIndex != -1)
        {
            SupplierID = Convert.ToInt32(lstSupplierList.SelectedValue);
            Session["SupplierID"] = SupplierID;
            Response.Redirect("SupplierConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Please Select a Record to Delete.";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportBySupplierName(txtSupplierNameBox.Text);
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "Name";
        lstSupplierList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsSupplierCollection ASupplier = new clsSupplierCollection();
        ASupplier.ReportBySupplierName("");
        txtSupplierNameBox.Text = "";
        lstSupplierList.DataSource = ASupplier.SupplierList;
        lstSupplierList.DataValueField = "SupplierID";
        lstSupplierList.DataTextField = "Name";
        lstSupplierList.DataBind();
    }

    protected void btnMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}