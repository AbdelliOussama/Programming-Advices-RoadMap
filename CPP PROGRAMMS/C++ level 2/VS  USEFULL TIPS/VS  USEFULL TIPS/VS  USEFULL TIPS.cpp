#include<iostream>
using namespace std;
//RESTRINDRE FUNCTION
//GO TO DEFENITION
//GO TO DECLARATION
//VIEW ALL REFERENCES 
// PEEK DEFENION TO TAKE A LOOK
//VIEW HIERRACHY
//RENAME FUNCTION IN ALL PROGRAM

void Function2();
void Function4()
{    
	cout << "Hi I'm function4 " << endl;
}
void Function3()
{   
	Function4();
}
void Function2()
{    
	Function3();
}
void Function1()
{  
	Function2();  
	Function4(); 
}
int main() 
{    
	Function1();
	return 0; 
} 