#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	/* 
	int iLength = 20;	//�x�Ϊ� 
	int iWidth = 10;		//�x�μe
	int iAnswer = iLength*iWidth;	//�x�έ��n
	
	printf("��:%d,�e:%d,",iLength,iWidth);
	printf("the answer is %d",iAnswer);	
	return 0;
	*/
	
	
	/*
	int iBornYear;
	int iWborn;
	int iTyear;
	
	printf("�X�ͥ���~��:");
	scanf("%d",&iBornYear);
	iWborn = iBornYear + 1911;
	iTyear = 2024-iWborn;
	printf("�����褸�~��:%d�A���~ %d ��",iWborn,iTyear);
	*/
	
	/*
	float iLanguage,iEnglish,iMath;
	float fTotal ;
	float fPeace ;
	
	printf("��J��妨�Z:\n");
	scanf("%f",&iLanguage);
	printf("��J�^�妨�Z:\n");
	scanf("%f",&iEnglish);
	printf("��J�ƾǦ��Z:\n");
	scanf("%f",&iMath);
	
	fTotal=iLanguage + iEnglish + iMath;
	fPeace = fTotal/3;
	
	printf("�T���`��:%.0f",fTotal);
	printf("�T�쥭��:%5.1f",fPeace);
	*/
	
	/*
	int Number1=13, Number2=13;
	
	//1:����		0:������ 
	printf("Number1==Number2:%d\n",Number1==Number2);
	printf("Number1>Number2:%d\n",Number1>Number2);
	printf("Number1<Number2:%d\n",Number1<Number2);
	*/
	
	/* 
	int iNumber = 13;
	printf("iNumber���S������0��100����:%d\n",iNumber>=0 && iNumber<=100);
	iNumber=-3;
	*/
	
	/*
	float fFaherenthire;
	float fClecius;
	
	printf("�]�w���׼�:\n");
	scanf("%f",&fClecius);
	
	fFaherenthire = 9.0/5 * fClecius +32;
	
	printf("�w�w�榡:%1.5f\n",fFaherenthire);
	printf("�q�ή榡:%1.2f\n",fFaherenthire);
	printf("�q�ή榡:%+0.1f\n",fFaherenthire);
	
	*/
	
	/*
	float fChinese;
	float fEnglish;
	float fMath;
	
	float fOne;
	float fTwo;
	float fThree;
	float fTotal;
	
	printf("[��J����A�^�y�A�ĤT�y]�u�W���Z\n");
	scanf("%f",&fChinese);
	scanf("%f",&fEnglish);
	scanf("%f",&fMath);
	
	fOne = fChinese * 0.45;
	fTwo = fEnglish * 0.35;
	fThree = fMath * 0.2;
	
	fTotal =fOne + fTwo + fThree;
	
	
	printf("�Ĥ@��Ǥ�:%0.2f\n",fOne);
	printf("�ĤG��Ǥ�:%0.2f\n",fTwo);
	printf("�ĤT��Ǥ�:%0.2f\n",fThree);
	
	printf("�y���`�Ǥ�:%0.2f\n",fTotal);
	
	*/
	
	
	
	
	
	
	float fChinese;
	float fEnglish;
	float fThirdLanguage;
	float fTotal;
	
	printf("��J����A�^��A�ĤT�y���Z:");
	scanf("%f",&fChinese);
	fChinese*=0.45;
	scanf("%f",&fEnglish);
	fEnglish*=0.35;
	scanf("%f",&fThirdLanguage);
	fThirdLanguage*=0.2;
	
	fTotal = fChinese + fEnglish + fThirdLanguage;
	
	printf("�Ĥ@��Ǥ�:%6.2f\n",fChinese);
	printf("�ĤG��Ǥ�:%6.2f\n",fEnglish);
	printf("�ĤT��Ǥ�:%6.2f\n",fThirdLanguage);
	
	printf("�y���`�Ǥ�:%6.2f\n",fTotal);
	
	
	
		
	return 0;
	
	
	
	
	
	
}
