/* Create Object */
var myInfo = {
	id:"DTH185413",
	age:12,
	address:"Long Xuyên",
	getName: function() {
		return this.age;
	}
};
console.log(myInfo.getName());