#include <stdio.h>
#include <conio.h>
#define MAX 100

typedef struct
{
    int id;
    int g;
    int dad;
} node;

node v[MAX];
node open[MAX];
int openSize=0;
node close[MAX];
int closeSize=0;

int begin = 1;
int end = 10;

int n;
int cost[MAX][MAX];

void init()
{
    FILE *f;
    f = fopen("graph.txt","r");
    fscanf(f, "%d", &n);

    printf( !f ? " File Cannot Read!!!" : " Read File Successfully!!!");
    int i,j,k;
    while (fscanf(f, "%d%d%d", &i, &j, &k) != EOF )
        cost[i][j] = k;

    for (i=1; i<=n; i++)
    {
        v[i].id = i;
        v[i].g = 0;
    }
    fclose(f);
    f = fopen("heursitic.txt","r");
    while(fscanf(f,"%d%d",&i,&j) != EOF)
        v[i].g = j;
    fclose(f);
}

void Line()
{
    printf("\n ------------------------------------------------\n");
}

node &add(node a, node b[MAX], int &size)
{
    size++;
    b[size] = a;
    
    b[size].id = a.id;
    b[size].g = a.g;
    b[size].dad = a.dad;
}

node &remove(node a, node b[MAX], int &size)
{
    int i,j;
    for (i=1; i<=size; i++)
        if (b[i].id == a.id)
            for (j=i+1; j<=size; j++)
                b[j-1] = b[j];
    size--;
}

node Min(node a[MAX], int size)
{
    int min = 10000;
    int i, pos;
    for (i=1; i<=size; i++)
        if (a[i].g<min && a[i].g>0)
        {
            min = a[i].g;
            pos = i;
        }
    return a[pos];
}

bool isIn(node a, node b[MAX], int size)
{
    int i;
    for (i=1; i<=size; i++)
        if (b[i].id == a.id)
        {
            return true;
            break;
        }
    return false;
}

void display(node a)
{
    printf("\n\t vertex %2d (g=%2d dad=%2d) ", a.id, a.g, a.dad);
}

void display(node a[MAX], int size, char s[20])
{
    int i;
    printf("\n %s: \n", s);
    for (i=1; i<=size; i++)
        display(a[i]);
}

void Backtrack(node a, node b[MAX], int size)
{
    int i;
    if (a.dad == 0)
    {
        printf("root");
    }
    else
    {
        for (i=1; i<=size; i++)
            if (b[i].id == a.dad)
            {
                printf(" %d <- ", b[i]);
                Backtrack(b[i],b,size);
            }
    }
}

void BestFirstSearch()
{
    node tmax;
    tmax.id = begin;
    tmax.g = tmax.dad = 0;
    int i;
    add(tmax,open,openSize);
    bool stop = false;

    while(!stop)
    {
        printf("\n BEST NODE: \n\t");
        display(tmax);
        remove(tmax,open,openSize);
        add(tmax,close,closeSize);
        if (tmax.id == end)
        {
            printf("\n DA TIM THAY LO TRINH ");
            stop = true;
        }
        else
        {
            for (i=1; i<=n; i++)
            {
                if (cost[tmax.id][i]>0)
                {
                    if (isIn(v[i],open,openSize))
                        if (tmax.g + cost[tmax.id][i] < v[i].g)
                        {
                            remove(v[i],open,openSize);
                            v[i].g = tmax.g + cost[tmax.id][i];
                            v[i].dad = tmax.id;
                            add(v[i],open,openSize);
                        }

                    if (!isIn(v[i],open,openSize) && !isIn(v[i],close,closeSize))
                    {
                        v[i].g = tmax.g + cost[tmax.id][i];
                        v[i].dad = tmax.id;
                        add(v[i],open,openSize);
                    }
                }
            }
        }
        if (openSize>0)
            tmax = Min(open,openSize);
        display(open,openSize,"OPEN");
        display(close,closeSize,"CLOSE");
        Line();
        getch();
    }
    //display(v,n,"DINH");
    printf("\n LO TRINH: %d <- ", close[closeSize].id);
    Backtrack(close[closeSize],close,closeSize);
}

int main()
{
    init();
    BestFirstSearch();
    getch();
    return 0;
}
