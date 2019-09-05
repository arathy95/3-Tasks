<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataListView.aspx.cs" Inherits="Task3.DataListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DataList ID="DataList1" runat="server" BorderStyle="Solid" DataKeyField="productid" DataSourceID="SqlDataSource1" Width="226px" RepeatColumns="5" RepeatDirection="Horizontal" GridLines="Both">
                <ItemTemplate>
                    <table class="auto-style1">
                        <tr>
                            <td>
                                
                                <asp:Image ID="Image1" runat="server" Width="150px" ImageUrl='<%# "data:image/jpeg;base64,"+Convert.ToBase64String((byte[])Eval("imageURL")) %>' />
                                
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("productname") %>'></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("productprice") %>'></asp:Label>
                            </td>
                        </tr>
                    </table>
                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
