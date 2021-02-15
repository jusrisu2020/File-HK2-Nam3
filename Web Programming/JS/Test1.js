function a() {
	var myString = "";
	for(var param of arguments){
		myString += `${param} - `
	}
	console.log(myString);
}
a('ds1','ds2',"ds3");