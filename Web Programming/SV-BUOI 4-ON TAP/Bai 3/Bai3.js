var Hientai = new Date(); 

function setYear(){
	var Nam = Hientai.getFullYear();
	for (var i = 1970; i <= Nam; i++) {
		document.write('<option value="'+i+'">'+i+'</option>');
	}	
}

// Setting Day text
function setDay(){
	var nDay = Hientai.getDate();
	var nThang = Hientai.getMonth() + 1;
	var nNam = Hientai.getFullYear();
 	document.write('<input type="text" value="'+nDay+'/'+nThang+'/'+nNam+'" disabled="disabled"/>');
}

function Test(){
	var hoten = document.getElementsByName('txtHoTen')[0].value;
	var dienthoai = document.getElementsByName('txtDienThoai')[0].value;
	var diachi = document.getElementsByName('txtDiaChi')[0].value;
	var namsinh = document.getElementsByName('NamSinh')[0].value;
	var thoihan6 = document.getElementsByName('radThoiHan')[0].checked;
	var thoihan12 = document.getElementsByName('radThoiHan')[1].checked;


	if(hoten == "" || dienthoai == "" || diachi == ""){
		alert("Hãy điền đầy đủ thông tin!");
	}
	else if (hoten.length < 4) 
	{
		alert("Họ tên phải nhiều hơn 4 kí tự!");
	}
	else if(namsinh >= Hientai.getFullYear() - 15){
		alert("Chưa đủ tuổi");
	}
	else if(thoihan6 == false && thoihan12 == false){
		alert("Phải chọn 1 trong 2 thời hạn");
	}
	else if(isNaN(dienthoai)){
		alert("Hãy nhập đúng Số điện thoại!");
	}
	else if()

}