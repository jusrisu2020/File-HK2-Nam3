//Luu do thuat toan

#include<stdio.h>
#include<Math.h>

//Declare
int n;
int sum;
int x;
//Like Function
void InputFuncInt(){
	printf("\n Input N Number: ");
	scanf("%d",&n);
}

//Menu Function
void MenuFunc(){
	printf("						Math Program\n");
	printf("1.Sum Function\n2.Sum of squares\n3.Sum 1/n Function\n4.Sum 1/2n Function\n");
	printf("5.Index Number Function\n");
}

//S(n) = 1 + 2 + 3 ... + n
void SumFunc(){
	InputFuncInt();
	for(int i=1;i<=n;i++){
		printf("%d ",i);
		sum+=i;
	}
	printf("\nSum: %d",sum);
}

//S(n) = 1^2 + 2^2 + ... + n^2
void SumOfSquaresFunc(){
	InputFuncInt();
	for(int i=1;i<=n;i++){
		printf("%d ",i);
		sum+=pow(i,2);
	}
	printf("Sum: %d",sum);
}

void Sum1PartNFunc(){
	InputFuncInt();
	float sum=0;
	for(float i=1;i<=n;i++){
		printf("%f ",1/i);
		sum+=1/i;
	}
	printf("Sum: %f",sum);
}

void Sum1Part2NFunc(){
	InputFuncInt();
	float sum=0;
	for(float i=1;i<=n;i++){
		printf("%f ",1/(2*i));
		sum+=1/(2*i);
	}
	printf("Sum: %f",sum);
}

void IndexNumber(){
	
	printf("Input X Number: ");
	scanf("%d",&x);
	InputFuncInt();
	int value = pow(x,n);
	printf("Value: %d",value);
}

int main(){
	
	MenuFunc();
	
	int a;
	printf("Function Selection: ");
	scanf("%d",&a);
	switch(a){
		case 1:
			printf("	1.Sum Function\n");
			SumFunc();
			break;
		
		case 2:
			printf("	2.Sum of squares\n");
			SumOfSquaresFunc();
			break;
			
		case 3:
			printf("	3.Sum 1/n Function\n");
			Sum1PartNFunc();
			break;
			
		case 4:
			printf("	4.Sum 1/2*n Function\n");
			Sum1Part2NFunc();
			break;
		case 5:
			printf("	5.Index Number Function\n");
			IndexNumber();
			break;
	}
	return 0;
}


