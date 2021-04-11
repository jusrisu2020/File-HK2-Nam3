var Hientai = new Date(); 
function setYear(){
	var Nam = Hientai.getFullYear();
	for (var i = Nam; i >= 1970; i--) {
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

	var email = document.getElementsByName('txtEmail')[0].value;
	var PosA = email.indexOf("@");
	var PosCham = email.indexOf(".");
	var PosSpace = email.indexOf(" ");
<<<<<<< HEAD:Web Programming/SV-BUOI 4-ON TAP/Bai 3/Bai3.js
	
=======

>>>>>>> bc01381ef573111f15c519e2221f8c9a452f37ee:Web Programming/SV-BUOI 4-ON TAP/BuoiTH04-OnTap/Bai 3/Bai3.js
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
	
<<<<<<< HEAD:Web Programming/SV-BUOI 4-ON TAP/Bai 3/Bai3.js
	else if(PosA < 1 || PosCham < 1){
		alert("Kiểm tra kĩ Email!");
		
	}
	else if(PosA+1 > PosCham-1){
		alert("Phải có kí tự ở giữa @ và chấm!");
	}
	else if(PosCham+1 > email.length-1){
		alert("Kiểm tra kĩ Email2!");
	}
	else if(PosSpace > 1){
		alert("Không được có khoảng trắng trong Email!");
=======
	else if(PosA < 1 || PosCham < 1 || PosSpace >= 0){
		alert("Kiểm tra lại Email!");
	}
	else if(PosA+1 > PosCham-1){
		alert("Kiểm tra lại Email2!");
	}
	else if(PosCham+1 == email.length){
		alert("Kiểm tra lại Email3");
>>>>>>> bc01381ef573111f15c519e2221f8c9a452f37ee:Web Programming/SV-BUOI 4-ON TAP/BuoiTH04-OnTap/Bai 3/Bai3.js
	}
}
