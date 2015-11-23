<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ClaimsTest.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Claims Test</title>
    <style type="text/css">
        ul {
            list-style: none;
            width: 90%;
            margin: 0 auto;
            line-height: 30px;
        }
        .claimValue {
            padding-left: 15px;
            color: forestgreen;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 id="signedIn" runat="server" />
            <ul id="claimsList" runat="server" />
        </div>
    </form>
</body>
</html>
