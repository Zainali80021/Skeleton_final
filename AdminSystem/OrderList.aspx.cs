using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
        clsOrdersUser AnUser = new clsOrdersUser();
        AnUser = (clsOrdersUser)Session["AnUser"];
        Response.Write("Logged in By : " + AnUser.UserName);
    }

    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrdersList.DataSource = Orders.OrderList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "CustomerName";
        lstOrdersList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("OrderDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Select any Entry.";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 OrderID;

        if (lstOrdersList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrdersList.SelectedValue);
            Session["OrderID"] = OrderID;
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            lblError.Text = "Make any Selection.";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AOrder = new clsOrderCollection();
        AOrder.ReportByCustomerName(txtOrderName.Text);
        lstOrdersList.DataSource = AOrder.OrderList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "CustomerName";
        lstOrdersList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        clsOrderCollection AOrder = new clsOrderCollection();
        AOrder.ReportByCustomerName("");
        txtOrderName.Text = "";
        lstOrdersList.DataSource = AOrder.OrderList;
        lstOrdersList.DataValueField = "OrderID";
        lstOrdersList.DataTextField = "CustomerName";
        lstOrdersList.DataBind();
    }

    protected void btnTeam_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}