function Notification() {

	var TDN = document.getElementsByName('txtTDN')[0].value;
	var MK = document.getElementsByName('txtMK')[0].value;
	var XNMK = document.getElementsByName('txtXNMK')[0].value;
	if(TDN == "" || MK=="" || XNMK=="") {

		alert("Xin nhập đầy đủ thông tin");
		return false;
	}

	if(TDN.length < 6) {

		alert("Tên đăng nhập ít hơn 6 kí tự");
		return false;
	}

	if(MK.toString() != XNMK.toString()) {

		alert("Mật khẩu nhập lại không trùng khớp");
		return false;

	}
	return true;
}