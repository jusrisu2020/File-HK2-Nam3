var Time = new Date();
var btnTime = document.getElementById("btnTime");
btnTime.addEventListener("click", () =>{
    document.getElementById("TimeInfo").innerHTML = Time;
})
