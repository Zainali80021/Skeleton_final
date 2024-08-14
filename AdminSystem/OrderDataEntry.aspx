<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblCustomerName" runat="server" Style="z-index: 1; left: 8px; top: 109px; position: absolute; width: 127px" Text="Customer Name"></asp:Label>
        <div>
        </div>
        <asp:TextBox ID="txtOrderID" runat="server" Style="z-index: 1; left: 209px; top: 53px; position: absolute; width: 126px;"></asp:TextBox>
        <asp:TextBox ID="txtCustomerName" runat="server" Style="z-index: 1; left: 205px; top: 103px; position: absolute; width: 126px; bottom: 426px;" Height="22px"></asp:TextBox>
        <p>
            &nbsp;
        </p>
        <p>
            <asp:TextBox ID="txtTAmount" runat="server" Style="z-index: 1; left: 200px; top: 156px; position: absolute; margin-top: 0px" Height="22px" Width="126px"></asp:TextBox>
            <asp:Label ID="lblDeliveryDate" runat="server" Style="z-index: 1; left: 0px; top: 208px; position: absolute" Text="Delivery Date" Width="127px"></asp:Label>
            <asp:Label ID="lblOrderID" runat="server" Style="z-index: 1; left: 9px; top: 54px; position: absolute" Text="OrderID" Width="127px"></asp:Label>
        </p>
        <asp:Label ID="lblTotalAmount" runat="server" Style="z-index: 1; left: 7px; top: 156px; position: absolute; height: 21px; width: 127px" Text="Total Amount"></asp:Label>
        <asp:TextBox ID="txtDeliveryDate" runat="server" Style="z-index: 1; left: 201px; top: 206px; position: absolute" Height="22px" Width="126px"></asp:TextBox>
        <p>
            <asp:CheckBox ID="chkDeliveryStatus" runat="server" Style="z-index: 1; left: 190px; top: 303px; position: absolute" Text="Delivery Status" />
        </p>
        <asp:Label ID="lblError" runat="server" Style="z-index: 1; left: 28px; top: 349px; position: absolute; width: 395px;"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; top: 385px; position: absolute; width: 189px; left: 278px; margin-top: 12px" Text="Cancel" OnClick="btnCancel_Click1" />
        <asp:Button ID="btnOK" runat="server" Height="26px" OnClick="btnOK_Click" Style="z-index: 1; left: 46px; top: 397px; position: absolute; width: 164px;" Text="OK" />
        <p>
            <asp:Button ID="btnFind" runat="server" Style="z-index: 1; left: 387px; top: 53px; position: absolute; width: 114px; margin-bottom: 5px" Text="Find" OnClick="btnFind_Click" />
        </p>
        <p>
            <asp:Button ID="btnTeam" runat="server" Style="z-index: 1; left: 138px; top: 456px; position: absolute" Text="Return to the Menu" OnClick="btnTeam_Click" />
            <asp:Label ID="lblOrderDescription" runat="server" Style="z-index: 1; left: 4px; top: 256px; position: absolute" Text="Order Description"></asp:Label>
            <asp:TextBox ID="txtOrderDescription" runat="server" Style="z-index: 1; left: 199px; top: 253px; position: absolute"></asp:TextBox>
        </p>
    </form>
</body>
</html>
