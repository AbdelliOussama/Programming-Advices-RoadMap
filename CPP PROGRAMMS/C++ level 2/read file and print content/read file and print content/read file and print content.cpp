#include<iostream>
#include<fstream>
#include<string>
using namespace std; 
void PrintFileContenet(string FileName)
{ 
	fstream my_file;  
	my_file.open( FileName, ios::in );
	//read Mode 
	if (my_file.is_open())
	{
		string Line;
		while (getline(my_file, Line))
		{         
			cout << Line << endl; 
		}       
		my_file.close();
	}
} 
int main()
{   
	PrintFileContenet("my_first_file.txt");
	return 0; 
} 