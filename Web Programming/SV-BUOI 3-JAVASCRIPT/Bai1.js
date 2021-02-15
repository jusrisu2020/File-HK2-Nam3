var a = prompt("Vui lòng nhập tên bạn");
if(Number(a) || a == ""){
	
	document.write("Hãy nhập tên, F5 để làm lại");
}
else{
	document.write("Cám ơn "+a+"!");
}