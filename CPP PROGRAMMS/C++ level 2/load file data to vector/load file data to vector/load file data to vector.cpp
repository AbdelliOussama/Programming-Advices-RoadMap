#include<iostream>
#include<fstream>
#include<string>
#include<vector>
using namespace std;
void LoadDataFromFileToVector(string FileName, vector <string>& vFileContent) 
{ 
	fstream my_file;  
	my_file.open(FileName, ios::in);
	//read Mode
	if (my_file.is_open())
	{ 
		string Line;
		while (getline(my_file, Line))
		{
			vFileContent.push_back(Line);     
		}       
		my_file.close();
	}
}
int main()
{ 
	vector <string> vFileContenet;
	LoadDataFromFileToVector("my_first_file.txt", vFileContenet); 
	for (string &Line : vFileContenet)  
	{        
		cout << Line << endl; 
	} return 0;
} 