<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VerBaseDatos.aspx.cs" Inherits="proyecto_ti.VerBaseDatos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Base de datos EPCC</title>
</head>
<body>
    <form id="formBaseDatos" runat="server">
        <h2>Ver base de datos:</h2>
        <asp:DropDownList ID="Implementos" runat="server" EnablePageMethods="true" AutoPostBack="true"></asp:DropDownList>
        <p>Deporte: <asp:TextBox ID="Deporte" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Cantidad: <asp:TextBox ID="Cantidad" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Observaciones: <asp:TextBox ID="Observaciones" runat="server" ReadOnly="true"></asp:TextBox></p>
        <p>Disponible: <asp:TextBox ID="Disponible" runat="server" ReadOnly="true"></asp:TextBox></p>
    </form>
</body>
</html>
