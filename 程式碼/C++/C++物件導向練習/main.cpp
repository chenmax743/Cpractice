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
			cout<<"設定寬度 :"<<"\n";
			cin>>fWidth;
			cout<<"設定高度 :"<<"\n";
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
			cout<<"獅子叫聲"<<sLion;
			cout<<"大象叫聲"<<sElephant; 
		}
};
int main(int argc, char** argv) {
	/*cRetangle mouse;
	mouse.vRetangleData();
	cout<<"獲取寬度"<<mouse.fWidth<<"\n";
	cout<<"獲取高度"<<mouse.fHeight<<"\n";
	cout<<"計算矩形面積 :"<<mouse.fWidth*mouse.fHeight;*/
	//----------------------------------------------------------
	cZoo test;
	test.sLion="Roar";
	test.sElephant="Trumb";
	test.fLionAge=15;
	test.fElephantAge=4;
	test.vAnimalSound();
	
	
	
	return 0;
}
