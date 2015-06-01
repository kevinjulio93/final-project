<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Vision.web.registro" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">a
<head id="Head1" runat="server">
    <title>Registro</title>
    <link rel="shortcut icon" href="../img/icono.png" type="image/png" />
    <link rel="stylesheet" type="text/css" href="../css/vendor/jquery.toastmessage.css" />
    <link rel="stylesheet" type="text/css" href="../css/estilo.css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:HiddenField ID="msjOculto" runat="server" />
    <div class="cuerpo-regitro">
        <header id="header">
			<div class="marge-header">
                <center><img src="../img/logotipo.png" alt="" class="logo-sesion"/></center>
			</div>
		</header>
        <section id="cont-login">
           <div>
                <label class="label-normal">Identificación:</label>
                <asp:TextBox ID="txtidentificacion" runat="server" CssClass="input-normal"></asp:TextBox>
            </div>

            <div>
                <label class="label-normal">Nombres:</label>
                <asp:TextBox ID="txtnombres" runat="server" CssClass="input-normal"></asp:TextBox>
            </div>

             <div>
                <label class="label-normal">Apellidos:</label>
                <asp:TextBox ID="txtapellidos" runat="server" CssClass="input-normal"></asp:TextBox>
            </div>

            <div>
                <label class="label-normal">Correo eléctronico:</label>
                <asp:TextBox ID="txtcorreo" runat="server" CssClass="input-normal"></asp:TextBox>
            </div>

            <div>
                <label class="label-normal">Contraseña:</label>
                <asp:TextBox ID="txtcontrasena" runat="server" TextMode="Password" CssClass="input-normal"></asp:TextBox>
            </div>

            <div>
                <label class="label-normal">Confirmar contraseña:</label>
                <asp:TextBox ID="txtccontrasena" runat="server" TextMode="Password" CssClass="input-normal"></asp:TextBox>
            </div>

            <div>
                <label class="label-normal">Programa al que pertenece:</label>
                <asp:TextBox ID="txtprograma" runat="server"  CssClass="input-normal"></asp:TextBox>
            </div>
            <div>
                <label class="label-normal">Fecha de nacimiento:</label>
                <asp:TextBox ID="txtfecha_nacimiento" data-date-format="YYYY-MM-DD" runat="server" CssClass="input-normal fechaNaci"></asp:TextBox>
            </div>

            <asp:Button ID="btnRegistrar" runat="server" Text="Regístrar" 
            CssClass="btn-normal" onclick="btnRegistrar_Click" />
        </section>
    </div>
    </form>
</body>
<script type="text/javascript" src="../js/vendor/jquery.js"></script>
<script type="text/javascript" src="../js/vendor/jquery.toastmessage.js"></script>
<script type="text/javascript" src="../js/funcionesSesion.js"></script>
<script type="text/javascript" src="../js/funcionesRegistro.js"></script>
</html>
