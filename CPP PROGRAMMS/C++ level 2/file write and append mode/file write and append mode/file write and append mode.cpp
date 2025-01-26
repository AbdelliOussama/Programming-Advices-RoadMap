#include<iostream>
#include<fstream>
using namespace std;
int main()
{
	fstream my_file;
	my_file.open("my_first_file.text", ios::out );//ios::open used for writing on file
	if (my_file.is_open())
	{
		my_file << "my name is oussama \n";
		my_file << "im an intelligent person\n";
		my_file.close();
	}

}