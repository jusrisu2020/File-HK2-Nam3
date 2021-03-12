function TinhTien(){

	var txtsln = f.txtSLN.value;
	var txtcount = f.txtSLN.value;
	//var chkMayBay = document.getElementsByName("txtSLN").value;

	function Count(c){
	
		 c = 2*2;
		return c;
	}

console.log(Count(1));
	if(txtsln == "" || Number.isNaN(txtsln)){
		alert("Hãy nhập kiểu kí tự là số và không dc bỏ trống");	
	}
		

		// if(txtsln > 3){
		// 	var giam = (txtcount*10)/100
		// 	txtcount = txtcount - giam;
		// }

		// if(chkMayBay.checked == true){
		// 	var countMayBay = txtsln * 20;
		// 	txtcount = txtcount +countMayBay;
		// }
}	