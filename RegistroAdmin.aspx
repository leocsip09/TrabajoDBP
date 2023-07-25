<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroAdmin.aspx.cs" Inherits="proyecto_ti.RegistroAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de administrador EPCC</title>
</head>
<body>
    <form id="formRegistroAdmin" runat="server" method="post">
        <asp:Button runat="server" Text="Volver al inicio" OnClick="Volver_Inicio"/>
        <h2>Registrarse como administrador</h2>
        <p>Nombres: <input id="NombreRegistroAdmin" type="text" runat="server"/></p>
        <p>Apellidos: <input id="ApellidosRegistroAdmin" type="text" runat="server"/></p>
        <p>CUI: <input id="CUIRegistroAdmin" type="text" runat="server"/></p>
        <p>Correo institucional: <input id="eMailRegistroAdmin" type="email" runat="server"/></p>
        <p>Ingrese una contraseña: <input id="ContraseñaRegistroAdmin" type="password" runat="server"/></p>
        <p>Verifique su contraseña: <input id="VerifContraseñaRegistroAdmin" type="password" runat="server"/></p>
        <asp:Button ID="VerifRegistroAdmin" runat="server" Text="Registrarse" />
    </form>
</body>
</html>
