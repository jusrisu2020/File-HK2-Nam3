//Số > 2
//Số chỉ chia hết cho 1 và chính nó

var btnPrimeTest = document.getElementById("btnPrimeTest");
btnPrimeTest.addEventListener("click", ()=>{

    var txtPrime = Number(document.getElementById("txtPrime").value);
    console.log(txtPrime);
    if(txtPrime < 2){
        alert(txtPrime + " Not Prime!");
    }
    else{
        for(var i=2 ;i < txtPrime-1;i++){
            if(txtPrime % i==0){
                alert(txtPrime + " Not Prime!");
                return false;
            }
        }
        alert(txtPrime + " is Prime!");
    }
});