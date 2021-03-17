function UCmaxBCmin(){
	var a = document.getElementsByName('a')[0].value;
	var b = document.getElementsByName('b')[0].value;
	
	// UCmax
	while(a!=b){
		if(a<b){
			b = b -a;
		}
		else{
			a = a - b;
		}
	}

	 f.UCmax.value= a;
	// f.BCmin.value;

}