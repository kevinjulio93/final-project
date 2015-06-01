<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Vision.web.login" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <link rel="stylesheet" type="text/css" href="css/estilo.css" />
    <title>Iniciar sesión</title>
</head>
<body class="login-page">
    <form id="form1" runat="server">
    <div class="contenedor-login">
        <div class="login-head">
            <h2>
                Iniciar sesión</h2>
        </div>
        <div class="login-body">
            <asp:TextBox ID="txtusuario" runat="server" placeholder="Usuario" CssClass="txt-normal"></asp:TextBox>
            <asp:TextBox ID="txtcontrasena" runat="server" TextMode="Password" placeholder="Contraseña"
                CssClass="txt-normal"></asp:TextBox>
        </div>
        <div class="login-footer">
            <asp:Button ID="btnLogin" runat="server" Text="Iniciar" CssClass="btn-blue" OnClick="btnLogin_Click" />
        </div>
    </div>
    <asp:HiddenField ID="loco" runat="server"></asp:HiddenField>
    </form>
</body>
<script type="text/javascript" src="js/vendor/jquery.js"></script>
<script type="text/javascript" src="js/funciones.js"></script>
</html>
