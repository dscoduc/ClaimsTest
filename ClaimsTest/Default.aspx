<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClaimsTest.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1><asp:label ID="signedIn" runat="server" /></h1>
            <asp:PlaceHolder ID="phClaims" runat="server" />
        </div>
    </form>
</body>
</html>
