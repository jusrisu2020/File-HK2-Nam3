function pTB1() {
	var soA = Number(document.getElementsByName('so_a')[0].value);
	var soB = Number(document.getElementsByName('so_b')[0].value);

	if(soA==0){
		if(soB==0){
			f.kq.value = 'Vô số nghiệm';
		}
		else{
			f.kq.value = 'Vô nghiệm';
		}
	}
	else{
		if(soB != 0){
			var x = Number(-soA)/Number(soB);
			f.kq.value = x;
		}
		else{
			f.kq.value = 'Error Vì không thể chia cho 0';
		}
	}
}