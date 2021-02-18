function time() {
	var vTime = new Date();
	var vHours = vTime.getHours();
	var vMinutes = vTime.getMinutes();
	var vSeconds = vTime.getSeconds();
	document.write(''+vHours+'h :'+vMinutes+'m :'+vSeconds+'s');
	if(vHours>=0 && vHours<=11){
		document.write(' AM <br>');
	}
	else{
		document.write(' PM <br>');
	}
	var to = setTimeout('time()',1000);
}
