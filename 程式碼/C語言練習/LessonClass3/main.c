#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	
	/*
	int iAge;		//年齡 
	
	printf("請輸入你的年齡:\n");
	scanf("%d",&iAge);
	
	if(iAge>=18)
	{
		printf("Y---\t可以投票!\n");
	}
	else
	{
		printf("N---\t不能投票!\n");
	}
	*/
	
	//------------------------------------------------------
	
	
	//成績範圍(0~800)，判斷成績等級
	//800:A
	//600~799:B
	//400~599:C
	//200~399:D
	//0~199:E
	
	/*
	int iScore;
	printf("請輸入您的成績");
	scanf("%d",&iScore);
	printf("成績等級");
	if(iScore==800)
	{
		printf("A\n");
	}
	else if(iScore>=600)
	{
		printf("B\n");
	}
	else if(iScore>=400)
	{
		printf("C\n");
	}
	else if(iScore>=200)
	{
		printf("D\n");
	}
	else if(iScore>=0)
	{
		printf("E\n");
	}
	
	*/
	
	//-------------------------------------------
	/*
	int iPoint;
	printf("英文口試成績:");
	scanf("%d",&iPoint);
	
	if(iPoint>=90)
	{
		printf("線上評比語言能力為S");
	}
	else if(iPoint>=70 && iPoint<90)
	{
		printf("線上評比語言能力為A");
	}
	else if(iPoint>=50 && iPoint<70)
	{
		printf("線上評比語言能力為B");
	}
	else if(iPoint>=30 && iPoint<50)
	{
		printf("線上評比語言能力為C");
	}
	else
	{
		printf("線上評比語言能力為D");
	}
	*/
	//---------------------------------------------------------
	
	/*
	char cGender;
	int iAge;
	printf("線上性別:");
	scanf("%c",&cGender);
	printf("年齡為:");
	scanf("%d",&iAge);
	printf("\n稱謂圖示:");
	if(cGender=='M'|| cGender=='m')
	{
		
		printf(".帥哥.");
		if(iAge>=18)
		{
			printf("成年男性");
		}
		else
		{
			printf("未成年男性");
		}
	}
	else if(cGender=='F'|| cGender=='f')
	{
		printf(".美女.");
		if(iAge>=18)
		{
			printf("成年女性");
		}
		else
		{
			printf("未成年女性");
		}
	}
	else
	{
		printf(".預設.");
	}
	*/
	
	//-------------------------------------------------------
	/*
	int iAge;
	char cGendle;
	
	printf("設定性別年齡:");
	scanf("%c",&cGendle);
	scanf("%d",&iAge);
	printf("\n線上稱謂:");
	if(cGendle=='M'||cGendle=='m')
	{		
		if(iAge>=18)
		{
			printf("SIR");		
		}
		else
		{
			printf("BOY");
		}
	}
	else if(cGendle=='F' || cGendle=='f')
	{
		
		if(iAge>=36)
		{
			printf("LADY");
		}
		else if (iAge>=18)
		{
			printf("Miss");
		}
		else 
		{
			printf("Girl");
		}
	}
	*/
	//---------------------------------------------------
	
	/*
	int iValue;
	
	printf("請輸入一到三之間任意數字");
	scanf("%d",&iValue);
	printf("你輸出的數值為:");
	
	switch(iValue)
	{
		case 1:
			printf("壹\n");
			break;
			
		case 2:
			printf("貳\n");
			break;
		case 3:
			printf("三\n");
			break;
		default:
			printf("輸入錯誤\n");
	}
	
	*/
	
	//=========================================================
	
	/*
	int iOption;
	
	printf("辦公室系列安裝軟體推薦");
	printf("\t<1>文件排版 <2>試算統計");
	printf("\t<3>動態簡報 <4>資料管理");
	scanf("%d",&iOption);
	printf("\n親愛的客戶");
	switch(iOption)
	{
		case 1:
			printf("建議購買 Office-Word");
			break;
		case 2:
			printf("建議購買 Office-Excel");
			break;
		case 3:
			printf("建議購買 Office-PowerPoint");
			break;
		case 4:
			printf("建議購買 Office-Access");
			break;
		default:
			printf("歡迎再次詢問");
	}
	*/
//===================================================================

		
	float fValue;
	printf("設定分析數值");
	scanf("%f",&fValue);
	printf("\n輸入的值，");
	int iValue=fValue/1;
	
	if(fValue-iValue!=0)
	{
		printf("不是整數。");
	}
	else
	{
		if(iValue<0)
		{
			printf("是負整數");
		}
		else
		{
			printf("是正整數");
		}
		if(iValue%2==0)
		{
			printf("也是偶數");
		}
		else
		{
			printf("也是基數");
		}
	}

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;	
}
