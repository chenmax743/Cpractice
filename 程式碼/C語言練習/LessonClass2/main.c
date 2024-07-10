#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	/* 
	int iLength = 20;	//矩形長 
	int iWidth = 10;		//矩形寬
	int iAnswer = iLength*iWidth;	//矩形面積
	
	printf("長:%d,寬:%d,",iLength,iWidth);
	printf("the answer is %d",iAnswer);	
	return 0;
	*/
	
	
	/*
	int iBornYear;
	int iWborn;
	int iTyear;
	
	printf("出生民國年份:");
	scanf("%d",&iBornYear);
	iWborn = iBornYear + 1911;
	iTyear = 2024-iWborn;
	printf("對應西元年份:%d，今年 %d 歲",iWborn,iTyear);
	*/
	
	/*
	float iLanguage,iEnglish,iMath;
	float fTotal ;
	float fPeace ;
	
	printf("輸入國文成績:\n");
	scanf("%f",&iLanguage);
	printf("輸入英文成績:\n");
	scanf("%f",&iEnglish);
	printf("輸入數學成績:\n");
	scanf("%f",&iMath);
	
	fTotal=iLanguage + iEnglish + iMath;
	fPeace = fTotal/3;
	
	printf("三科總分:%.0f",fTotal);
	printf("三科平均:%5.1f",fPeace);
	*/
	
	/*
	int Number1=13, Number2=13;
	
	//1:成立		0:不成立 
	printf("Number1==Number2:%d\n",Number1==Number2);
	printf("Number1>Number2:%d\n",Number1>Number2);
	printf("Number1<Number2:%d\n",Number1<Number2);
	*/
	
	/* 
	int iNumber = 13;
	printf("iNumber有沒有介於0到100之間:%d\n",iNumber>=0 && iNumber<=100);
	iNumber=-3;
	*/
	
	/*
	float fFaherenthire;
	float fClecius;
	
	printf("設定攝氏度數:\n");
	scanf("%f",&fClecius);
	
	fFaherenthire = 9.0/5 * fClecius +32;
	
	printf("預定格式:%1.5f\n",fFaherenthire);
	printf("通用格式:%1.2f\n",fFaherenthire);
	printf("通用格式:%+0.1f\n",fFaherenthire);
	
	*/
	
	/*
	float fChinese;
	float fEnglish;
	float fMath;
	
	float fOne;
	float fTwo;
	float fThree;
	float fTotal;
	
	printf("[輸入中文，英語，第三語]線上成績\n");
	scanf("%f",&fChinese);
	scanf("%f",&fEnglish);
	scanf("%f",&fMath);
	
	fOne = fChinese * 0.45;
	fTwo = fEnglish * 0.35;
	fThree = fMath * 0.2;
	
	fTotal =fOne + fTwo + fThree;
	
	
	printf("第一科學分:%0.2f\n",fOne);
	printf("第二科學分:%0.2f\n",fTwo);
	printf("第三科學分:%0.2f\n",fThree);
	
	printf("語言總學分:%0.2f\n",fTotal);
	
	*/
	
	
	
	
	
	
	float fChinese;
	float fEnglish;
	float fThirdLanguage;
	float fTotal;
	
	printf("輸入中文，英文，第三語成績:");
	scanf("%f",&fChinese);
	fChinese*=0.45;
	scanf("%f",&fEnglish);
	fEnglish*=0.35;
	scanf("%f",&fThirdLanguage);
	fThirdLanguage*=0.2;
	
	fTotal = fChinese + fEnglish + fThirdLanguage;
	
	printf("第一科學分:%6.2f\n",fChinese);
	printf("第二科學分:%6.2f\n",fEnglish);
	printf("第三科學分:%6.2f\n",fThirdLanguage);
	
	printf("語言總學分:%6.2f\n",fTotal);
	
	
	
		
	return 0;
	
	
	
	
	
	
}
