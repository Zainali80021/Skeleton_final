<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderConfirmDelete.aspx.cs" Inherits="_1_ConfirmDelete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lbltext" runat="server" Style="z-index: 1; left: 120px; top: 66px; position: absolute; width: 399px" Text="DO YOU WNAT TO DELETE THIS RECORD FROM THE DATABAsE?"></asp:Label>
        <asp:Button ID="btnNo" runat="server" Style="z-index: 1; left: 316px; top: 134px; position: absolute; height: 29px; width: 176px;" Text="No" OnClick="btnNo_Click" />
        <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Style="z-index: 1; left: 125px; top: 134px; position: absolute; width: 161px; right: 687px;" Text="Yes" Height="29px" />
    </form>
</body>
</html>
