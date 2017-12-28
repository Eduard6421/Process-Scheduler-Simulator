#include<fstream>
#include<iostream>
#include "Process.h"
using namespace std;

ifstream in("data.txt");

int main()
{
	Process p;

	in >> p;

	cout << p;

		
	char a = getchar();


	return 0;
}