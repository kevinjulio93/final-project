<%@ Page Title="" Language="C#" MasterPageFile="~/web/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="index.aspx.cs" Inherits="Vision.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="info-bar">
        <p>
            <span class="span-subtitulo">Reservas: </span>aqui puedes apartar la sala de telematica,
            si tienes dudas de como hacerlo has click <a href="#">aqui.</a></p>
    </div>
    <section id="cont-reservas-info">
        <div id="contenedor-form-reserva">
            <div id="cont-busq">
                <div class="right">
                    <input type="text" class="txt-icon-normal" value="25 de noviembre de 2014" readonly="true"/>
                    <a href="#" class="icon-input">
                        <img src="img/ic_calendar0.png"/></a>
                </div>
                <div class="limp"></div>
            </div>

            <div id="cont-tabla-re" class="right">
                <div class="cont-tabla">
                    <table class="table" border="0">
                    <thead>
                        <th>
                            <img src="img/ic_clock0.png" class="icon-tabla-h">
                            Horas</th>
                        <th>
                            <img src="img/ic_dispon0.png" class="icon-tabla-h">
                            Disponibilidad</th>
                    </thead>

                    <tbody>
                        
                        <tr>
                            <td>8:00 AM</td>
                            <td>No disponible
                                <img src="img/ic_dispon2.png" class="icon-tabla-b"></td>
                        </tr>

                        
                        <tr>
                            <td>1:00 PM</td>
                            <td>disponible
                                <img src="img/ic_dispon1.png" class="icon-tabla-b"></td>
                        </tr>
                        
                    </tbody>
                </table>
                </div>
            </div>

            <div id="control-reserva" class="left">

                <div class="cont-control-re">

                    <div class="left-position left">
                        <label class="mi-label">Hora de entrada:</label>
                        <div>
                            <input type="text" class="txt-icon-hora" value="7:00 AM" readonly="true"/>
                            <a href="#" class="icon-input">
                                <img src="img/ic_clock0.png"/></a>
                        </div>
                    </div>
                    
                    <div class="right-position right">
                        <label class="mi-label">Hora de salida:</label>
                        <div>
                            <input type="text" class="txt-icon-hora" value="8:00 AM" readonly="true"/>
                            <a href="#" class="icon-input-red">
                                <img src="img/ic_clock0.png"/></a>
                        </div>
                    </div>

                    <div class="limp"></div>

                    <div class="center-position">
                        <label class="mi-label">Comentario:</label>
                        <textarea class="txt-area">Este es un comentario de prueba... :)</textarea>
                    </div>
                    
                        <asp:Button ID="btn_reservar" runat="server" Text="Reservar" 
                        class="btn-normal right" onclick="btn_reservar_Click"></asp:Button>
                </div>
            </div>

            <div class="limp"></div>

           
            
        </div>
    </section>
</asp:Content>
