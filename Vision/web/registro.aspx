<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registro.aspx.cs" Inherits="Vision.web.registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" href="css/vendor/bootstrap-datetimepicker.min.css" />
    <link rel="stylesheet" type="text/css" href="css/estilo.css" />
    <title>Registro de estudinate</title>
</head>
<body class="login-page">
    <form id="form1" runat="server">
        <div class="contenedor-login">
            <div class="login-head">
                <h2>Datos Personales</h2>
            </div>
            <div class="registro-body">
                <h3>Ingrese sus datos datos perdonales</h3>

                <asp:TextBox ID="txtidentificacion" runat="server" placeholder="Identificación" CssClass="txt-normal-registro"></asp:TextBox>
                <asp:TextBox ID="txtnombres" runat="server" placeholder="Nombres" CssClass="txt-normal-registro"></asp:TextBox>
                <asp:TextBox ID="txtapellidos" runat="server" placeholder="Apellidos" CssClass="txt-normal-registro"></asp:TextBox>
                <asp:TextBox ID="txtcorreo" runat="server" placeholder="Correo electroníco" CssClass="txt-normal-registro"></asp:TextBox>
                <asp:TextBox ID="txtcontrasena" runat="server" TextMode="Password" placeholder="Contraseña" CssClass="txt-normal-registro"></asp:TextBox>
                <asp:TextBox ID="txtccontrasena" runat="server" TextMode="Password" placeholder="Confirmar contraseña" CssClass="txt-normal-registro"></asp:TextBox>
                <asp:TextBox ID="txtprograma" runat="server" placeholder="Programa academico" CssClass="txt-normal-registro"></asp:TextBox>
                <asp:TextBox ID="txtfecha_nacimiento" data-date-format="YYYY-MM-DD" runat="server" placeholder="Fecha de nacimiento" CssClass="txt-normal-registro fechaNaci"></asp:TextBox>

            </div>

            <div class="login-footer">
                <asp:Button ID="btnRegistrar" runat="server" Text="Regístrar" CssClass="btn-blue" />
            </div>

        </div>
    </form>

    <script type="text/javascript" src="js/vendor/jquery.js"></script>
    <script type="text/javascript" src="js/vendor/moment.js"></script>
    <script type="text/javascript" src="js/vendor/transition.js"></script>
    <script type="text/javascript" src="js/vendor/collapse.js"></script>
    <script type="text/javascript" src="js/vendor/bootstrap.js"></script>
    
    <script type="text/javascript" src="js/vendor/bootstrap-datetimepicker.min.js"></script>
    <script type="text/javascript" src="js/funciones.js"></script>

</body>





</html>
