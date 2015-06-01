
//Este es el archivo Javascript para las funciones principales:
$(function () {

	if ($("#msjOculto").val() != undefined || $("#msjOculto").val() != null) {
		
		var a ="";
		console.log(a);
		var tipoMsj=parseInt($("#msjOculto").val().split(',')[0]);
		if(tipoMsj==0){

			$().toastmessage('showToast', {
				text     : $("#msjOculto").val().split(',')[1],
				sticky   : true,
				type     : 'error'
			});
		}
		
		if(tipoMsj==1){
			$().toastmessage('showToast', {
				text     : $("#msjOculto").val().split(',')[1],
				sticky   : true,
				type     : 'success'
			});

		}
	}


});


