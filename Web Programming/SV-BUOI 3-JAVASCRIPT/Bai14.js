/*
	-Thông báo lỗi nếu Text nhập số kg != số
	-Tổng tiền.
*/

function Notification(){
	var txtsokg = document.getElementsByName("sokg")[0].value;
	if(isNaN(txtsokg) || ""){
		alert("Hãy nhập vào số lượng và kiểu kí tự là số");
		f.sokg.value.focus();
		return false;
	}
	return true;
}

function Count(){

	var txtsokg = Number(document.getElementsByName("sokg")[0].value);
	var chkGiat = Number(document.getElementsByName("giat")[0].checked);
	var chkHap = Number(document.getElementsByName("hap")[0].checked);
	var chkUi = Number(document.getElementsByName("ui")[0].checked);

	if(chkGiat == true && chkHap == true && chkUi == true){
		f.sotien.value = 43000* txtsokg;
	}
	else if(chkGiat  == true){
		f.sotien.value = 8000 * txtsokg;
		return false;
	}
	else if(chkHap == true){
		f.sotien.value = 5000 * txtsokg;
	}
	else if(chkUi == true){
		f.sotien.value = 30000 * txtsokg;
	}
	
}