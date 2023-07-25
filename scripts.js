function limpiar_contenido() {
    var none = "";
    document.getElementById("nombre").value = none;
    document.getElementById("apellidos").value = none;
    document.getElementById("Male").checked = false;
    document.getElementById("Female").checked = false;
    document.getElementById("eMail").value = none;
    document.getElementById("Direccion").value = none;
    document.getElementById("Ciudades").selectedIndex = 0;
    document.getElementById("Requerimiento").value = none;

    return false;
}

function enviar() {
    var comprobar = "";
    let estado = document.getElementById("nombre").value;
    for (let i = 0; i < estado.length; ++i) {
        if (estado.charAt(i) == '0' || estado.charAt(i) == '1' || estado.charAt(i) == '2' || estado.charAt(i) == '3' || estado.charAt(i) == '4' || estado.charAt(i) == '5' || estado.charAt(i) == '6' || estado.charAt(i) == '7' || estado.charAt(i) == '8' || estado.charAt(i) == '9') {
            alert("Error: Verifique su nombre");
            return false;
        }
    }
    if (estado == comprobar) {
        alert("Error: Ingrese su nombre");
        return false;
    }
    estado = document.getElementById("apellidos").value;
    for (let i = 0; i < estado.length; ++i) {
        if (estado.charAt(i) == '0' || estado.charAt(i) == '1' || estado.charAt(i) == '2' || estado.charAt(i) == '3' || estado.charAt(i) == '4' || estado.charAt(i) == '5' || estado.charAt(i) == '6' || estado.charAt(i) == '7' || estado.charAt(i) == '8' || estado.charAt(i) == '9') {
            alert("Error: Verifique sus apellidos");
            return false;
        }
    }
    if (estado == comprobar) {
        alert("Error: Ingrese sus apellidos");
        return false;
    }
    if (document.getElementById("Male").checked == false && document.getElementById("Female").checked == false) {
        alert("Error: Determine su sexo");
        return false;
    }
    estado = document.getElementById("eMail").value;
    for (let i = 0; i < estado.length; ++i) {
        if (estado.charAt(i) == '0' || estado.charAt(i) == '1' || estado.charAt(i) == '2' || estado.charAt(i) == '3' || estado.charAt(i) == '4' || estado.charAt(i) == '5' || estado.charAt(i) == '6' || estado.charAt(i) == '7' || estado.charAt(i) == '8' || estado.charAt(i) == '9') {
            alert("Error: Ingrese una dirección de correo electrónico válida");
            return false;
        }
        if (estado.charAt(i) == '@' && estado.substring(i, estado.length) != "@unsa.edu.pe") {
            alert("Error: Ingrese una dirección de correo electrónico válida");
            return false;
        }
    }
    if (estado == comprobar) {
        alert("Error: Ingrese su dirección de correo electrónico");
        return false;
    }
    if (!estado.includes("@")) {
        alert("Error: Ingrese una dirección de correo electrónico válida");
        return false;
    }
    if (document.getElementById("Ciudades").selectedIndex == 0) {
        alert("Error: Seleccione su ciudad");
        return false;
    }
    estado = document.getElementById("Requerimiento").value;
    if (estado == comprobar) {
        alert("Error: Ingrese un requerimiento");
        return false;
    }
    var momento = new Date();
    let mensaje = "Registro ingresado exitosamente el ";
    mensaje = mensaje.concat(momento);
    alert(mensaje);
    return true;
}

function mostrarCookies() {
    let infoCookies = document.cookie;
    let content = "";
    var flag = 0;
    for (let i = 0; i < infoCookies.length; ++i) {
        if (infoCookies[i] == "=") {
            flag = i;
            content += ":\n";
            break;
        }
        content += infoCookies[i];
    }
    for (let i = flag + 1; i < infoCookies.length; ++i) {
        if (infoCookies[i] == "&") {
            content += "\n";
        }
        else {
            content += infoCookies[i];
        }
    }
    document.getElementById("cookiesData").value = content;
    return false;
}