function User(firstName, lastName, avatar) {
	this.firstName = firstName;
	this.lastName = lastName;
	this.avatar = avatar;
	this.getName = function() {
		return `${firstName} ${lastName}`
	}
}
var author = new User("Trí","Trần","autAvatar");
var customer = new User("Vũ","Trần","cusAvatar");
author.title = "Hello";
customer.comment = "Hey!";

console.log(author);
console.log(author.getName());
console.log(customer);
