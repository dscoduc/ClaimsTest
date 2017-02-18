<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClaimsTest.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Federated Claims Test</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="signedIn" runat="server" />
            <a href="https://adfs.dscoduc.com/adfs/ls/?wa=wsignout1.0&wreply=https://claimstest.dscoduc.local" style="float: right;">Sign Out</a>
            <h3>Claims provided by the Identity Provider</h3>  
	        <asp:GridView ID="ClaimsGridView" runat="server" CellPadding="3">  
                <AlternatingRowStyle BackColor="White" />  
                <HeaderStyle BackColor="#7AC0DA" ForeColor="White" />  
            </asp:GridView> 
            <div runat="server" id="SAMLData" />
        </div>
    </form>
</body>
</html>
