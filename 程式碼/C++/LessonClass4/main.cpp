#include <iostream>
#include <iomanip>  
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

/*float fPI = 3.1415926;

float fCA(float fR) //2D�ꭱ�n 
{
	return fR*fR*fPI;
}

float fCF(float fA) //2D��P�� 
{
	return fA*2*fPI;
}*/

int iLong(int iL)
{
	return iL*iL*iL;
}

int iLong(int iL,int iLs,int iT)
{
	return iL*iLs*iT;
}
int main(int argc, char** argv) {
	/*float fRadius;
	do
	{
		print<<"�]�w�b�|\n";
		cout<<"Set Range 1-30\n";
		cin>>fRadius;
		
		if(fRadius>=1 && fRadius<=30)
		{
			cout<<"\n�ꭱ�n = "<<setw(7)<<setprecision(2)<<fixed<<fCA(fRadius);
			cout<<"\n��P�� = "<<setw(7)<<setprecision(2)<<fixed<<fCF(fRadius);
			break; 
		}
		
	}
	while(true);*/
	/*
	int iYear;
	cout<<"���K�ժ��d";
	cout<<"���O�褸�~��";
	cin>>iYear;
	if(iYear>=2008)
	{
		char cChk;
		cout<<"\n�ר��ժ��d���ʤw����!\n";
		cout<<"\n�O�_��R�u�W�@�~��\n?";
		cin>>cChk;
		
		if(cChk=='Y' || cChk=='y')
		{
			#define Money2 17600
			cout<<"\n�u�W���O--"<<Money2<<"����\n";
				}		
	} 
	else
	{
		#ifndef Money1
			#define Money1(iYr) (iYr<2002?19800:27800)
		#endif
		cout<<"\n�u�W���O--"<<Money1(iYear)<<"����\n";
	}
	cout<<"\n���¥��{�A�w��A�����z�A�ȡC\n\n";
	*/
	int iLength;
	cout<<"��J��";
	int iWith = 3, iheight = 9;
	cout<<"����έ��n"<<iLong(iLength); 
	cout<<"����έ��n"<<iLong(iLenght,iWith,iheight);
	
	
	return 0;
}
