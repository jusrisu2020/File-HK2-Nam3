#include <stdio.h>
#include <conio.h>
#define MAX 100

int cost[MAX][MAX];
int n;
bool found = false;
bool visit[MAX];
int begin = 1;
int end = 10;
int dad[MAX];
int limit = 3;

void init()
{
    FILE *f;
    f = fopen("map01.txt","r");
    printf( !f ? " File Cannot Read!!!" : " Read File Successfully!!!");

    fscanf(f, "%d", &n);

    int i,j;

    while (fscanf(f, "%d%d", &i,&j) != EOF)
        cost[i][j] = cost[j][i] = 1;

    putchar('\n');
    for (i=1; i<=n; i++, putchar('\n'))
        for (j=1; j<=n; j++)
            printf(" %d ", cost[i][j]);
    fclose(f);
}

/* Tim duong di */
void DLS(int v, int k)
{
    int i;
    visit[v] = true;
    if (k>=limit && !found)
    {
        return;
    }
    else
    {
        for (i=1; i<=n; i++)
            if (cost[v][i] && !visit[i])
            {
                dad[i] = v;
                if (i==end)
                {
                    found = true;
                }
                else
                {
                    DLS(i,k+1);
                }
            }
    }
}

/* Duyet do thi*/
void DLS2(int v, int k)
{
    visit[v] = true;
    int i;
    if (k>=limit)
        return;
    else
    {
        printf(" %d ", v);
        for (i=1; i<=n; i++)
            if (cost[v][i] && !visit[i])
                DLS2(i,k+1);
    }
}

void DepthLimitedSearch()
{
    int i;
    for (i=1; i<=n; i++)
        visit[i] = false;
    DLS(begin,0);

    int e = end;
    if (!found)
        printf("\n Khong tim thay duong di tu %d -> %d voi limit=%d", begin, end, limit);
    else
    {
        printf("\n Da tim thay duong di tu %d -> %d limit=%d: \n %d <- ", begin, end, limit, end);
        do
        {
            e = dad[e];
            printf(" %d <- ", e);
        } while(e!=begin);
        printf("root");
    }

    for (i=1; i<=n; i++)
        visit[i] = false;

    printf("\n Duyet do thi: \n");
    for (i=1; i<=n; i++)
        if (!visit[i])
            DLS2(i,0);

}

int main()
{
    init();
    DepthLimitedSearch();
    getch();
    return 0;
}
