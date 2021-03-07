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

   fclose(f);

   printf("\n Ma tran trong so:\n");
   for (i=1;i<=n;i++,putchar('\n'))
      for (j=1;j<=n;j++)
         printf("%3d", cost[i][j]);
   putchar('\n');
   putchar('\n');
}

void SimpleHillClimbing()
{
   int tmax, tk; // trang thai tot nhat, trang thai ke
   int pos; // dung de ghi nho trang thai tot nhat
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
      if (visit[end]) // neu da duyet qua nut end ma tmax != end thi ko tim thay loi giai
      {
         printf("\n Khong tim thay loi giai");
         stop=true;
      }
      else
      {
         for (tk=1;tk<=n;tk++)
            if (cost[tmax][tk]>0 && !visit[tk])
            {
               pos=tk; // chon nut dau tien tim thay dc
               visit[tk]=true;
               break;
            }

         for (tk=pos+1;tk<=n;tk++)
            if (cost[tmax][tk]>0 && !visit[tk])
               visit[tk]=true; // ko xet nhung nut con lai nua
         tmax=pos; // gan tmax = nut dau tien tim thay
      }
   }
}

int main()
{
   init();  
   SimpleHillClimbing();
   getch();
   return 0;
}
