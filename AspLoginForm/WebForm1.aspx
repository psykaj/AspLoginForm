<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AspLoginForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login page using asp.net</title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            UserName :
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </p>
        <p>
            Password :
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblMessage" runat="server" Text="Label" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        </p>
    </form>
</body>
</html>
