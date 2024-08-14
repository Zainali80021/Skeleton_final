<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstOrdersList" runat="server" Style="z-index: 1; left: 14px; top: 44px; position: absolute; height: 296px; width: 739px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" Height="29px" OnClick="btnAdd_Click" Style="z-index: 1; left: 72px; top: 358px; position: absolute; " Text="Add" Width="52px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Style="z-index: 1; left: 226px; top: 357px; position: absolute; height: 29px; width: 52px;" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Style="z-index: 1; left: 381px; top: 357px; position: absolute; width: 52px" Text="Delete" Height="29px" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Style="z-index: 1; left: 481px; top: 359px; position: absolute; width: 266px;"></asp:Label>
        <asp:Label ID="lblTitle" runat="server" Style="z-index: 1; left: 35px; top: 417px; position: absolute; width: 182px; right: 81px" Text="Enter an Order Name"></asp:Label>
        <asp:TextBox ID="txtOrderName" runat="server" Style="z-index: 1; left: 274px; top: 418px; position: absolute; width: 409px;"></asp:TextBox>
        <asp:Button ID="btnApplyFilter" runat="server" Style="z-index: 1; left: 93px; top: 468px; position: absolute; width: 222px;" Text="Apply Filter" OnClick="btnApplyFilter_Click" />
        <asp:Button ID="btnClearFilter" runat="server" Style="z-index: 1; left: 407px; top: 464px; position: absolute; width: 247px;" Text="Clear Filter" OnClick="btnClearFilter_Click" />
        <asp:Button ID="btnTeam" runat="server" OnClick="btnTeam_Click" Style="z-index: 1; left: 251px; top: 530px; position: absolute" Text="Return to the menu" />
        
    </form>
</body>
</html>
