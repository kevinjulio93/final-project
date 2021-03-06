﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sesion.aspx.cs" Inherits="Visioon.web.sesion" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Iniciar Sesion</title>
    <link rel="shortcut icon" href="../img/icono.png" type="image/png" />
    <link rel="stylesheet" type="text/css" href="../css/vendor/jquery.toastmessage.css" />
    <link rel="stylesheet" type="text/css" href="../css/estilo.css" />
</head>
<body>
    <form id="formAdmin" runat="server">
    <asp:HiddenField ID="msjOculto" runat="server" />
    <div class="cuerpo-sesion">
        <header id="header">
			<div class="marge-header">
                <center><img src="../img/logotipo.png" alt="" class="logo-sesion"/></center>
			</div>
		</header>
        <section id="cont-login">
           <div>
                <label class="label-normal">Correo eléctronico:</label>
                <asp:TextBox ID="txtUsuario" runat="server" placeholder="ejemplo@dominio.com" class="input-normal"></asp:TextBox>
            </div>

            <div>
                <label class="label-normal">Contraseña:</label>
                <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" class="input-normal"></asp:TextBox>
            </div>

            <asp:Button ID="btnIniciar" runat="server" Text="Iniciar Sesion" 
            class="btn-normal" onclick="btnIniciar_Click"></asp:Button>
        </section>
    </div>
    </form>
</body>
<script type="text/javascript" src="../js/vendor/jquery.js"></script>
<script type="text/javascript" src="../js/vendor/jquery.toastmessage.js"></script>
<script type="text/javascript" src="../js/funcionesSesion.js"></script>
</html>
