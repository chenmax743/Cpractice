#include <iostream>
#include <conio.h>
#include <iomanip>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
int main(int argc, char** argv) {
	/*
	printf("\n歡迎學員來到C++\n");
	puts("\n\t今天研習主題是 C++ 語言");
	//C++語言物件導向
	string mySay;
	mySay = "偶是巨匠材哥, nece to meet you...";
	cout<<endl<<mySay;
	getch();
	*/
	//==================================================
	/*
	//建立My String 1 物件
	string MyString1;
	string MyString2 = "My mom";
	
	MyString1 = "Hello World";
	cout<<"My String1 :"<<MyString1<<endl;
	cout<<"MyString2 :"<<MyString2<<endl;
	
	string MyString3(" i Love wlorld");
	cout<<"Mystring3";
	system("PAUSE");
	*/
	
	//=======================================================
	/*
	string sWelcome;
	string sProgram;
	
	cout<<"線上問候:"<<endl;
	cout<<"今天討論主題是 C & C++ "<<endl;
	cout<<"如果各位準備就緒";
	system("PAUSE");
	
	
	cout<<"真人回應";
	cout<<"首先介紹函數集及物件化應用架構。";
	cout<<"C -- functions<>"<<endl;
	cout<<"	C++ -- Class + Object + Members + ...";
	getch();
	*/
	
	//---------------------------------------------------------
	/*
	int iInteger1;
	int iInteger2;
	int iSum;
	
	cout<<"請輸入第一個值:"<<endl;
	cin>>iInteger1;
	cout<<"請輸入第二個值 :"<<endl;
	cin>>iInteger2;
	
	iSum = iInteger1 + iInteger2;
	
	cout<<"第一個數為:"<<iInteger1<<"第二個為:"<<iInteger2<<endl; 
	cout<<"總合為"<<iSum<<endl; 
	*/
	//===============================================================
	
	/*
	int iEndValue;
	int iSummary=0;
	
	do
	{
		cout<<"\n設定終值"<<endl;
		cin>>iEndValue; 
		if(iEndValue>=2 && iEndValue<=100)
		{
			for(int i=1;i<=iEndValue;i++)
			{
				if(i%2==0)
				{
					iSummary-=i;	
				}
				else
				{
					iSummary+=i;
				}
				
			}break;
				
		}
		else
		{
			cout<<"Range : 2 To 100";
		}
	}
	while(true);
	
	cout<<"\n\t1 至"<<iEndValue<<"的基偶差 :";
	cout<<(iSummary>0?"+":"")<<iSummary<<endl; 
	*/
	
	//====================================================
	
	cout<<setw(2)<<"X"<<setw(2)<<"|";
	for(int i=1;i<=9;i++)
	{
		cout<<setw(2)<<i;
	}
	cout<<endl;
	cout<<"---+";
	for(int i=1;i<=9;i++)
	{
		cout<<"---";
	}
	cout<<"-"<<endl;
	
	for(int i=1;i<=9;i++)
	{
		cout<<setw(2)<<i<<setw(2)<<"|";
		for(int j=1;j<=9;j++)
		{
			cout<<setw(3)<<i*j;
		}
		cout<<endl;
	}
	
	
	
	
	
	
	
	
	
	
	 


























	return 0;
}
