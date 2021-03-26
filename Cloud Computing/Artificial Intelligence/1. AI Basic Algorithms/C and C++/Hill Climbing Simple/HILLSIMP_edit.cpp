#include <stdio.h>
#include <conio.h>
#include <stdlib.h>
#define MAX 100

int n;
int cost[MAX][MAX];
bool visit[MAX];

int init(char *graphic)
{
   FILE *f;
   f=fopen(graphic,"r");
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

void SimpleHillClimbing(int begin, int end)
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

int main(int argc, char *argv[])
{
   printf("argc=%d\n",argc);
   printf("argc=%s\n",argv[0]);
   if(argc!=4){
	   printf("%s can 3 tham so: <graphic> <begin> <end>",argv[0]);
	   getch();
	   exit(0);
   }
   init(argv[1]);
   
   int begin = atoi(argv[2]);
   int end = atoi(argv[3]);

   SimpleHillClimbing(begin, end);
   getch();
   return 0;
}
