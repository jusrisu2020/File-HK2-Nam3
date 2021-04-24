function setYear(){
	var Times = new Date();
	var Year = Times.getFullYear();
	for (var i = 1970; i <= Year; i++) {
		document.write('<option value="'+i+'">'+i+'</option>');
	}
}

function Test(){
	var Hoten = document.getElementsByName("txtHoTen")[0].value;
	var Month6 = document.getElementsByName("radThoiHan")[0].checked;
	var Month12 = document.getElementsByName("radThoiHan")[1].checked;
	var MayGiac = document.getElementsByName("MayGiac")[0];
	var MayGiac1 = document.getElementsByName("MayGiac")[1];
	var MayGiac2 = document.getElementsByName("MayGiac")[2];
	var SoLuong = document.getElementsByName("SoLuong")[0].value;

	if(Hoten == ""){
		alert("Lỗi");
	}
	else if(Month6 == false && Month12 == false){
		alert("Lỗi2");
	}
	// Tinh toán
	else if(MayGiac.text == 'Máy giặt Toshiba 6.5 kg'){
		var Total = Number(MayGiac.value * SoLuong);
		alert('Tổng chi phí: '+Number(Total)+'');
	}
	else if(MayGiac1.text == 'Máy giặt Toshiba 7.0 kg'){
		var Total = Number(MayGiac1.value * SoLuong);
		alert('Tổng chi phí: '+Number(Total)+'');
	}
	else if(MayGiac2.text == 'Máy giặt Samsung 8 kg'){
		var Total = Number(MayGiac2.value * SoLuong);
		alert('Tổng chi phí: '+Number(Total)+'');
	}
}