<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UploadImage.aspx.cs" Inherits="Task3.UploadImage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Product Name: </td><td><asp:TextBox ID="txtproductname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Product Price: </td><td><asp:TextBox ID="txtproductprice" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Show Image: </td><td><img width="150" src="WebForm1.aspx" /></td>
                </tr>
                <tr>
                    <td>Upload Image: </td><td><asp:FileUpload ID="uploadimage" runat="server" /></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnuploadimage" runat="server" Text="Upload Image" OnClick="btnuploadimage_Click" /></td>
                    <td>
                        <asp:Button ID="btnredirect" runat="server" Text="Redirect to DataList View" OnClick="btnredirect_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
