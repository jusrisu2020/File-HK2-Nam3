#include <stdio.h>
#include <conio.h>
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
   int top,bottom,s,k;
   top=bottom=1;
   visit[v]=true;
   queue[top++]=v;
   while(bottom!=top)
   {
      s=queue[bottom++];
      printf(" %2d ", s+1);
      for (k=0;k<n;k++)
         if (a[s][k]!=0 && !visit[k])
         {
            queue[top++]=k;
            visit[k]=true;
         }
      	for(k=bottom; k<=top;k++)
    		printf("%2d \n",queue[k]);
    	getchar();
   }
}

void traverse()
{
   int i,j;
   for (i=0;i<n;i++)
      visit[i]=false;
   for (i=0;i<n;i++)
      if (!visit[i])
         bfs(i);
}

int main()
{
   init("bfs.txt");
   traverse();
   getchar();
   return 0;
}
