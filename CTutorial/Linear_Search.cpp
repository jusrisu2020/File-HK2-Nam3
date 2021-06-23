//Linear Search
#include<stdio.h>

int arr[100];
int ArrNum;

int Linear_Search(int ArrNum){
	int x;
	int result,pos;
	printf("Input X number: ",x);
	scanf("%d",&x);
	
	for(int i=0;i<ArrNum;i++){
		if(arr[i] == x){
			result = arr[i];
			pos = i;
		}
	}	
	printf("Result: %d\n",result);
	
	printf("Array location: %d",pos);
}

int main(){
	printf("Input Array number: ",ArrNum);
	scanf("%d",&ArrNum);
	
	for(int i=0;i<ArrNum;i++){
		printf("Array [%d]= ",i,arr[i]);
		scanf("%d",&arr[i]);
	}
	Linear_Search(ArrNum);
	return 0;
}
