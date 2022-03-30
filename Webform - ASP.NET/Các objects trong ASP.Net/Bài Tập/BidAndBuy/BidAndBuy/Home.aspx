<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BidAndBuy.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
             <p>
                <asp:HyperLink runat="server" Text="Login" ID="linklogin" NavigateUrl="~/Login.aspx"></asp:HyperLink></p>

            <p>
                <asp:HyperLink runat="server" Text="View Cart" ID="linkviewCart" NavigateUrl="~/Cart.aspx"></asp:HyperLink></p>
            <asp:Button runat="server" Text="Register" OnClick="DoRegister" />
        </div>
    </form>
</body>
</html>
