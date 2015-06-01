<%@ Page Title="" Language="C#" MasterPageFile="~/web/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="reservasSi.aspx.cs" Inherits="Visioon.web.reservasSi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="../components/bootstrap2/css/bootstrap.css">
    <link rel="stylesheet" href="../components/bootstrap2/css/bootstrap-responsive.css">
    <link rel="stylesheet" href="../css/calendar.css">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ID" runat="server">
    <asp:HiddenField ID="banderaOculto" runat="server" />
    <asp:HiddenField ID="DatosReservas" runat="server" />
    
    <div class="Controles-calendar">
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
       <asp:Button ID="Button1" runat="server" Text="Button" onclick="Button1_Click" />
    </div>

    
    <div class="span9">
        <div id="calendar">
        </div>
    </div>
    <div class="limp">
    </div>
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
</asp:Content>


