#include<stdio.h>
int main()
{
    int integer1;
    int integer2;
    printf("Enter the first integer");
    scanf("%d",&integer1);
    printf("Enter the second integer:");
    scanf("%d",&integer2);

    int temp=integer1;
    integer1=integer2;
    integer2=temp;

    printf("Integer1 is %d\n",integer1);
    printf("integer2 is %d\n",integer2);
    return 0 ;
}
