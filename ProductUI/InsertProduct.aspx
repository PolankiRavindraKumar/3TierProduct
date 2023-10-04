<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="ProductUI.InsertProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID: <asp:TextBox ID="tbProductId" runat="server"></asp:TextBox><br />
             Name: <asp:TextBox ID="tbProductName" runat="server"></asp:TextBox><br />
             Company: <asp:TextBox ID="tbManufacturer" runat="server"></asp:TextBox><br />
             Quantity: <asp:TextBox ID="tbQuantity" runat="server"></asp:TextBox><br />
            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="InsertProduct_Click" />
            <asp:GridView ID="gvProduct" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
