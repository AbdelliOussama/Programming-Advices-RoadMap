#include <iostream>
#include<string>
using namespace std;
string readpassword(string message)
{
    string password;
    cout << message << "\n";
    cin >> password;
    return password;
}
bool checkpassword(string password)
{
    string word = " ";
    int counter=0;
    for (int i = 65; i <= 90; i++)
    {

        for (int j = 65; j <= i; j++)
        {
            for (int k = 65; k <= 90; k++)
            {
                counter++;
                word = char(i);
                word += char(j);
                word += char(k);
                cout <<"Trial["<<counter<<"]:"<< word << endl;
                if (word == password)
                {
                    cout << "password is  " << password << endl;
                    cout << "found after  " << counter << "  trial(s)" << endl;;
                    return true;
                }
                word = " ";

                
               

            }
        }
        cout << "\n_________________________________________________\n" << endl;
       
    }
    return false;
}


int main()
{
    string password = readpassword("please enter a password");
    checkpassword(password);
}

