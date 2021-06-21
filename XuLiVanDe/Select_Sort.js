// Found Min, Max in array 
// Input = array, Output = Max value, Min value
        // var arr = [2,1,9,3,5];
        // var max=arr[0];
        // var min=arr[0];

        // for(var i=0;i<=arr.length-1;i++){
        //     if(max<arr[i]){
        //         max = arr[i];
        //     }
        //     else if(min>arr[i]){
        //         min = arr[i];
        //     }
        // }
        // console.log('Max: ' + max + '\n' + 'Min: ' + min);


// Select Sort Algorithm
// Input = array ,Output = ascending array
var SecArr = [2,1,9,3,5];
var step = SecArr[0];
var resultArr = [];

for(var i=0;i<=SecArr.length-1;i++){
    for(var j=0;j<=SecArr.length-1;j++){
        console.log(SecArr[i],SecArr[j]);
        if(SecArr[i]<SecArr[j]){
            step = SecArr[i];
        }
        else if(SecArr[i]>SecArr[j]){
            step = SecArr[j];
        }
        else{
            resultArr[i] = step;
        }
        console.log(resultArr);
    }
}


