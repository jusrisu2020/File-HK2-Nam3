function CheckEmail(){

	var txtE = document.getElementById("txtEmail").value;

	var filter = /^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$/;	
	
	if(!filter.test(txtE)){

		alert("Hãy nhập địa chỉ hợp lệ");
		txtE.focus();
		return false;

	}

	else{
		alert("Success!");
	}
	
}