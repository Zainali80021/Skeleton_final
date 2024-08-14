<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
 <asp:Button ID="btnClearFilter" runat="server" OnClick="btnClearFilter_Click" style="z-index: 1; left: 734px; top: 390px; position: absolute;" Text="Clear Filter" />
 <asp:Button ID="btnApplyFilter" runat="server" OnClick="btnApplyFilter_Click" style="z-index: 1; left: 565px; top: 392px; position: absolute;"  Text="Apply Filter" />
 <asp:Label ID="lblText" runat="server" style="z-index: 1; left: 555px; top: 334px; position: absolute" Text="Supplier Name"></asp:Label>
 <asp:ListBox ID="lstSupplierList" runat="server" style="z-index: 1; left: 10px; top: 55px; position: absolute; height: 453px; width: 494px"></asp:ListBox>
 <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 570px; top: 77px; position: absolute" Text="Add" />
 <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 573px; top: 158px; position: absolute;" Text="Edit" />
 <asp:Button ID="btnDelete" runat="server" style="z-index: 1; left: 562px; top: 254px; position: absolute" Text="Delete" OnClick="btnDelete_Click" />
 <asp:TextBox ID="txtSupplierNameBox" runat="server" style="z-index: 1; left: 703px; top: 332px; position: absolute"></asp:TextBox>
 <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" style="z-index: 1; left: 584px; top: 464px; position: absolute" Text="Return to the Main Menu" />
 <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 704px; top: 81px; position: absolute; height: 190px; width: 143px;"></asp:Label>
    </form>
</body>
</html>
