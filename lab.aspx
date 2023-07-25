<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lab.aspx.cs" Inherits="laboratorio3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registro de Alumnos</title>
    <link rel="stylesheet" href="estilo.css"/>
</head>
<body>
    <h1><strong>&nbsp;Registro de Alumnos</strong></h1>
    <form id="form1" runat="server" method="post">
    <p>Nombres:&nbsp;<input id="nombre" type="text" runat="server"/></p>
    <p>Apellidos:&nbsp;<input id="apellidos" type="text" runat="server"/></p>
    <p>Sexo:<br />Masculino<input id="Male" type="radio" name="sexo" runat="server"/>&nbsp;&nbsp;&nbsp;Femenino<input id="Female" type="radio" name="sexo" runat="server"/></p>
    <p>Email:&nbsp;<input id="eMail" type="email" runat="server"/></p>
    <div>Dirección:&nbsp;<input id="Direccion" type="text" runat="server"/>&nbsp;&nbsp;&nbsp;
            Ciudad: <asp:DropDownList ID="Ciudades" runat="server" />
    <p><br/>Requerimiento: <br /><textarea id="Requerimiento" rows="10" cols="40" name="S1" runat="server"></textarea></p>
        <asp:Button ID="Limpiar" runat="server" Text="Limpiar" OnClientClick="return limpiar_contenido();"/>
        <asp:Button ID="Enviar" runat="server" Text="Enviar" OnClientClick="return enviar();" class="btn btn-success btn-lg" OnClick="Enviar_Boton"/>
    </div>
    </form>
    <script src="scripts.js"></script>
</body>
</html>