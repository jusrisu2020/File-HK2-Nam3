
var btnTime = document.getElementById("btnTime");
var Time = new Date();

var date = Time.getDate();
var day = Time.getDay();
var month = Time.getMonth()+1;
var year = Time.getFullYear();
var hour = Time.getHours();
var minute = Time.getMinutes();
var second = Time.getSeconds();

var days;
switch(day){
    case 0:
        days = "Sunday";
    case 1:
        days = "Monday";
    case 2:
        days = "Tuesday";
    case 3:
        days = "Wednesday";
    case 4:
        days = "Thursday";
    case 5:
        days = "Friday";
    case 6:
        days = "Saturday";
}
var monthPlus = (month) =>{
    var result;
    if(month < 10){
        result = "0" + month;
    }
    else{
        result = month;
    }
    return result;
}
btnTime.addEventListener("click", () =>{
    document.getElementById("TimeInfo").innerHTML = days + ", " + date + ", " + monthPlus(month) + ", " + year + "<br/>" + hour + ":" + minute + ":" + second;
})

    