#pragma once
#include<iostream>
#include<string>
using namespace std;
class clsPerson
{
private:
	string _FirstName;
	string _LastName;
	string _Email;
	string _Phone;
public:
	clsPerson(string  FirstName, string LastName, string Email, string Phone)
	{
		_FirstName = FirstName;
		_LastName = LastName;
		_Email = Email;
		_Phone = Phone;
	}
	//property set
	void setFirstName(string FirstName)
	{
		_FirstName = FirstName;
	}
	//property Get
	string GetFirstName()
	{
		return _FirstName;
	}
	__declspec(property(get = GetFirstName, put = setFirstName))string FirstName;
	//property set
	void setLastName(string LastName)
	{
		_LastName = FirstName;
	}
	//property Get
	string GetLastName()
	{
		return _LastName;
	}
	__declspec(property(get = GetLastName, put = setLastName))string LastName;
	//property set
	void setEmail(string Email)
	{
		_Email = Email;
	}
	//property Get
	string GetEmail()
	{
		return _Email;
	}
	__declspec(property(get = GetEmail, put = setEmail))string Email;
	//property set
	void setPhone(string Phone)
	{
		_Phone = Phone;
	}
	//property Get
	string GetPhone()
	{
		return _Phone;
	}
	__declspec(property(get = GetPhone, put = setPhone))string Phone;

	string FullName()
	{
		return _FirstName + " " + _LastName;
	}


};

