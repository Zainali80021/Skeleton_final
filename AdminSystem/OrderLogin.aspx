<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderLogin.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblLogin" runat="server" Style="z-index: 1; left: 196px; top: 97px; position: absolute; width: 187px; bottom: 435px; margin-right: 30px" Text="Order Login Page"></asp:Label>
        <asp:Label ID="lblUserName" runat="server" Style="z-index: 1; left: 160px; top: 175px; position: absolute" Text="UserName:"></asp:Label>
        <asp:Label ID="lblPassword" runat="server" Style="z-index: 1; left: 161px; top: 231px; position: absolute" Text="Password:"></asp:Label>
        <asp:TextBox ID="txtUserName" runat="server" Style="z-index: 1; left: 264px; top: 176px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtPassword" runat="server" Style="z-index: 1; left: 266px; top: 231px; position: absolute" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Style="z-index: 1; left: 160px; top: 327px; position: absolute; width: 112px;" Text="Login" />
        <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" Style="z-index: 1; left: 321px; top: 327px; position: absolute; right: 521px;" Text="Cancel" />
        <asp:Label ID="lblError" runat="server" ForeColor="#FF3300" Style="z-index: 1; left: 172px; top: 284px; position: absolute; width: 254px;"></asp:Label>
    </form>
</body>
</html>
