<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 343px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

        <br />
        <br />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Style="z-index: 1; left: 326px; top: 163px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Style="z-index: 1; left: 497px; top: 163px; position: absolute" Text="No" />

        <asp:Label ID="lblConfirmText" runat="server" Style="z-index: 1; left: 279px; top: 92px; position: absolute" Text="Do you want to delete this supplier Record?"></asp:Label>

    </form>
</body>
</html>
