function Count(){
	

	var	sln = document.getElementById('txtSln').value;
	var cMayLanh = document.getElementById('chkMayLanh');
	var tt;
	
	if(sln==""){
		alert("Hãy nhập số lượng người!");
	}
	else if(isNaN(sln)){
		alert("Hãy nhập giá trị là số");
	}
	else if(cMayLanh.checked == true){
		if(sln > 3){
			tt =  ((sln *300)*90/100) + sln*20;
			document.getElementById("txtTinhTien").value = tt;
		}
		else{
			tt = (sln *300) + sln*20;
			document.getElementById("txtTinhTien").value = tt;
		}
	}
	else{
		if(sln > 3){
			tt =  (sln *300)*90/100;
			document.getElementById("txtTinhTien").value = tt;
		}
		else{
			tt = sln *300;
			document.getElementById("txtTinhTien").value = tt;
		}
		
	}
}