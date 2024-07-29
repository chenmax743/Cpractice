#include <stdio.h>
#include <stdlib.h>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */

int main(int argc, char *argv[]) {
	
	int iStudentCount[6]={0},i;
	
	printf("招生");
	
	for( i=0;i<5;i++)
	{
		printf("  ");
		switch(i)
		{
			case 0:printf("台大"); break;
			case 1:printf("館前"); break;
			case 2:printf("忠孝"); break;
			case 3:printf("內湖"); break;
			case 4:printf("士林"); break;
		}
		printf("分校:");
		scanf("%d",&iStudentCount[i]);
		iStudentCount[5]+=iStudentCount[i];
	}
	printf("新生總人數 :%d 人",iStudentCount[i]);
	
	
	
	
	return 0;
}
