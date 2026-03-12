<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login-Register.aspx.cs" Inherits="Biblioteka1_MySQL_.Login_Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Library Login/Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <table>
          <tr>
              <td colspan="2" align="center">
                  <h1>Library Login/Register</h1>
              </td>
          </tr>
          <tr>
              <td>Login:</td>
              <td>
                  <asp:Textbox ID="tbLogin" runat="server"></asp:Textbox>
              </td>
          </tr>
            <tr>
                <td>Password:</td>
                <td>
                    <asp:Textbox ID="tbPassword" TextMode="Password" runat="server" ></asp:Textbox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
