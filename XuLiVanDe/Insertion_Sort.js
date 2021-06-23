// Insertion Sort Algorithm

var arr = [2,1,5,9,3];

for(var i=1;i<=arr.length-1;i++){
    
    var j = i-1;
    var temp = arr[i];

    while(temp<arr[j]){
        arr[j+1] = arr[j];
        j--;
    }
    arr[j+1] = temp;
}
console.log(arr);

