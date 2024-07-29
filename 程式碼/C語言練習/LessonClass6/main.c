#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	/*
	char cName[30];
	printf("請輸入全名 :");
	scanf("%s",cName);
	printf("您輸入的全名為 %s\n",cName);
	scanf("%s",cName);
	scanf("%s",cName);
	
	
	char charTest;
	
	printf("輸入測試字元 :");
	charTest = getch();
	printf("\n輸入的字元為 %c\n\n",charTest);
	*/
	
	//================================================
	/*
	char cPassword[2][5];
	
	printf("重訂密碼 :");
	int i = 0;
	while(i<4)
	{
		cPassword[0][i++]=getch();
		printf("*");
	}
	printf("\n");
	
	printf("確認密碼");
	i=0;
	while(i<4)
	{
		cPassword[1][i++]=getch();
		printf("*");
	}
	printf("\n");
	printf("\n系統告示 : 線上作業");
	
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
		printf("完成");
	}
	else
	{
		printf("失敗");
	}
	*/
	//=======================================================
	/*
	char cString[100];
	printf("\t輸入字串 :");
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
	printf("字母　：%2d 字\n",iAlphaCount);
	printf("數字　：%2d 字\n",iDigitCount);
	printf("空白　：%2d 字\n",iSpaceCount);
	printf("其他　：%2d 字\n",iOtherCount);
	*/
	
	//==========================================================
	/*
	char cString1[61], cString2[31];
	
	printf("文字內容1 :");
	gets(cString1);
	puts("");
	
	printf("文字內容2 :");
	gets(cString2);
	puts("");
	
	strcat(cString1,cString2);
	strupr(cString1);
	printf("大寫組合 :%s",cString1);
	puts(cString1);
	
	strrev(strlwr(cString1));
	printf("大小寫反轉:%s");
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
