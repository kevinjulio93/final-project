<%@ Page Title="" Language="C#" MasterPageFile="~/web/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="Myreservas.aspx.cs" Inherits="Visioon.web.misreservas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/fullcalendar.css" rel='stylesheet' />
    <link href='../css/fullcalendar.print.css' rel='stylesheet' media='print' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ID" runat="server">
    <section id="cont-principal">
        <div class="principal-titulo">
            <h1>Tus Reservas</h1>
        </div>

        <asp:HiddenField ID="msjOculto" runat="server"></asp:HiddenField>
        <asp:HiddenField ID="listaMisReservas" runat="server"></asp:HiddenField>
        <div class="principal-cuerpo">
            <section id="cont-principal-reservas">
           
            <div id='calendar'></div>
            
            </section>
        </div>
    </section>
    <script src="../js/vendor/moment.min.js" type="text/javascript"></script>
    <script src="../js/vendor/jquery.js" type="text/javascript"></script>
    <script src="../js/vendor/fullcalendar.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="../js/funcionesMisreservas.js"></script>
</asp:Content>
