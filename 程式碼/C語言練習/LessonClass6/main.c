#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	/*
	char cName[30];
	printf("�п�J���W :");
	scanf("%s",cName);
	printf("�z��J�����W�� %s\n",cName);
	scanf("%s",cName);
	scanf("%s",cName);
	
	
	char charTest;
	
	printf("��J���զr�� :");
	charTest = getch();
	printf("\n��J���r���� %c\n\n",charTest);
	*/
	
	//================================================
	/*
	char cPassword[2][5];
	
	printf("���q�K�X :");
	int i = 0;
	while(i<4)
	{
		cPassword[0][i++]=getch();
		printf("*");
	}
	printf("\n");
	
	printf("�T�{�K�X");
	i=0;
	while(i<4)
	{
		cPassword[1][i++]=getch();
		printf("*");
	}
	printf("\n");
	printf("\n�t�Χi�� : �u�W�@�~");
	
	int iCheakPasswordState = 1;
	for(i=0;i<4;i++)
	{
		if(cPassword[0][1]!=cPassword[1][i])
		{
			iCheakPasswordState=0;
			break;
		}
	}
	if(iCheakPasswordState)
	{
		printf("����");
	}
	else
	{
		printf("����");
	}
	*/
	//=======================================================
	/*
	char cString[100];
	printf("\t��J�r�� :");
	gets(cString);
	
	int iAlphaCount = 0,iDigitCount = 0,iSpaceCount = 0,iOtherCount = 0;
	int i=0;
	
	while(cString[i]!='\0')
	{
		if(isalpha(cString[i])){iAlphaCount++;}
		if(isalpha(cString[i])){iDigitCount++;}
		if(isalpha(cString[i])){iSpaceCount++;}
		if(isalpha(cString[i])){iOtherCount++;}
		i++;
	}
	printf("�r���@�G%2d �r\n",iAlphaCount);
	printf("�Ʀr�@�G%2d �r\n",iDigitCount);
	printf("�ťա@�G%2d �r\n",iSpaceCount);
	printf("��L�@�G%2d �r\n",iOtherCount);
	*/
	
	//==========================================================
	/*
	char cString1[61], cString2[31];
	
	printf("��r���e1 :");
	gets(cString1);
	puts("");
	
	printf("��r���e2 :");
	gets(cString2);
	puts("");
	
	strcat(cString1,cString2);
	strupr(cString1);
	printf("�j�g�զX :%s",cString1);
	puts(cString1);
	
	strrev(strlwr(cString1));
	printf("�j�p�g����:%s");
	puts(cString1);
	
	*/
	//===============================================================
	
	srand(1);
	int i;
	for(i=0;i<=30;i++)
	{
		printf("%d",rand());
	}
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
