#include <iostream>
#include<conio.h>
#include<iomanip>
#include<cstdlib>
#include<ctime>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
int main(int argc, char** argv) {
	
	/*
	int iValue=8591;
	int *iPt1;
	iPt1=&iValue;
	
	cout<<"iValue內容"<<iValue<<endl;
	cout<<"iValue記憶體"<<&iValue<<endl;
	cout<<"iPt1 :"<<iPt1<<"\n\n";
	
	*iPt1=5201314;
	cout<<"Value內容"<<iValue<<endl;
	
	*/
	
	//==========================================
	
	/*
	srand(time(NULL));
	int iNumber[3];
	int *iHundred =& iNumber[0];
	int *iTen =& iNumber[1];
	int *iOne =& iNumber[2];
	
	
	
	*iHundred = rand()%10;
	*iTen = rand()%10; 
	*iOne = rand()%10;
	
	cout<<"---+---線上[開始作業]開始---+---\n";
	cout<<"\t百位數 :"<<setw(5)<<*iHundred<<"\n\n";
	cout<<"\t十位數 :"<<setw(5)<<*iTen<<"\n\n";
	cout<<"\t個位數 :"<<setw(5)<<*iOne<<"\n\n";
	cout<<"--+--線上開獎作業--+--\n\n";
	cout<<"\t中獎號碼";
	cout<<setw(2)<<*iHundred<<setw(2)<<*iTen;
	cout<<setw(2)<<*iOne;
	*/
	
	//=============================================
	
	/*
	int iArray[]={100,92,85,82,80,75};
	int *iPt=iArray;
	
	cout<<"\n\t+----------巨匠3C\n\t";
	for(int i=0;i<6;i++)
	{
		cout<<"\t"<<setw(3)<<"*"<<"貴賓等級"<<setw(2)<<i;
		cout<<setw(3)<<"-"<<setw(4)<<*(iPt+i);	//位移 
		cout<<"% 本金 + 享折扣"<< setw(3)<<100-*(iPt+i)<<"%\n\n"; 
	 } 
	*/
	
	//===============================================
	
	/*
	int iArray[][3]={{85,91,99},{52,99,93}};
	int *iPt=iArray[0];
	
	cout<<"iPt = "<<iPt<<",iPt="<<*iPt<<endl;
	*/
	
	//=================================================
	
	int iCount, iSummary=0;
	cout<<"消費盤子數 :";
	cin>>iCount;
	
	int *iPt = new int [iCount];
	for(int i=0;i<iCount;i++)
	{
		cout<<"盤子"<<setw(2)<<setfill('0');
		cout<<i+1<<"-金額";
		cin>>*(iPt+i);
		iSummary +=*(iPt+i); 
	 }
	cout<<"共計 :"<<iSummary << "元"; 
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	 
	return 0;
}
