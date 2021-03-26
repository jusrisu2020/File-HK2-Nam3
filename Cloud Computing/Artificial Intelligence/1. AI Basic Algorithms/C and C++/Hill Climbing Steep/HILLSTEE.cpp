#include <stdio.h>
#include <conio.h>
#define MAX 100

int n;
int cost[MAX][MAX];
bool visit[MAX];
int begin=1; // dinh bat dau
int end=10;  // dinh ket thuc

void init()
{
   FILE *f;
   f=fopen("graph.txt","r");
   fscanf(f,"%d",&n);
   int i,j,k;
   while (fscanf(f,"%d%d%d",&i,&j,&k)!=EOF)
      cost[i][j]=cost[j][i]=k;
   f=fopen("d:/files/graph04h.txt","r");

   fclose(f);

   printf("\n Ma tran trong so:\n");
   for (i=1;i<=n;i++,putchar('\n'))
      for (j=1;j<=n;j++)
         printf("%3d", cost[i][j]);
   putchar('\n');
   putchar('\n');
}

bool ExistTheNext(int v)
{
   int i;
   for (i=1;i<=n;i++)
      if (cost[v][i]>0 && !visit[i])
         return true;
   return false;
}

void SteepHillClimbing()
{
   int tmax,tk;
   bool stop=false;
   tmax=begin;
   visit[begin]=true;

   while (!stop)
   {
      printf("%4d", tmax);
      if (tmax==end)
      {
         printf("\n Da tim thay loi giai");
         stop=true;
      }
      else
      {
         if (!ExistTheNext(tmax)) // Khong ton tai trang thai ke tiep cua tmax
         {
            printf("\n Khong tim thay loi giai");
            stop=true;
         }
         else
         {
            int min=10000;
            int pos;
            for (tk=1;tk<=n;tk++)
               if (cost[tmax][tk]>0 && cost[tmax][tk]<min && !visit[tk])
               {
                  min=cost[tmax][tk];
                  visit[tk]=true;
                  pos=tk;
               }
            tmax=pos;
         }
      }
   }
}

int main()
{
   init();
   SteepHillClimbing();
   getch();
   return 0;
}
