
//Este es el archivo Javascript para las funciones principales:
$(function () {

    if ($("#ID_msjOculto").val() != undefined) {

//alert($("#ID_msjOculto").val());
}

var panel=$("#cont-principal-reservas");

CreateMisReservas(panel);

});

function CreateMisReservas(panel){
    console.log("iniciado");

    if ($("#ID_listaMisReservas").val() != undefined) {
        console.log($("#ID_listaMisReservas").val().toString());
        var lista = JSON.parse($("#ID_listaMisReservas").val());
        var Tmes;
        var Tdia;
        var ThoraI;
        var ThoraF;

        var banderaEn=false, banderaFe=false, banderaMa=false, banderaAb=false, banderaMay=false,banderaJun=false,banderaJul=false, banderaAg=false, banderaSep=false,banderaOc=false, banderaNo=false, banderaDi=false;


        var html="";

        for (var i = 0; i < lista.length; i++) {
            var Nmes=parseInt(lista[i].Mes);
            console.log(Nmes);
            if(Nmes==1){
                if(!banderaEn){
                    Tmes="Enero";
                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";

                    for(e in lista){

                        if(lista[e].Mes=="01"){

                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }
                    banderaEn=true;
                    html+="</ul></div></div>";
                }
            }

            if(Nmes==2){
                if(!banderaFe){
                    Tmes="Febrero";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";

                    for(e in lista){

                        if(lista[e].Mes=="02"){

                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaFe=true;
                    html+="</ul></div></div>";

                }
            }

            if(Nmes== 3){
                if(!banderaMa){
                    Tmes="Marzo";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="03"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaMa=true;
                    html+="</ul></div></div>";

                }
            }

            if(Nmes== 4){
                if(!banderaAb){
                    Tmes="Abril";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="04"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaAb=true;
                    html+="</ul></div></div>";
                }

            }

            if(Nmes== 5){
                if(!banderaMay){
                    Tmes="Mayo";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="05"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaMay=true;
                    html+="</ul></div></div>";

                }
            }

            if(Nmes== 6){
                if(!banderaJun){
                    Tmes="Junio";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="06"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaJun=true;
                    html+="</ul></div></div>";

                }
            }

            if(Nmes== 7){
                if(!banderaJul){
                    Tmes="Julio";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="07"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaJul=true;
                    html+="</ul></div></div>";
                }

            }

            if(Nmes== 8){
                if(!banderaAg){
                    Tmes="Agosto";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="08"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaAg=true;
                    html+="</ul></div></div>";

                }
            }

            if(Nmes== 9){
                if(!banderaSep){
                    Tmes="Septiembre";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="09"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaSep=true;
                    html+="</ul></div></div>";
                }

            }

            if(Nmes== 10){
                if(!banderaOc){
                    
                    console.log("10XX");
                    Tmes="Octubre";
                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="10"){

                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaOc=true;
                    html+="</ul></div></div>";
                }

            }

            if(Nmes== 11){
                if(!banderaNo){
                    Tmes="Noviembre";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";

                    for(e in lista){

                        if(lista[e].Mes=="11"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaNo=true;
                    html+="</ul></div></div>";
                }

            }

            if(Nmes== 12){
                if(!banderaDi){
                    Tmes="Diciembre";

                    html+="<div class='item-mes-mirerva'>"+
                    "<div class='head-mireserva'>"+
                    "<h1 class='titulo-fecha'>"+Tmes+"</h1>"+
                    "</div><div class='body-mireserva'><ul>";



                    for(e in lista){

                        if(lista[e].Mes=="12"){


                            Tdia=lista[e].Listaitem[0].Dia;
                            ThoraI=lista[e].Listaitem[0].Horainicio.split(':')[0]+":"+lista[e].Listaitem[0].Horainicio.split(':')[1];
                            ThoraF=lista[e].Listaitem[0].Horafin.split(':')[0]+":"+lista[e].Listaitem[0].Horafin.split(':')[1];

                            html+="<li><img src='../img/ic_dispo.png' class='icon-mireserva'>"+
                            "<label class='text-dia-mireserva'>"+Tdia+"</label>"+
                            "<span class='hora-mireserva'>"+ThoraI+"-"+ThoraF+"</span>"+
                            "</li>";
                        }
                    }

                    banderaDi=true;
                    html+="</ul></div></div>";
                }

            }
        }

        html+="<div class='limp'></div>";
        panel.append(html);
    }
}