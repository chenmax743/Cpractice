#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	
	/*
	int iAge;		//�~�� 
	
	printf("�п�J�A���~��:\n");
	scanf("%d",&iAge);
	
	if(iAge>=18)
	{
		printf("Y---\t�i�H�벼!\n");
	}
	else
	{
		printf("N---\t����벼!\n");
	}
	*/
	
	//------------------------------------------------------
	
	
	//���Z�d��(0~800)�A�P�_���Z����
	//800:A
	//600~799:B
	//400~599:C
	//200~399:D
	//0~199:E
	
	/*
	int iScore;
	printf("�п�J�z�����Z");
	scanf("%d",&iScore);
	printf("���Z����");
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
	printf("�^��f�զ��Z:");
	scanf("%d",&iPoint);
	
	if(iPoint>=90)
	{
		printf("�u�W����y����O��S");
	}
	else if(iPoint>=70 && iPoint<90)
	{
		printf("�u�W����y����O��A");
	}
	else if(iPoint>=50 && iPoint<70)
	{
		printf("�u�W����y����O��B");
	}
	else if(iPoint>=30 && iPoint<50)
	{
		printf("�u�W����y����O��C");
	}
	else
	{
		printf("�u�W����y����O��D");
	}
	*/
	//---------------------------------------------------------
	
	/*
	char cGender;
	int iAge;
	printf("�u�W�ʧO:");
	scanf("%c",&cGender);
	printf("�~�֬�:");
	scanf("%d",&iAge);
	printf("\n�ٿ׹ϥ�:");
	if(cGender=='M'|| cGender=='m')
	{
		
		printf(".�ӭ�.");
		if(iAge>=18)
		{
			printf("���~�k��");
		}
		else
		{
			printf("�����~�k��");
		}
	}
	else if(cGender=='F'|| cGender=='f')
	{
		printf(".���k.");
		if(iAge>=18)
		{
			printf("���~�k��");
		}
		else
		{
			printf("�����~�k��");
		}
	}
	else
	{
		printf(".�w�].");
	}
	*/
	
	//-------------------------------------------------------
	/*
	int iAge;
	char cGendle;
	
	printf("�]�w�ʧO�~��:");
	scanf("%c",&cGendle);
	scanf("%d",&iAge);
	printf("\n�u�W�ٿ�:");
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
	
	printf("�п�J�@��T�������N�Ʀr");
	scanf("%d",&iValue);
	printf("�A��X���ƭȬ�:");
	
	switch(iValue)
	{
		case 1:
			printf("��\n");
			break;
			
		case 2:
			printf("�L\n");
			break;
		case 3:
			printf("�T\n");
			break;
		default:
			printf("��J���~\n");
	}
	
	*/
	
	//=========================================================
	
	/*
	int iOption;
	
	printf("�줽�Ǩt�C�w�˳n�����");
	printf("\t<1>���ƪ� <2>�պ�έp");
	printf("\t<3>�ʺA²�� <4>��ƺ޲z");
	scanf("%d",&iOption);
	printf("\n�˷R���Ȥ�");
	switch(iOption)
	{
		case 1:
			printf("��ĳ�ʶR Office-Word");
			break;
		case 2:
			printf("��ĳ�ʶR Office-Excel");
			break;
		case 3:
			printf("��ĳ�ʶR Office-PowerPoint");
			break;
		case 4:
			printf("��ĳ�ʶR Office-Access");
			break;
		default:
			printf("�w��A���߰�");
	}
	*/
//===================================================================

		
	float fValue;
	printf("�]�w���R�ƭ�");
	scanf("%f",&fValue);
	printf("\n��J���ȡA");
	int iValue=fValue/1;
	
	if(fValue-iValue!=0)
	{
		printf("���O��ơC");
	}
	else
	{
		if(iValue<0)
		{
			printf("�O�t���");
		}
		else
		{
			printf("�O�����");
		}
		if(iValue%2==0)
		{
			printf("�]�O����");
		}
		else
		{
			printf("�]�O���");
		}
	}

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;	
}
