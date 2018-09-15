<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="GetCityAndCapitalByState.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Get City By State</title>
</head>
<body style="height: 105px">
    <form id="form1" runat="server">
        <div class="container container-fluid" >
            <h4>Please enter US state name or state abbreviation</h4>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="SearchLabel" runat="server">Search :  </asp:Label></td> 
                    <td>
                        <asp:TextBox ID="SearchField" runat="server"  ToolTip="Enter State Name or Abbr"  ></asp:TextBox>
                    </td>
                     <td>
                        <asp:Label ID="ErrorLabel" runat="server" Visible="false" ForeColor="Red"> </asp:Label>
                    </td>  
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="largestCitylabel" runat="server">largest City :  </asp:Label></td>
                    <td>
                        <asp:TextBox ID="largestCityTextBox" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:Label ID="ErrorlabelCity" runat="server" Visible="false" ForeColor ="Red"> </asp:Label>
                    </td>                
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="CapitalLabel" runat="server">Capital :  </asp:Label></td>
                    <td>
                        <asp:TextBox ID="CapitalTextBox" runat="server"></asp:TextBox></td> 
                    <td>
                        <asp:Label ID="ErrorlabelCapital" runat="server" Visible="false" ForeColor="Red"> </asp:Label>
                    </td>
                </tr>                                
            </table>
            <asp:Button ID="Search" runat="server" OnClick="SearchByState" Text="Search" />
        </div>
    </form>
</body>

</html>
