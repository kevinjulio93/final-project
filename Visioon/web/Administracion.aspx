<%@ Page Title="Administracion" Language="C#" MasterPageFile="~/web/Administracion.Master"
    AutoEventWireup="true" CodeBehind="Administracion.aspx.cs" Inherits="Visioon.web.Administracion1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ID" runat="server">
    <section id="cont-principal">
<div class="principal-titulo">
    <h1>
        Crea tus reservas</h1>
</div>

<asp:HiddenField ID="msjOculto" runat="server"></asp:HiddenField>
<asp:HiddenField ID="listaDisponibilidad"   runat="server"></asp:HiddenField>
<div class="principal-cuerpo">
    <section class="cont-form-reserva">
        <div>
            <label class="label-normal">
            Fecha reserva:</label>
            <asp:TextBox ID="txtFecha" runat="server" Cssclass="input-normal"
                placeholder="2015/05/29" AutoPostBack="True" 
                ontextchanged="txtFecha_TextChanged" ></asp:TextBox>
        </div>
        <div>
            <label class="label-normal">
            Hora entrada:</label>
            <asp:TextBox ID="txtHoraEntrada" runat="server" Cssclass="input-normal"  
                placeholder="7:00" ></asp:TextBox>
        </div>
        <div>
            <label class="label-normal">
            Hora salida:</label>
            <asp:TextBox ID="txtHoraSalida" runat="server" Cssclass="input-normal" 
                placeholder="9:00"></asp:TextBox>
        </div>

        <div id="panel-repetir">
             
            <a class="btnRepetir" >Repetir Semanalmente</a>
            <div id="cont-repetir" display="none">
                <div>
                <label class="label-normal">
                    Fecha fin:</label>
                    <asp:TextBox ID="txtFechafin" runat="server" Cssclass="input-normal" placeholder="2014/11/25"></asp:TextBox>
                </div>
            </div>
        </div>


        <asp:Button ID="btnAgregar" runat="server" Text="Agregar reserva" 
        Cssclass="btn-normal" onclick="btnAgregar_Click"></asp:Button>
    </section>
    <section class="cont-disponibilidad-reserva">
    
        <label class="label-normal text-center">Disponibilidad</label>
        <div class="lista-disponibilidad" id="lista-disponibilidad">
            <ul>
                <%--<li>
                    <img class="disp-icon" src="../img/ic_dispo.png" />
                    <label class="disp-hora">
                    7:00 am</label> <span class="disp-etiqueta">Disponible</span> </li>--%>
                <div class="limp"></div>
            </ul>
        </div>
    </section>
    <div class="limp"></div>
</div>
</section>
    <script type="text/javascript" src="../js/vendor/jquery.minical.js"></script>
    <script type="text/javascript" src="../js/funcionesInicio.js"></script>
</asp:Content>
