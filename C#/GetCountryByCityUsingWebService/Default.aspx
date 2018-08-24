<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="GetCountryByCityUsingWebService.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get State By City</title>
</head>
<body style="height: 105px">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <th>Enter City: </th>
                    <td>
                        <asp:TextBox ID="EnterCity" runat="server"  ToolTip="Enter City"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"> </asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Results" runat="server">State</asp:Label></td>
                    <td>
                        <asp:TextBox ID="ResultTextBox" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="ErrorLabel" runat="server" Visible="false"></asp:Label></td>
                </tr>                 
            </table>
            <asp:Button ID="Button2" runat="server" OnClick="SearchStateByCity" Text="Search" />
        </div>
    </form>
</body>
</html>
