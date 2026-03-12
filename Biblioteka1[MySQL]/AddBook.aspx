<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="Biblioteka1_MySQL_.AddBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Add Book</h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblID"  runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Title:</td>
                    <td>
                        <asp:TextBox ID="tbTitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Author:</td>
                    <td>
                        <asp:TextBox ID="tbAuthor" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Year:</td>
                    <td>
                        <asp:TextBox ID="tbYear" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Publisher:</td>
                    <td>
                        <asp:TextBox ID="tbPublisher" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Button ID="btnAdd" runat="server" Text="Add Book" OnClick="btnAdd_Click" />
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center">
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
