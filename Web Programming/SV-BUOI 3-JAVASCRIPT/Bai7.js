function sNS() {
	var oNS = new Date();
	var YH = oNS.getFullYear();
	for(var i=1940;i<=YH;i++) {
		document.write('<option value="'+i+'">'+i+'</option>');
	}
}

function Notification() {

	var HT = document.getElementsByName('txtHoTen')[0].value;
	if(HT == "") {
		alert("Hãy nhập đầy đủ họ và tên");
		return false;
	}

	var NS = document.getElementsByName('optNamSinh')[0].value;
	var oNS = new Date();
	var YH = oNS.getFullYear();
	if(YH - NS < 16){
		alert("Chưa đủ 16 tuổi");
		return false
	}

	var mucLuong = document.getElementsByName('txtMucLuong')[0].value;
	if(mucLuong != Number(mucLuong)){
		alert("Hãy nhập giá trị bằng số!");
		return false
	}

	var toanTG = document.getElementById('chkHinhThucToanTG').checked;
	var banTG = document.getElementById('chkHinhThucBanTG').checked;
	if(toanTG == false && banTG == false) {
		alert("Hãy chọn thời gian làm việc");
		return false;
	}

	return true;
	
}

function showInfo() {
		var csm = window.open('');
		csm.document.write("dsjhsjdhsjhdsjhd");
	}
