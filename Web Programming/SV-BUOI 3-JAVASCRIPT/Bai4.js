function time() {
	var inpTime = new Date();
	var pDay = inpTime.getDay();
	var pDate = inpTime.getDate();
	var pMonth = inpTime.getMonth()+1;
	var pYear = inpTime.getFullYear();

	switch(pDay){
		case 0: pDay = 'Chủ nhật'; break;
		case 1: pDay = 'Thứ Hai'; break;
		case 2: pDay = 'Thứ Ba'; break;
		case 3: pDay = 'Thứ Tư'; break;
		case 4: pDay = 'Thứ Năm'; break;
		case 5: pDay = 'Thứ Sáu'; break;
		case 6: pDay = 'Thứ Bảy'; break;
	}
	document.write('Hôm nay là '+pDay+', '+pDate+', '+pMonth+', '+pYear+'');
}