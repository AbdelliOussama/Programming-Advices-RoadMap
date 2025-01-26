#include <iostream>
#include<string>
using namespace std;
string readtext(string message)
{
    string text;
    cout << message << "\n";
    getline(cin, text);
    return text;
}
string encryptetext(string text, short encryption_key)
{
    for (int i = 0; i <= text.length(); i++)
    {
        text[i] = char((int)text[i] + encryption_key);
    }
    return text;
}
string decryptetext(string text, short encryption_key)
{
    for (int i = 0; i <= text.length(); i++)
    {
        text[i] = char((int)text[i] - encryption_key);
    }
    return text;
}




int main()
{
    const short encryption_key=2;
    string text = readtext("please enter a text\n");
    string encryptedtext = encryptetext(text, encryption_key);
    string decryptedtext = decryptetext(encryptedtext, encryption_key);
   
    cout << "\n text before encryption " << text<< endl;
    cout << "\n text after encrypting " << encryptedtext<< endl;
    cout << "\n text after decrypting " << decryptedtext << endl;

}

