<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" runat="server" placeholder="ingresar usuario"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="ingresar contraseña"></asp:TextBox>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" placeholder="ingresar nombre"></asp:TextBox>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombrearea" DataValueField="idarea">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:BD_dataConnectionString %>" SelectCommand="SELECT [idarea], [nombrearea] FROM [area]"></asp:SqlDataSource>
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server" DataSourceID="SqlDataSource2" DataTextField="nombrecargo" DataValueField="idcargo">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:BD_dataConnectionString2 %>" SelectCommand="SELECT [idcargo], [nombrecargo] FROM [cargo]"></asp:SqlDataSource>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" placeholder="ingresar viaje"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Registrar" OnClick="Button1_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
