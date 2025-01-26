#include <iostream>
#include<string>
#include<cstdlib>
using namespace std;
int keysnumbers(string message)
{
    int numbers;
    cout << message;
    cin >> numbers;
    return numbers;
}
int RandomNumber(int From, int To)
{ //Function to generate a random number
    int randNum = rand() % (To - From + 1) + From; return randNum;
}
enum enCharType { SamallLetter = 1, CapitalLetter = 2, SpecialCharacter = 3, Digit = 4 };
char GetRandomCharacter(enCharType CharType)
{
    switch (CharType)
    {
    case enCharType::SamallLetter:
    { return char(RandomNumber(97, 122)); break;     }
    case enCharType::CapitalLetter:
    { return char(RandomNumber(65, 90)); break;     }
    case enCharType::SpecialCharacter:
    { return char(RandomNumber(33, 47)); break;     }
    case enCharType::Digit:
    { return char(RandomNumber(48, 57)); break;     }
    }
}
string generatewords(enCharType CharType,short length)
{
    string words=" ";
   for(int i=1;i<=length;i++)
    {
        words = words + (char)GetRandomCharacter(CharType);
    }
   return words;
}
string generatekeys()
{
    string keys = generatewords(enCharType::CapitalLetter, 4) + "-" + generatewords(enCharType::CapitalLetter, 4) + "-" + generatewords(enCharType::CapitalLetter, 4) + "-" + generatewords(enCharType::CapitalLetter, 4) ;
    return keys;
}
void printkeys(int numbers)
{
    cout << "Input: " << endl;
    cout<<numbers;
    cout << "\nOutput: " << endl;
    for (int i = 1; i <= numbers; i++)
    {
        cout << "key[" << i << "]" << generatekeys() << endl;
    }

}

int main()
{
    srand((unsigned)time(NULL));
    printkeys(keysnumbers("please enter the number of keys\n"));
}

