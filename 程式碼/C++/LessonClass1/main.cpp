#include <iostream>
#include <conio.h>
#include <iomanip>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
int main(int argc, char** argv) {
	/*
	printf("\n�w��ǭ��Ө�C++\n");
	puts("\n\t���Ѭ�ߥD�D�O C++ �y��");
	//C++�y������ɦV
	string mySay;
	mySay = "���O���K����, nece to meet you...";
	cout<<endl<<mySay;
	getch();
	*/
	//==================================================
	/*
	//�إ�My String 1 ����
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
	
	cout<<"�u�W�ݭ�:"<<endl;
	cout<<"���ѰQ�ץD�D�O C & C++ "<<endl;
	cout<<"�p�G�U��ǳƴN��";
	system("PAUSE");
	
	
	cout<<"�u�H�^��";
	cout<<"�������Ш�ƶ��Ϊ�������ά[�c�C";
	cout<<"C -- functions<>"<<endl;
	cout<<"	C++ -- Class + Object + Members + ...";
	getch();
	*/
	
	//---------------------------------------------------------
	/*
	int iInteger1;
	int iInteger2;
	int iSum;
	
	cout<<"�п�J�Ĥ@�ӭ�:"<<endl;
	cin>>iInteger1;
	cout<<"�п�J�ĤG�ӭ� :"<<endl;
	cin>>iInteger2;
	
	iSum = iInteger1 + iInteger2;
	
	cout<<"�Ĥ@�ӼƬ�:"<<iInteger1<<"�ĤG�Ӭ�:"<<iInteger2<<endl; 
	cout<<"�`�X��"<<iSum<<endl; 
	*/
	//===============================================================
	
	/*
	int iEndValue;
	int iSummary=0;
	
	do
	{
		cout<<"\n�]�w�׭�"<<endl;
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
	
	cout<<"\n\t1 ��"<<iEndValue<<"���򰸮t :";
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
