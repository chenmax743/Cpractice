#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	//�˼ƼƦr�q10��1�A�C����2
	/*
	int iCount;
	
	for(iCount=10;iCount>=1;iCount-=2)
	{
		printf("1.Count=%2d\n",iCount);
	}
	
	
	//�L�ȫ��A���������
	
	iCount=20;
	
	for(;iCount>=1;)
	{
		printf("2.Count=%2d\n",iCount);
		iCount-=2;
	}
	
	//�L�ȫ��A���������
	
	iCount=10;
	
	for(;;)
	{
		printf("3.Count=%2d\n",iCount);
		iCount-=2;
		if(iCount<1)
		{
			break;
		}
	}
	*/
	
	//=======================================================
	/*
	int iSum=0;
	int i;
	
	for(i=1;i<=50;i++)
	{
		printf("%d",i);
		if(i==50)
		{
			printf("=?");
			iSum-=i;
		}
		else if(i%2==0)
		{
			printf("+");
			iSum-=i;
		}
		else
		{
			printf("-");
			iSum+=i;
		}
	}
	
	printf("\n�`�M%d\n",iSum);
	 
	
	
	//=========================================================
	
	//����4�줸���|�i��
	//00 01 10 11
	//10 11 12 13
	//20 21 22 23
	//30 31 32 33
	
	int i,j;
	
	for(i=1;i<10;i++)
	{
		for(j=1;j<10;j++)
		{
			printf("%dx%d=%2d\t",i,j,i*j);
		}printf("\n");
	}
	 */
	//====================================================================
	
	/*
	int iCft=0;  //���ƶq 
	int iRft=0;		//�ߤl�ƶq 
	int iTotalfeet=27;	//�`���� 
	int iFtcount=92;		//�}����
	
	
	for(iCft=0;iCft<=iTotalfeet;iCft++)
	{
		for(iRft=0;iRft<=iTotalfeet;iRft++)
		{
			if((iCft+iRft)==iTotalfeet)
			{
				if((iCft*2+iRft*4)==iFtcount)
				{
					printf("��:%d\��:%d\n\n",iCft,iRft);
				}
			}
		}
	}
	*/
	
	//=======================================================================
	/*
	int iEndValue,iSum=0,i;
	
	do{
		printf("�]�w�׭�:");
		scanf("%d",&iEndValue);
		if(iEndValue>=2 && iEndValue<=100)
		{
			printf("\n");
			for(i=1;i<=iEndValue;i++)
			{
				iSum+=i;
				printf("%d",i);
				if(i==iEndValue)
				{
					printf("=?");
				}
				else
				{
					printf("+");
				}
			}
			printf("�`�M : %d\n",iSum);
		}
		else
		{
			printf("Set Range : 2 To 100\n\n");
		}
	}while(iEndValue<2 || iEndValue>100);
	
	*/
	//========================================================================
	
	int iNumber1;
	int iNumber2;
	int iSwapNumber;
	int iProductNumber;
	
	
	do
	{
		printf("Set Number1 < 2 To 999> :");
		scanf("%d",&iNumber1);
		printf("\n");
	}
	while(iNumber1<2 || iNumber1>999);
	
	do
	{
		printf("Set Number2 < 2 To 999> :");
		scanf("%d",&iNumber2);
		printf("\n");
	}
	while(iNumber2<2 || iNumber2>999);
	
	if(iNumber2>iNumber1)
	{
		iSwapNumber = iNumber1;
		iNumber1 = iNumber2;
		iNumber2 = iSwapNumber;	
	}
	
	iProductNumber = iNumber1*iNumber2;
	
	while(iNumber2!=0)
	{
		iSwapNumber = iNumber1%iNumber2;
		iNumber1=iNumber2;
		iNumber2=iSwapNumber;	
	}
	
	printf("�̤j���]��:%d\n\n",iNumber1);
	printf("�̤p������ : %d\n\n",iProductNumber/iNumber1);
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	 
	
	
	return 0;

}
