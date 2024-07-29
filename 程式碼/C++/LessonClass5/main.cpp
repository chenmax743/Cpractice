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
	
	cout<<"偶"<<stringName<<"說";
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
	
	cout<<"學生1血型"<<myStudentNo1<<endl;
	cout<<"學生3血型"<<myStudentNo3<<endl; 
	cout<<"學生2血型"<<myStudentNo2<<endl; 
	cout<<"學生4血型"<<myStudentNo4<<endl;*/
	//-----------------------------------------------
	
	/*enum eMark
	{MarkA=35,MarkB,MarkC,MarkD};
	
	eMark eOutputMark=MarkA;
	cout<<"符號--";
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
	sMyFriend1.stringFullName="張中崙";
	sMyFriend1.stringGender="男";
	sMyFriend1.intYearOfBirth=1985;
	sMyFriend2.stringFullName="彭曉鈴";
	sMyFriend2.stringGender="女";
	sMyFriend2.intYearOfBirth=2001;
	
	cout<<"\n-------通訊錄--------\n";
	cout<<sMyFriend1.stringGender<<"同學:"<<sMyFriend1.stringFullName<<"|現齡:"<<2024-sMyFriend1.intYearOfBirth<<"\n\n";
	cout<<sMyFriend2.stringGender<<"同學:"<<sMyFriend2.stringFullName<<"|現齡:"<<2024-sMyFriend2.intYearOfBirth;*/
	//------------------------------------------------------
	
	union unionContacs{
		int iBornAge;
		char *stringFullName;
	};
	
	unionContacs uMyFamily1,uMyFamily2;
	
	uMyFamily1.stringFullName="和家扶";
	uMyFamily2.stringFullName="何登羅志";
	
	cout<<"。"<<uMyFamily1.stringFullName<<"\t";
	cout<<"。"<<uMyFamily2.stringFullName<<"\n\n\t";
	
	uMyFamily1.iBornAge=1937;
	uMyFamily2.iBornAge=1947;
	
	cout<<2024-uMyFamily1.iBornAge<<"歲"<<"\t";
	cout<<2024-uMyFamily2.iBornAge<<"歲";
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	return 0;
}
