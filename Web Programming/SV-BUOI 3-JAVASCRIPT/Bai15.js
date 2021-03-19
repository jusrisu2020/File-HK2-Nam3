window.onload = function(){
	setTimeout("switchImage()", 1000);
}

	var curren = 1;
	var numIMG = 6;

function switchImage(){
	curren++;
	document.images["myimage"].src = "images/image" + curren + ".jpg";
	console.log(curren);

	if(curren == numIMG){
		curren = 0;
	}
	setTimeout("switchImage()", 1000);
}