#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
/*class cRetangle
{
	public :
	float fWidth,fHeight;
	
	public :
		void vRetangleData()
		{
			cout<<"�]�w�e�� :"<<"\n";
			cin>>fWidth;
			cout<<"�]�w���� :"<<"\n";
			cin>>fHeight; 
		}
};
*/
//------------------------------------------
class cZoo
{
	public:
		string sLion,sElephant;
		float fLionAge,fElephantAge;
	
	public:
		void vAnimalSound()
		{
			cout<<"��l�s�n"<<sLion;
			cout<<"�j�H�s�n"<<sElephant; 
		}
};
int main(int argc, char** argv) {
	/*cRetangle mouse;
	mouse.vRetangleData();
	cout<<"����e��"<<mouse.fWidth<<"\n";
	cout<<"�������"<<mouse.fHeight<<"\n";
	cout<<"�p��x�έ��n :"<<mouse.fWidth*mouse.fHeight;*/
	//----------------------------------------------------------
	cZoo test;
	test.sLion="Roar";
	test.sElephant="Trumb";
	test.fLionAge=15;
	test.fElephantAge=4;
	test.vAnimalSound();
	
	
	
	return 0;
}
