#include <iostream>
#include<conio.h>
#include<iomanip>
#include<cstdlib>
#define stringOutput "Happy New Year"
#include<cstring>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
//typedef unsigned char byte;
using namespace std;
int main(int argc, char** argv) {
	/*string stringName = "TAIGO";
	byte byteTaiwanYear = 113;
	
	cout<<"��"<<stringName<<"��";
	cout<<stringOutput<<byteTaiwanYear+1911;*/ 
	//-----------------------------------------------
	
	/*enum enumBloodType{

	BloodTypeA=1,
	BloodTypeB=2,
	BloodTypeO=3,
	BloodTypeAB=4
	};
	
	enumBloodType myStudentNo1 = BloodTypeA,
					myStudentNo2 = BloodTypeO,
					myStudentNo3 = BloodTypeO,
					myStudentNo4 = BloodTypeB;
	
	cout<<"�ǥ�1�嫬"<<myStudentNo1<<endl;
	cout<<"�ǥ�3�嫬"<<myStudentNo3<<endl; 
	cout<<"�ǥ�2�嫬"<<myStudentNo2<<endl; 
	cout<<"�ǥ�4�嫬"<<myStudentNo4<<endl;*/
	//-----------------------------------------------
	
	/*enum eMark
	{MarkA=35,MarkB,MarkC,MarkD};
	
	eMark eOutputMark=MarkA;
	cout<<"�Ÿ�--";
	for(int i=0;i<4;i++)
	{
		cout<<setw(2)<<char(eOutputMark+i);
	}
	cout<<"\n\n";*/
	//-----------------------------------------------
	/*struct structContacts{
		string stringFullName;
		string stringGender;
		int intYearOfBirth;
	};
	
	structContacts sMyFriend1,sMyFriend2;
	sMyFriend1.stringFullName="�i���[";
	sMyFriend1.stringGender="�k";
	sMyFriend1.intYearOfBirth=1985;
	sMyFriend2.stringFullName="�^��a";
	sMyFriend2.stringGender="�k";
	sMyFriend2.intYearOfBirth=2001;
	
	cout<<"\n-------�q�T��--------\n";
	cout<<sMyFriend1.stringGender<<"�P��:"<<sMyFriend1.stringFullName<<"|�{��:"<<2024-sMyFriend1.intYearOfBirth<<"\n\n";
	cout<<sMyFriend2.stringGender<<"�P��:"<<sMyFriend2.stringFullName<<"|�{��:"<<2024-sMyFriend2.intYearOfBirth;*/
	//------------------------------------------------------
	
	union unionContacs{
		int iBornAge;
		char *stringFullName;
	};
	
	unionContacs uMyFamily1,uMyFamily2;
	
	uMyFamily1.stringFullName="�M�a��";
	uMyFamily2.stringFullName="��nù��";
	
	cout<<"�C"<<uMyFamily1.stringFullName<<"\t";
	cout<<"�C"<<uMyFamily2.stringFullName<<"\n\n\t";
	
	uMyFamily1.iBornAge=1937;
	uMyFamily2.iBornAge=1947;
	
	cout<<2024-uMyFamily1.iBornAge<<"��"<<"\t";
	cout<<2024-uMyFamily2.iBornAge<<"��";
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
