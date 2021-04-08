function testForm(){
	var email = document.getElementById("txtEmail").value;
	var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;
	var LogInName = document.getElementById("txtLogInName").value;
	var pass = document.getElementById("txtPassword").value;
	var passReimported = document.getElementById("txtPasswordReimported").value;
	var name = document.getElementById("txtName").value;
	var date = document.getElementById("txtDate").value;
	var year = document.getElementById("txtYear").value;
	var chkcmt = document.getElementById("chkCmt").checked;
	if(email == "" || LogInName == "" || pass == "" || passReimported == "" || name == ""){
			alert("Không được bỏ trống thông tin!");
		}
	else if(!filter.test(email)){
		alert("Kiểm tra lại Email!");
	}
	else if(LogInName.length < 3){
		alert("Tên đăng nhập phải nhiều hơn 3 kí tự!");
	}
	else if(passReimported != pass){
		alert("Mật khẩu nhập lại không trùng khớp!");
	}
	else if(date < 1 || date > 31  ){
		alert("Ngày Sinh không đúng!");
	}
	else if(isNaN(date) || isNaN(year)){
		alert("Ngày Sinh và năm sinh phải là số!");
	}
	else if(year < 1900 ){
		alert("Năm Sinh không đúng!");
	}
	else if(year > 2012){
		alert("Chưa đủ tuổi!");
	}
	else if(chkcmt == false){
		alert("Hãy Đồng ý điều khoản chúng tôi!");
	}
}

function setMonth(){
	for (var i = 1; i <= 12; i++) {
		document.write('<option value="'+i+'">'+i+'</option>');
	}
}
