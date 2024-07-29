#include <iostream>
#include <cstdlib>
#include <iomanip>
#include <conio.h>
#include <ctime>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */

using namespace std;

int iAns(int iSV, int iEV)
{
	if(iSV!=iEV)
	{
		return iSV++*iAns(iSV,iEV);
	}
	else
	{
		return iEV;
	}
}

int main(int argc, char** argv) {

	int iSV=1;	//°_©lª½
	int iEV=12;
	
	cout<<"12!="<<iAns(iSV,iEV)<<endl; 
	
	return 0;
}




