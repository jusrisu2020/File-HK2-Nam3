#include <stdio.h>
#define MAX 100

int a[MAX][MAX];
int n;
bool visit[MAX];

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

   printf( !f ? "\n File Cannot Read!!!" : "\n Read File Succesfully!!!");
   fscanf(f,"%d", &n);

   int i,j;
   for (i=0;i<n;i++)
      for (j=0;j<n;j++)
         fscanf(f,"%d",&a[i][j]);

   show(a);
   fclose(f);
}

void dfs(int v)
{
   printf(" %2d ", v+1);
   visit[v]=true;
   for (int k=0;k<n;k++)
      if (a[v][k]==1 && !visit[k])
         dfs(k);
}

void traverse()
{
   int i;
   for (i=0;i<n;i++)
      visit[i]=false;
   for (i=0;i<n;i++)
      if (!visit[i])
         dfs(i);
}

int main()
{
   init("dfs.txt");
   printf(" ------------------------------\n");
   traverse();
   getchar();
   return 0;
}
