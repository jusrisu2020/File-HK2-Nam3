

function namSinh(calNS) {
	var NamSinh = document.getElementsByName('optNamSinh')[0].value;
		var oNS = new Date();
		var oGNS = oNS.getFullYear();
		for(var i=1940;i<=oGNS;i++) {
			document.write('<option value="'+i+'">'+i+'</option>');
		}
		calNS = oGNS - NamSinh;
		return calNS;
}



function Notification() {
	var HT = document.getElementsByName('txtHoTen')[0].value;
	/*var GioiTinh = document.getElementsByName('radGioiTinh')[0].value;
	var MucLuong = document.getElementsByName('txtMucLuong')[0].value;
	var HinhThucToanTG = document.getElementBysName('chkHinhThucToanTG')[0].value;
	var ThongTin = document.getElementsByName('txtThongTin')[0].value;*/

	if(HT == "") {
		alert("Hãy nhập đầy đủ họ và tên");
		return false;
	}
	return true;
}