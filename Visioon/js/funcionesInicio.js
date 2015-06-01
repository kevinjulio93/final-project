var lista;
var estado=false;
//Este es el archivo Javascript para las funciones principales:
$(function () {

//Administracion();
calendario();

cargarCalendario();
mostrarBox();
$("body,html").animate({
    scrollTop:300
},500);
return false;

});

$('.box').click(function(){
    $(this).fadeOut();

});

if ($("#ID_msjOculto").val() != undefined || $("#ID_msjOculto").val()!="") {
    var tipoMsj=parseInt($("#ID_msjOculto").val().split(',')[0]);
    if(tipoMsj==0){

        $().toastmessage('showToast', {
            text     : $("#ID_msjOculto").val().split(',')[1],
            sticky   : true,
            type     : 'error'
        });

    }
    if(tipoMsj==1){
        $().toastmessage('showToast', {
            text     : $("#ID_msjOculto").val().split(',')[1],
            sticky   : true,
            type     : 'success'
        });

    }
}

function cargarCalendario(){

    if($('#ID_DReservas').val()!=undefined|| $('#ID_DReservas').val()!=""){

        lista = JSON.parse($("#ID_DReservas").val());
        console.log(lista);
         for (x in lista){
            $('#calendar').fullCalendar('renderEvent', lista[x], true); // stick? = true
        }

}
}


function calendario(){
//console.log("HOLA");

$('#calendar').fullCalendar({
    header: {
        left: 'prev,next today',
        center: 'title',
        right: 'month,agendaWeek,agendaDay'
    },
    defaultDate: Date.now(),
businessHours: false, // display business hours
lang:'es',
selectable: true,
selectHelper: false,
eventLimit:true,
select: function(start, end) {
    if(estado){
        $('.box').fadeIn();
        //var title = prompt('Event Title:');
        var id;
        var Title;
        
      
        console.log(start);
        //var fecha=start._d.getUTCFullYear()+"-"+start._d.getMonth()+"-"+start._d.getDay();
        var fecha=start._d.toISOString().split('T')[0];
        var horaentrada=start._d.getUTCHours()+":00:00";
        var horasalida=end._d.getUTCHours()+":00:00";

        console.log(fecha);
        console.log(horaentrada);
        console.log(horasalida);

        $('#ID_txtFecha').val(fecha);
        $('#ID_txtHoraEntrada').val(horaentrada);
        $('#ID_txtHoraSalida').val(horasalida);
        
//console.log(get(eventData.start._d));

    }
//$('#calendar').fullCalendar('removeEvents', 10, true);

},
editable: false,

});

}

function mostrarBox(){
console.log($('.btns-calendar')[5]);
$($('.btns-calendar')[5]).addClass('ID_RESER');

$('.ID_RESER').click(function(){
    estado=true;
    console.log(estado);
});

}