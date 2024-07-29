#include <iostream>
#include <iomanip>  
#include <cstdlib>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;

/*float fPI = 3.1415926;

float fCA(float fR) //2D圓面積 
{
	return fR*fR*fPI;
}

float fCF(float fA) //2D圓周長 
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
		print<<"設定半徑\n";
		cout<<"Set Range 1-30\n";
		cin>>fRadius;
		
		if(fRadius>=1 && fRadius<=30)
		{
			cout<<"\n圓面積 = "<<setw(7)<<setprecision(2)<<fixed<<fCA(fRadius);
			cout<<"\n圓周長 = "<<setw(7)<<setprecision(2)<<fixed<<fCF(fRadius);
			break; 
		}
		
	}
	while(true);*/
	/*
	int iYear;
	cout<<"巨匠白金卡";
	cout<<"消費西元年分";
	cin>>iYear;
	if(iYear>=2008)
	{
		char cChk;
		cout<<"\n終身白金卡活動已結束!\n";
		cout<<"\n是否改買線上一年期\n?";
		cin>>cChk;
		
		if(cChk=='Y' || cChk=='y')
		{
			#define Money2 17600
			cout<<"\n線上收費--"<<Money2<<"元整\n";
				}		
	} 
	else
	{
		#ifndef Money1
			#define Money1(iYr) (iYr<2002?19800:27800)
		#endif
		cout<<"\n線上收費--"<<Money1(iYear)<<"元整\n";
	}
	cout<<"\n謝謝光臨，歡迎再次為您服務。\n\n";
	*/
	int iLength;
	cout<<"輸入長";
	int iWith = 3, iheight = 9;
	cout<<"正方形面積"<<iLong(iLength); 
	cout<<"長方形面積"<<iLong(iLenght,iWith,iheight);
	
	
	return 0;
}
