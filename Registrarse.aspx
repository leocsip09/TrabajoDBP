<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="proyecto_ti.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registro de usuario EPCC</title>
</head>
<body>
    <form id="formRegistro" runat="server" method="post">
        <asp:Button runat="server" Text="Volver al inicio" OnClick="Volver_Inicio"/>
        <h2>Registrarse</h2>
        <p>Nombres: <input id="NombreRegistro" type="text" runat="server"/></p>
        <p>Apellidos: <input id="ApellidosRegistro" type="text" runat="server"/></p>
        <p>CUI: <input id="CUIRegistro" type="text" runat="server"/></p>
        <p>Correo institucional: <input id="eMailRegistro" type="email" runat="server"/></p>
        <p>Ingrese una contraseña: <input id="ContraseñaRegistro" type="password" runat="server"/></p>
        <p>Verifique su contraseña: <input id="VerifContraseñaRegistro" type="password" runat="server"/></p>
        <asp:Button ID="VerifRegistro" runat="server" Text="Registrarse" />
    </form>
</body>
</html>
