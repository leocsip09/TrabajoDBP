<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auxiliar.aspx.cs" Inherits="laboratorio3.Auxiliar" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Sesión y cookies</title>
    <link rel="stylesheet" href="estilo.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <p id="contenidoSesion" runat="server"></p>
        <asp:Button ID="Cookies" runat="server" Text="Mostrar Cookies" class="btn btn-success btn-lg" OnClientClick="return mostrarCookies();"/>
        <br />
        <asp:TextBox ID="cookiesData" runat="server" Height="150" Width="450"></asp:TextBox>
        <br />
        <asp:Button ID="Salir" runat="server" Text="Cerrar sesión" class="btn btn-success btn-lg" OnClick="CerrarSesion" />
    </form>
    <script src="scripts.js"></script>
</body>
</html>
