// Bổ sung phần form năm sinh: năm sinh từ năm 1970 đến năm hiện tại
function setYear(){
	var Hientai = new Date(); 
	var Nam = Hientai.getFullYear();
	for (var i = 1970; i <= Nam; i++) {
		document.write('<option value="'+i+'">'+i+'</option>');
	}	
}

