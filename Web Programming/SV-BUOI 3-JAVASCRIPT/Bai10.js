
function GiaiptBac2(){
	/*ax^2 + bx^2+c=0
	a = b = c = 0 thì x1 = 1, x2 = c/a
	a - b + c = 0 thì có nghiệm x1 - 1; x2 = -c/a
	khác 2 trường hợp trên sẽ Tính delta xét 3 dk
		delta <0 thì vo nghiệm
		delta =0 có nghiệm kép x1 = x2 = -b/2a
		delta >0 Có 2 nghiệm phân biệt: x1,2 
		= -b +- Math.sqrt(delta)/2a;
		*/

	var a = Number(document.getElementsByName('so_a')[0].value);
	var b = Number(document.getElementsByName('so_b')[0].value);
	var c = Number(document.getElementsByName('so_c')[0].value);

	if(a == 0 && b == 0 && c == 0){
		var x1 = 'x1=' + 1 +'; ';
		var x2 = 'x2= C/A';
		f.kq.value = x1 + x2;
	}

	else if(a-b+c == 0){
		var x1 = 'x1=' + -1 +'; ';
		var x2 = 'x2= -C/A';
		f.kq.value = x1 + x2;
	}

	else{
		var delta = Math.pow(b,2) - 4*a*c;
		console.log(delta);

		if(delta<0){
			f.kq.value = 'Vô nghiệm';
		}

		else if(delta==0){
			var nk = -b/2*a;
			f.kq.value = 'Có nghiệm kép x1 = x2 = -b/2a =' + nk.toFixed(5);
		}

		else{
			var n = -b + Math.sqrt(delta) /2*a;
			var n1 = -b - Math.sqrt(delta) /2*a; 
			f.kq.value = 'Có 2 nghiệm phân biệt x1,2 = ' +n.toFixed(5)+ ' ;' +n1.toFixed(10);	
			console.log(typeof n);
		}
	}
}