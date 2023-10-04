<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="ProductUI.DeleteProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="tbProductId" runat="server"></asp:TextBox>
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="DeleteProduct_Click" />
            <asp:GridView ID="gvProduct" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
