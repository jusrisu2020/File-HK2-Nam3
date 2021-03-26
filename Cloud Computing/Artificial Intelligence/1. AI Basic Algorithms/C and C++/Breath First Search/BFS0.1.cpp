#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#include <stdbool.h>
#define MAX 100

int a[MAX][MAX];
int n;
_Bool visit[MAX];
int queue[MAX];

void show(int a[MAX][MAX])
{
   int i,j;
   putchar('\n');
   for (i=0;i<n;i++,putchar('\n'))
      for (j=0;j<n;j++)
         printf(" %2d ", a[i][j]);
}

void init(char *fname)
{
   FILE *f;
   f = fopen(fname,"r");
   printf( !f ? "\n File Cannot Read!!!" : "\n Read File Successfully!!!");
   fscanf(f,"%d",&n);
   printf("%d\n",n);

   int i,j;
   for (i=0;i<n;i++)
      for (j=0;j<n;j++)
         fscanf(f,"%d",&a[i][j]);

   show(a);
   fclose(f);
}

void bfs(int v)
{
   int top,bottom,k;
   top=bottom=1;
   visit[v]=true;
   queue[bottom++]=v;
   while(top!=bottom)
   {
      v=queue[top++];
      printf(" %2d ", v+1);
      for (k=0;k<n;k++)
         if (a[v][k]!=0 && !visit[k])
         {
            queue[bottom++]=k;
            visit[k]=true;
         }
   }
}

void traverse(int v)
{
   int i,j;
   for (i=0;i<n;i++)
      visit[i]=false;
    bfs(v);  
/*
   for (i=0;i<n;i++)
      if (!visit[i])
         bfs(i);
*/
}

int main(int argc, char *argv[])
{
	if(argc != 3)
	{
		printf("Vui long chay %s voi file do thi va dinh bat dau\n", argv[0]);
		exit(0);	
	}
	init(argv[1]);
	getchar();
	traverse(atoi(argv[2]));
	getchar();
	return 0;
}
