#include<iostream>
#include<fstream>
#include<string>
#include<vector>
using namespace std; 
void LoadDataFromFileToVector(string FileName, vector <string>& vFileContent)
{
	fstream MyFile; 
	MyFile.open("my_first_file.txt", ios::in);
	//read Mode
	if (MyFile.is_open())   
	{ 
		string Line;
		while (getline(MyFile, Line))    
		{ 
			vFileContent.push_back(Line); 
		}       
		MyFile.close(); 
	}
}
void SaveVectorToFile(string FileName, vector <string> vFileContent) 
{ 
	fstream MyFile; 
	MyFile.open("my_first_file.txt", ios::out);
	if (MyFile.is_open()) 
	{ 
		for (string Line : vFileContent)  
		{
			if (Line != "")       
		    {              
				MyFile << Line << endl; 
			}      
		}       
		MyFile.close();  
	} 
} 

void UpdateRecordInFile(string FileName, string Record, string UpdateTo) 
{
	vector <string> vFileContent;  
	LoadDataFromFileToVector(FileName, vFileContent);
	for (string& Line : vFileContent) 
	{ 
		if (Line == Record) 
		{
			Line = UpdateTo;
		} 
	}   
	SaveVectorToFile(FileName, vFileContent);
}
void PrintFileContent(string FileName)
{
	fstream MyFile;  
	MyFile.open(FileName, ios::in);
	//read Mode 
	if (MyFile.is_open())
	{
		string Line;
		while (getline(MyFile, Line)) 
		{        
			cout << Line << endl;  
		}    
		MyFile.close();
	}
} 
int main() 
{ 
	cout << "File Content Before Delete.\n"; 
	PrintFileContent("my_first_file.txt");   
	UpdateRecordInFile("my_first_file.txt", "salim", "slayem"); 
	cout << "\n\nFile Content After Delete.\n";   
	PrintFileContent("my_first_file.txt"); 
	return 0;
}

