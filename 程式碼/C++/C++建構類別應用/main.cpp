#include <iostream>

/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
int main(int argc, char** argv) {
	char*cText = "Happy New Year";
	int i=0;
	while(*(cText+i)!='\0')
	{
		cout.put(*(cText+i++));
	}
	
	char *cText1 = "Happy New Year";
	int i=0;
	while(*(cText1+i)!='\0')
	{
		putchar(*(cText1+i++));
	}
	return 0;
}
