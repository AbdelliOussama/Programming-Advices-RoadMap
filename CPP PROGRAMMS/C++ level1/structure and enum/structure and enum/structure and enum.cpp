#include <iostream>
#include <string>
using namespace std;
enum engender { male, female };
enum enmarried_state { single, married };
struct stadress {
    string street;
    string city;
    string country;
    short int postal_code;
};
struct stcontact_information {
     int ID;
     int phone_number;
    string email;
    string facbook_contact;
};
struct stpersonal_information {
    string name;
    string last_name;
    stadress my_adress;
    stcontact_information  my_information;
    engender my_gender;
    enmarried_state my_status;
};
stpersonal_information person;

int main()
{
    cout << "enter your first name\n";
    cin >> person.name;
    cout << "\nenter your last name\n";
    cin >> person.last_name;
    cout << "\nenter your street name \n";
    cin >> person.my_adress.street;
    cout << "\nenter your city name\n";
    cin >> person.my_adress.city;
    cout << "\nenter your country name\n";
    cin >> person.my_adress.country;
    cout << "\nenter your  postal_code\n";
    cin >> person.my_adress.postal_code;
    cout << "\nenter your  facbook\n";
    cin >> person.my_information.facbook_contact;
    cout << "\nenter your  email\n";
    cin >> person.my_information.email;
    cout << "\nenter your  ID\n";
    cin >> person.my_information.ID;
    cout << "\nenter your phone number\n";
    cin >> person.my_information.phone_number;
    person.my_gender = engender::male;
    person.my_status = enmarried_state::single;
    cout << "\n**************************\n";
    cout << "\nwelcome \n\a";
    cout << person.name << endl;
    cout << person.last_name << endl;
    cout << person.my_adress.street << endl;
    cout << person.my_adress.city << endl;
    cout << person.my_adress.country << endl;
    cout << person.my_adress.postal_code << endl;
    cout << person.my_information.facbook_contact << endl;
    cout << person.my_information.email << endl;
    cout << person.my_information.phone_number << endl;
    cout << person.my_gender << endl;
    cout << person.my_status << endl;
    cout<<person.my_information.ID<<endl;
    cout << "\n**************************\n\a";

}

