<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierLogin.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 296px;
        }
    </style>
</head>
<body>
    Hello world from Universe.
    <br>
    <form id="form1" runat="server">
        <asp:Label ID="LabelInfo" runat="server" Style="z-index: 1; left: 7px; top: 68px; position: absolute" Text="Suppliers Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" Style="z-index: 1; left: 39px; top: 117px; position: absolute" Text="UserName: "></asp:Label>
        <asp:Label ID="lblPassword" runat="server" Style="z-index: 1; left: 41px; top: 171px; position: absolute" Text="Password: "></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Style="z-index: 1; left: 169px; top: 120px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" Style="z-index: 1; left: 166px; top: 168px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Style="z-index: 1; left: 80px; top: 232px; position: absolute; width: 86px; right: 807px;" Text="Login" />
        <asp:Label ID="lblError" runat="server" ForeColor="Red" Style="z-index: 1; left: 403px; top: 111px; position: absolute; height: 81px; width: 170px;"></asp:Label>
        <asp:Button ID="btnCancel" runat="server" Style="z-index: 1; left: 217px; top: 231px; position: absolute; width: 96px;" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>
