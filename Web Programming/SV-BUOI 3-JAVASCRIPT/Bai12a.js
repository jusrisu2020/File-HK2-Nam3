/*
- Phải có ký tự @
- Ký tự @ không nằm ở vị trí đầu
- Phải có ít nhất một dấu . trong địa chỉ mail
- Phải có ít nhất 1 ký tự giữa @ và dấu . cuối cùng
- Phải có ít nhất một ký tự sau dấu . cuối cùng
- Không có khoảng trắng trong địa chỉ mail
*/
		
function Send(){


	var txtE = document.getElementsByName('txtEmail')[0].value;
	
	var Pos_acong = txtE.indexOf("@");
	var Pos_cham = txtE.indexOf(".");
	
	if(Pos_acong == -1 
		||Pos_acong == 0 
		||Pos_cham == -1
		|| Pos_cham>txtE.length+1
		){
		
		alert("lỗi");
		

	}
	

	
}
