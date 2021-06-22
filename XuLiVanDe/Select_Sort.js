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
var SecArr = [9,2,3,3,5];
var step = 0;
for(var i=0;i<=SecArr.length-1;i++){
    var min = i;
    for(var j=i+1;j<=SecArr.length-1;j++){
        if(SecArr[j] < SecArr[min]){
            min = j;
        }
    }
    step = SecArr[min];
    SecArr[min] = SecArr[i];
    SecArr[i] = step;  
}
console.log(SecArr);


