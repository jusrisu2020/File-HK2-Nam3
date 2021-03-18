function UCmaxBCmin(){
	var a = document.getElementsByName('a')[0].value;
	var b = document.getElementsByName('b')[0].value;
	
	var x = a
	var y = b
	// UCmax
	while(x!=y){
		if(x<y){
			y = y -x;
		}
		else{
			x = x - y;
		}
	}
	 f.UCmax.value = x;
	 y = (a*b)/x;
	 f.BCmin.value = eval(y);
	// f.BCmin.value;

}