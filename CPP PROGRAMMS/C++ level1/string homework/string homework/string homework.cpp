
#include <iostream>
#include<string>
using namespace std;
string string1, string2, string3,x;
int main()
{
   
   cout << "please inter  string 1:\n";
  // cin >> string1;
   cin.ignore(1, '\n');//to ignore the clicked enter key
   getline(cin, string1);//getline is used instead of cin when reading string that contain space
   cout << "please inter  string 2:\n";
   cin >> string3;
   cout << "please inter  string 3:\n";
   cin >> string3;
   cout << "\n******************************\n";
   cout << "the length of string1 is " << string1.length() << endl ;
   cout << "the caractere number 1 ,5,7 are  " << string1[1] << string1[5] << string1[7] << endl;
   cout <<"concatenating string 2 & 3 \t" << string2 + string3;
 

}
