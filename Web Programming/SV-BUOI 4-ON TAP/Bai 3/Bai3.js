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
	// Kiểm tra Email
	var email = document.getElementsByName('txtEmail')[0].value;
	var PosA = email.indexOf("@");
// // Phải có ký tự @
//  Ký tự @ không nằm ở vị trí đầu
//  Phải có ít nhất một dấu . trong địa chỉ mail

//  Phải có ít nhất 1 ký tự giữa @ và dấu . cuối cùng
//  Phải có ít nhất một ký tự sau dấu . cuối cùng
//  Không có khoảng trắng trong địa chỉ mail
	
	if(PosA < 1){
		alert("Lỗi");
	}
}
