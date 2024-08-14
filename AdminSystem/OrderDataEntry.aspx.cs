using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 OrderID;

    void DisplayOrder()
    {
        clsOrderCollection OrderCollection = new clsOrderCollection();
        OrderCollection.ThisOrder.Find(OrderID);
        txtOrderID.Text = OrderCollection.ThisOrder.OrderID.ToString();
        txtCustomerName.Text = OrderCollection.ThisOrder.CustomerName.ToString();
        txtTAmount.Text = OrderCollection.ThisOrder.TotalAmount.ToString();
        chkDeliveryStatus.Checked = OrderCollection.ThisOrder.DeliveryStatus;
        txtDeliveryDate.Text = OrderCollection.ThisOrder.DeliveryDate.ToString();
        txtOrderDescription.Text = OrderCollection.ThisOrder.OrderDescription.ToString();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        OrderID = Convert.ToInt32(Session["OrderID"]);
        if (IsPostBack == false)
        {
            if (OrderID != -1)
            {
                DisplayOrder();
            }
            clsOrdersUser AnUser = new clsOrdersUser();
            AnUser = (clsOrdersUser)Session["AnUser"];
            Response.Write("Logged in By : " + AnUser.UserName);
        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();
        string CustomerName = txtCustomerName.Text;
        string TotalAmount = Convert.ToString(txtTAmount.Text);
        string DeliveryStatus = Convert.ToString(chkDeliveryStatus.Checked);
        string DeliveryDate = txtDeliveryDate.Text;
        string OrderDescription = txtOrderDescription.Text;
        string Error = "";
        Error = AnOrder.Valid(TotalAmount, DeliveryStatus, OrderDescription, CustomerName, DeliveryDate);

        if (Error == "")
        {
            AnOrder.OrderID = OrderID;
            AnOrder.CustomerName = CustomerName;
            AnOrder.TotalAmount = Convert.ToDouble(TotalAmount);
            AnOrder.DeliveryStatus = Convert.ToBoolean(DeliveryStatus);
            AnOrder.DeliveryDate = Convert.ToDateTime(DeliveryDate);
            AnOrder.OrderDescription = OrderDescription;

            clsOrderCollection OrderList = new clsOrderCollection();

            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }

            Response.Redirect("OrderList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnCancel_Click1(object sender, EventArgs e)
    {
        Response.Redirect("OrderList.aspx");
    }

    protected void btnTeam_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrder AnOrder = new clsOrder();

        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(txtOrderID.Text);

        Found = AnOrder.Find(OrderID);

        if (Found == true)
        {
            txtCustomerName.Text = AnOrder.CustomerName;
            txtTAmount.Text = AnOrder.TotalAmount.ToString();
            chkDeliveryStatus.Checked = AnOrder.DeliveryStatus;
            txtDeliveryDate.Text = AnOrder.DeliveryDate.ToString();
            txtOrderDescription.Text = AnOrder.OrderDescription;

        }
    }
}