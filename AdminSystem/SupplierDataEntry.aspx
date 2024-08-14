<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SupplierDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 487px">
                <br />
                <br />
                <asp:Label ID="lblSupplierID" runat="server" Text="SupplierID" Width="78px"></asp:Label>
    <asp:TextBox ID="txtSupplierID" runat="server" Style="position: absolute; left: 110px; top: 52px; z-index: 1;"></asp:TextBox>
    <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Style="position: absolute; left: 274px; top: 372px; z-index: 1;"></asp:Button>
<p>
    &nbsp;<asp:Label ID="lblName" runat="server" Text="Name" Width="78px"></asp:Label>
    <asp:TextBox ID="txtName" runat="server" Style="position: absolute; left: 105px; top: 99px; z-index: 1;"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lblAddress" runat="server" Text="Address" Width="78px" Style="position: absolute; left: 11px; top: 138px; z-index: 1;"></asp:Label>
    <asp:TextBox ID="txtAddress" runat="server" Style="position: absolute; left: 103px; top: 136px; z-index: 1;"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lblEmail" runat="server" Text="Email" Width="78px" Style="position: absolute; left: 10px; top: 179px; z-index: 1;"></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" Style="position: absolute; left: 104px; top: 182px; z-index: 1;"></asp:TextBox>
</p>
<p>
    <asp:Label ID="lblPhone" runat="server" Text="Phone" Width="78px" Style="position: absolute; left: 12px; top: 219px; z-index: 1; right: 963px;"></asp:Label>
    <asp:TextBox ID="txtPhone" runat="server" Style="position: absolute; left: 102px; top: 221px; z-index: 1;"></asp:TextBox>
    <asp:Label ID="lblDate" runat="server" Text="Reg. Date" Style="position: absolute; left: 18px; z-index: 1; top: 261px;"></asp:Label>
    <asp:TextBox ID="txtDate" runat="server" Style="position: absolute; left: 103px; top: 260px; z-index: 1;"></asp:TextBox>
</p>
    <asp:CheckBox ID="chkActive" runat="server" style="z-index: 1; left: 132px; top: 291px; position: absolute" />
    <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 334px; top: 62px; position: absolute; width: 179px; height: 220px;" BackColor="Red" ForeColor="White"></asp:Label>
    <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 50px; top: 381px; position: absolute" Text="OK" />
    <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 378px; position: absolute; left: 140px" Text="Cancel" OnClick="btnCancel_Click" /> 
             <asp:Button ID="btnMenu" runat="server" OnClick="btnMenu_Click" style="z-index: 1; left: 54px; top: 434px; position: absolute" Text="Return to the Main Menu" />
        </div>
    </form>
</body>
</html>
