//Select Sort Algorithm
#include<stdio.h>


int arr[100];



int main(){
	
	int slm;
	
	printf("Nhap so luong mang: ",slm);
		scanf("%d",&slm);
		
	for(int i=0;i<slm;i++){
		printf("Arr[%d]: ",i,arr[i]);
		scanf("%d",&arr[i]);
	}
	
	int step = 0;
	//	Select Sort
	for(int i=0;i<slm;i++){
		printf("%d ",arr[i]);
		int min = i;
		for(int j=i+1;j<slm;j++){
			if(arr[j]<arr[min]){
				min = j;
			}
		}
		step = arr[i];
		arr[min]
		
	}
	


	
	
}
