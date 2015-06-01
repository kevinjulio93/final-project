<%@ Page Title="" Language="C#" MasterPageFile="~/web/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="inicio.aspx.cs" Inherits="Visioon.web.inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../css/fullcalendar.css" rel='stylesheet' />
    <link href='../css/fullcalendar.print.css' rel='stylesheet' media='print' />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ID" runat="server">
    <section id="cont-principal">
<div class="principal-titulo">
    <h1>
        Crea tus reservas</h1>
</div>

<asp:HiddenField ID="msjOculto" runat="server"></asp:HiddenField>
<asp:HiddenField ID="listaDisponibilidad"   runat="server"></asp:HiddenField>
<asp:HiddenField ID="DReservas"   runat="server"></asp:HiddenField>
<div class="principal-cuerpo">
    <section class="cont-form-reserva">
        <div id="calendar">
            </div>
    </section>
    <div class="limp"></div>
</div>
<div class="box">
    <div class="modal">
        <div class="modal-head">
            <h1>Crear Reserva</h1>
        </div>
        <div class="modal-body">
            <div class="cont-form-modal">
                <asp:HiddenField ID="txtFecha" runat="server"></asp:HiddenField>
                <asp:HiddenField ID="txtHoraEntrada" runat="server"></asp:HiddenField>
                <asp:HiddenField ID="txtHoraSalida" runat="server"></asp:HiddenField>

                <label class="label-normal">Numero de horas:</label>
                <asp:DropDownList ID="txtNumeroHoras" runat="server" CssClass="input-normal">
                    <asp:ListItem Value="2">2 horas</asp:ListItem>
                    <asp:ListItem Value="1">1 hora</asp:ListItem>
                </asp:DropDownList>
                <label class="label-normal">Descripcion:</label>
                 <asp:TextBox ID="txtDesccripcion" runat="server" Cssclass="input-normal" 
                placeholder="ejemplo: Clase de informatica basica." TextMode="MultiLine"></asp:TextBox>
                <br />
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar reserva" 
        Cssclass="btn-normal" onclick="btnAgregar_Click"></asp:Button>
            </div>
        </div>
    
    </div>
</div>
</section>
    <script src="../js/vendor/moment.min.js" type="text/javascript"></script>
    <script src="../js/vendor/jquery.js" type="text/javascript"></script>
    <script src="../js/vendor/fullcalendar.min.js" type="text/javascript"></script>
    <script src="../js/vendor/lang-all.js" type="text/javascript"></script>
    <script type="text/javascript" src="../js/funcionesInicio.js"></script>
</asp:Content>
