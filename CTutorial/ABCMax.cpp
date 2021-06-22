#include<stdio.h>
#include<Math.h>

int main(){
	int a,b,c;
	printf("Input A: ");
	scanf("%d",&a);
	printf("Input B: ");
	scanf("%d",&b);
	printf("Input C: ");
	scanf("%d",&c);
	
	
//	Setting Condition

	if(a>b && a>c){
		printf("A lon nhat");
	}
	else if(b>a && b>c){
		printf("B lon nhat");
	}
	else{
		printf("C lon nhat");
	}
}
