<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="Biblioteka1_MySQL_.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Your Library</title>
<style>
    table, th, td {
        border: 1px solid black;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <h1>Colection:</h1>
                    <asp:Label ID="lblUser" runat="server" ForeColor="Black"></asp:Label>
            <asp:Label ID="lblID" runat="server" ForeColor="Black"></asp:Label>
            <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />
            <asp:Button ID="btnAddBook" runat="server" Text="Add Book" OnClick="btnAddBook_Click" />
                   <asp:ListView ID="list1" runat="server">
                    <LayoutTemplate>
                        <table>
                            <thead>
                                <tr id="headerRow" runat="server"></tr>
                            </thead>
                            <tbody>
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server"></asp:PlaceHolder>
                            </tbody>
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%# Eval("Title") %></td>
                            <td><%# Eval("Author") %></td>
                            <td><%# Eval("Year") %></td>
                            <td><%# Eval("Publisher") %></td>
                        </tr>
                    </ItemTemplate>
                    </asp:ListView>
        </div>
    </form>
</body>
</html>
