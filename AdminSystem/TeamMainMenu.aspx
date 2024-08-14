<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeamMainMenu.aspx.cs" Inherits="TeamMainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 274px; background-color:burlywood">

            <asp:Label ID="Label1" runat="server" Style="z-index: 1; left: 373px; top: 81px; position: absolute" Text="Welcome to the Project"></asp:Label>
            <asp:Button ID="Button1" runat="server" Style="z-index: 1; left: 236px; top: 163px; position: absolute; height: 59px;" Text="Supplier Suman Bista" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Style="z-index: 1; left: 560px; top: 169px; position: absolute; height: 53px; width: 210px;" Text="Order Zain Malik" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
