#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int iStudentCount[6]={0},i;
	
	printf("�ۥ�");
	
	for( i=0;i<5;i++)
	{
		printf("  ");
		switch(i)
		{
			case 0:printf("�x�j"); break;
			case 1:printf("�]�e"); break;
			case 2:printf("����"); break;
			case 3:printf("����"); break;
			case 4:printf("�h�L"); break;
		}
		printf("����:");
		scanf("%d",&iStudentCount[i]);
		iStudentCount[5]+=iStudentCount[i];
	}
	printf("�s���`�H�� :%d �H",iStudentCount[i]);
	
	
	
	
	return 0;
}
