<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="~/web/misreservas.aspx.cs" Inherits="Visioon.web.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vision XD</title>
    <link rel="shortcut icon" href="../img/icono.png" type="image/png" />
    <link rel="stylesheet" type="text/css" href="../css/vendor/jquery.toastmessage.css" />
    <link rel="stylesheet" type="text/css" href="../css/vendor/jquery.minical.css" />
    <link rel="stylesheet" type="text/css" href="../css/estilo.css" />
    <script type="text/javascript" src="../js/vendor/jquery.js"></script>
    <script type="text/javascript" src="../js/vendor/jquery.toastmessage.js"></script>
    <link rel="stylesheet" href="../components/bootstrap2/css/bootstrap.css">
    <link rel="stylesheet" href="../components/bootstrap2/css/bootstrap-responsive.css">
    <link rel="stylesheet" href="../css/calendar.css">
</head>
<body>
    <div id="cuerpo">
        <form id="form1" runat="server">
        <asp:HiddenField ID="listaMisReservas" runat="server"></asp:HiddenField>
        <header id="header">
			<div class="marge-header">
				<a href="#"><img src="../img/logotipo.png" class="logo" /></a>
				<div class="cont-perfil">
					
                    <asp:Label ID="nombreUsuario" class="nombre-user" runat="server" Text=""></asp:Label>
					<asp:LinkButton ID="btnCerrarSesion" runat="server" 
                        onclick="btnCerrarSesion_Click"><img src="../img/avatar.png" class="avatar" /></asp:LinkButton>
                        
					<div class="limp"></div>
				</div>
				<div class="limp"></div>
			</div>
		</header>
        <nav id="menu">
			<ul>

                <li><asp:LinkButton ID="LinkInicio" runat="server"
                        onclick="linkInicio_Click">Inicio</asp:LinkButton></li>
            
				<li><asp:LinkButton ID="linkMisreservas" runat="server" 
                        onclick="linkMisreservas_Click">Mis reservas</asp:LinkButton></li>
				<li><asp:LinkButton ID="linkReservas" runat="server"
                        onclick="linkReservas_Click">Reservar</asp:LinkButton></li>
				<div class="limp"></div>
            
			</ul>
		</nav>
        </form>
        <div class="Controles-calendar page-header">
            <div class="pull-right form-inline">
                <div class="btn-group">
                    <button class="btn btn-primary" data-calendar-nav="prev">
                        << Anterior</button>
                    <button class="btn" data-calendar-nav="today">
                        Hoy</button>
                    <button class="btn btn-primary" data-calendar-nav="next">
                        Siguiente >></button>
                </div>
                <div class="btn-group">
                    <button class="btn btn-warning" data-calendar-view="year">
                        Año</button>
                    <button class="btn btn-warning active" data-calendar-view="month">
                        Mes</button>
                    <button class="btn btn-warning" data-calendar-view="week">
                        Semana</button>
                    <button class="btn btn-warning" data-calendar-view="day">
                        Dia</button>
                </div>
            </div>
            <h3>
            </h3>
        </div>
        <div class="span9">
            <div id="calendar">
            </div>
        </div>
        <div class="limp">
        </div>
        <footer id="pie">
			<p class="">&copy; 2014 - Todo los derechos reservados</p>
		</footer>
    </div>
</body>
<script type="text/javascript" src="../components/jquery/jquery.min.js"></script>
<script type="text/javascript" src="../components/underscore/underscore-min.js"></script>
<script type="text/javascript" src="../components/bootstrap2/js/bootstrap.min.js"></script>
<script type="text/javascript" src="../components/jstimezonedetect/jstz.min.js"></script>
<script type="text/javascript" src="../js/language/es-CO.js"></script>
<script type="text/javascript" src="../js/calendar.js"></script>
<script type="text/javascript" src="../js/app.js"></script>
<script type="text/javascript">
    var disqus_shortname = 'bootstrapcalendar'; // required: replace example with your forum shortname
    (function () {
        var dsq = document.createElement('script'); dsq.type = 'text/javascript'; dsq.async = true;
        dsq.src = '//' + disqus_shortname + '.disqus.com/embed.js';
        (document.getElementsByTagName('head')[0] || document.getElementsByTagName('body')[0]).appendChild(dsq);
    })();
</script>
</html>
