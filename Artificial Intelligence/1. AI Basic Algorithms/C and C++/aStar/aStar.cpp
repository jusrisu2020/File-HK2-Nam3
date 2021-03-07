#include <stdio.h>
#include <string.h>
#include <conio.h>
#define MAX 100

typedef struct
{
    int id;
    char name[MAX];
    int f,g,h;
    int dad;
} set;

int begin=1;
int end=2;
int n;
int cost[MAX][MAX];

set city[MAX];
set open[MAX];
int openSize=0;
set close[MAX];
int closeSize=0;

void init()
{
    FILE *f;
    f = fopen("crow.txt","r");
    printf( !f ? "\n File Cannot Read!!!" : "\n Read File Successfully!!!");

    int i,j,h,k;
    char cname[MAX];
    while (fscanf(f,"%d%s%d",&i,&cname,&h)!=EOF)
    {
        city[i].id=i;
        strcpy(city[i].name,cname);
        city[i].h=h;
        printf("\n %2d %10s (h=%3d)",i,city[i].name,city[i].h,city[i].id);
    }

    f = fopen("romania.txt","r");
    fscanf(f,"%d",&n);
    printf( !f ? "\n File Cannot Read!!!" : "\n Read File Successfully!!!");

    char c1[MAX],c2[MAX];
    while (fscanf(f,"%s%s%d",&c1,&c2,&k)!=EOF)
    {
        for (i=1;i<=n;i++)
            if (strcmp(city[i].name,c1)==0)
                for (j=1;j<=n;j++)
                    if (strcmp(city[j].name,c2)==0)
                        cost[i][j]=cost[j][i]=k;
    }

    putchar('\n');
    for (i=1;i<=n;i++)
    {
        printf("\n %9s ",city[i].name);
        for (j=1;j<=n;j++)
            printf("%3d", cost[i][j]);
    }

    fclose(f);
}

set &add(set source, set target[MAX], int &size)
{
    size++;
    target[size] = source;
}

set &remove(set a, set target[MAX], int &size)
{
    int i,j;
    for (i=1;i<=n;i++)
    {
        if (target[i].id == a.id)
        {
            for (j=i+1;j<=n;j++)
                target[j-1]=target[j];
        }
    }
    size--;
}

bool isIn(set a, set b[], int size)
{
    int i;
    for (i=1;i<=size;i++)
        if (b[i].id==a.id)
        {
            return true;
            break;
        }

    return false;
}

void show(set a[MAX],int size, char s[MAX])
{
    int i;
    printf("\n\n %s: \n",s);
    for (i=1;i<=size;i++)
        printf("\n\t %10s id=%2d f=%4d g=%3d h=%3d dad=%10s ", a[i].name, a[i].id, a[i].f, a[i].g, a[i].h, city[a[i].dad].name);
}

set Min(set a[MAX])
{
    int i;
    int pos;
    int min=10000;
    for (i=1;i<=n;i++)
        if (a[i].f<=min && a[i].f>0)
        {
            min=a[i].f;
            pos=i;
        }
    return a[pos];
}

void Backtrack(set a, set b[MAX], int size)
{
    int i;
    if (a.dad == 0)
    {
        printf(" root ");
    }
    else
    {
        for (i=1; i<=size; i++)
            if (b[i].id == a.dad)
            {
                printf(" %s <- ", b[i].name);
                Backtrack(b[i],b,size);
            }
    }
}

void aStar()
{
    add(city[begin],open,openSize);
    //show(open,openSize);
    bool stop=false;
    set tmax;
    int i;
    tmax=city[begin];

    while(!stop)
    {
        printf("\n\n *TMAX=[%s] ", tmax.name);
        remove(tmax,open,openSize);
        add(tmax,close,closeSize);
        if (tmax.id==city[end].id)
        {
            printf("\n Da tim thay loi giai");
            stop=true;
            break;
        }
        else
        {
            for (i=1; i<=n; i++)
            {
                if (cost[tmax.id][city[i].id] > 0)
                {
                    if (isIn(city[i],open,openSize))
                        if (tmax.g + cost[tmax.id][city[i].id] < city[i].g)
                        {
                            remove(city[i],open,openSize);
                            city[i].g = tmax.g + cost[tmax.id][city[i].id];
                            city[i].f = city[i].g + city[i].h;
                            city[i].dad = tmax.id;
                            add(city[i],open,openSize);
                        }

                    if (isIn(city[i],close,closeSize))
                    {
                        if (tmax.g + cost[tmax.id][city[i].id] < city[i].g)
                        {
                            remove(city[i],close,closeSize);
                            city[i].g = tmax.g + cost[tmax.id][city[i].id];
                            city[i].f = city[i].g + city[i].h;
                            city[i].dad = tmax.id;
                            add(city[i],open,openSize);
                        }
                    }
                    if (!isIn(city[i],open,openSize) && !isIn(city[i],close,closeSize))
                    {
                        city[i].dad = tmax.id;
                        city[i].g = tmax.g + cost[tmax.id][city[i].id];
                        city[i].f = city[i].g + city[i].h;
                        add(city[i],open,openSize);
                    }
                }
            }
            getch();
        }
        //getch();
        if (openSize>0)
            tmax=Min(open);
        show(open,openSize,"OPEN");
        show(close,closeSize,"CLOSE");
    }
    int j;

    show(open,openSize,"OPEN");
    show(close,closeSize,"CLOSE");

/*
    for (i=1;i<=closeSize;i++)
        printf("\n %10s ", city[close[i].dad].name);
        */
    printf("\n\n LO TRINH: %s <- ", close[closeSize].name);
    Backtrack(close[closeSize],close,closeSize);
}

int main()
{
    init();
    aStar();
    getch();
    getchar();
    return 0;
}
