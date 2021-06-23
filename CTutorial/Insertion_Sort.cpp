//Insertion Sort Algorithm
#include<stdio.h>
int Insertion_Sort(int ArrNum){
	int arr[100];
	for(int i=0;i<=ArrNum;i++){
		printf("Arr[%d]= ",i,arr[i]);
		scanf("%d",&arr[i]);
	}

	for(int i=1;i<=ArrNum;i++){
		int j=i-1;
		int box = arr[i];
		
		while(box<arr[j] && j>=0){
			arr[j+1] = arr[j];
			j--;
		}
		arr[j+1] = box;
	}
	
	for(int i=0;i<=ArrNum;i++){
		printf("%d ",arr[i]);
	}
}

int main(){
	int ArrNum;
	printf("Input Array Number: ",ArrNum);
	scanf("%d",&ArrNum);
	Insertion_Sort(ArrNum);
}

