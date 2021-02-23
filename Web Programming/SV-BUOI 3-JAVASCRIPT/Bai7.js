function sNS() {
	var oNS = new Date();
	var YH = oNS.getFullYear();
	for(var i=1940;i<=YH;i++) {
		document.write('<option value="'+i+'">'+i+'</option>');
	}
}

function Notification() {

	var HT = document.getElementsByName('txtHoTen')[0].value;

	var NS = document.getElementsByName('optNamSinh')[0].value;
	var oNS = new Date();
	var YH = oNS.getFullYear();

	var mucLuong = document.getElementsByName('txtMucLuong')[0].value;

	var toanTG = document.getElementById('chkHinhThucToanTG').checked;
	var banTG = document.getElementById('chkHinhThucBanTG').checked;

	if(HT == "") {
		alert("Hãy nhập đầy đủ họ và tên");
		return false;
	}
	
	if(YH - NS < 16){
		alert("Chưa đủ 16 tuổi");
		return false
	}
	
	if(mucLuong != Number(mucLuong)){
		alert("Hãy nhập giá trị bằng số!");
		return false
	}

	if(toanTG == false && banTG == false) {
		alert("Hãy chọn thời gian làm việc");
		return false;
	}
	showInfo();
	return true;
}

function showInfo() {
	var csm = window.open('');
	csm.document.write('Cám ơn! bên dưới là thông tin đăng kí của bạn');
	csm.document.write('<br/>Họ tên: '+frm.txtHoTen.value);
	csm.document.write('<br/>Năm sinh: '+frm.optNamSinh.value);
	if(frm.radGioiTinh[0].checked == true){
		csm.document.write('<br/>Giới Tính: '+frm.radGioiTinh[0].value);
	}
	else{
		csm.document.write('<br/>Giới Tính: '+frm.radGioiTinh[1].value);
	}
	csm.document.write('<br/>Mức lương đề nghị: '+frm.txtMucLuong.value);
	if(frm.chkHinhThucToanTG.checked == true){
		csm.document.write('<br/> Hình thức làm việc'+frm.chkHinhThucToanTG.value);
	}
	else{
		csm.document.write('<br/> Hình thức làm việc'+frm.chkHinhThucBanTG.value);
	}
	csm.document.write('<br/>Thông tin bổ sung: '+frm.txtThongTin.value);
}


