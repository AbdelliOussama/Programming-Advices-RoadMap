#include<iostream>
#include<string>
#include<iomanip>
using namespace std;
class clsPerson 
{
private:
	int _ID;
	string _FirstName;
	string _LastName;
	string _FullName;
	string _Email;
	string _Phone;
public:
	int ID()
	{
		return _ID;
	}
	void setFirstName(string FirstName)
	{
		_FirstName = FirstName;
	}
	string FirstName()
	{
		return _FirstName;
	}
	void setLastName(string LastName)
	{
		_LastName = LastName;
	}
	string LastName()
	{
		return _LastName;
	}

	string FullName()
	{
		return _FullName = _FirstName + " " + _LastName;
	}
	void setEmail(string Email)
	{
		_Email = Email;
	}
	string Email()
	{
		return _Email;
	}
	void setPhone(string Phone)
	{
		_Phone = Phone;
	}
	string Phone()
	{
		return _Phone;
	}
	clsPerson()
	{

	}
	clsPerson(int ID, string FirstName, string LastName, string Email, string Phone)
	{
		_ID = ID;
		_FirstName = FirstName;
		_LastName = LastName;
		_Email = Email;
		_Phone = Phone;
	}
	void print()
	{
		cout << "______________________\n";
		cout << setw(10) << "ID        : " << ID() << endl;
		cout << setw(10) << "FirstName : " << FirstName() << endl;
		cout << setw(10) << "LastName  : " << LastName() << endl;
		cout << setw(10) << "FullName  : " << FullName() << endl;
		cout << setw(10) << "Email     : " << Email() << endl;
		cout << setw(10) << "Phone     : " << Phone() << endl;
		cout << "______________________\n";
	}
	void sendEmail(string Subject, string Body)
	{
		cout << "The following message sent successfully to email:" << Email() << endl;
		cout << "Subject : " << Subject << endl;
		cout << "Body : " << Body << endl;
	}
	void sendSMS(string SMS)
	{
		cout << "The following SMS sent successfully to Phone:" << Phone() << endl;
		cout << SMS << endl;

	}
	
};
class clsEmployee :public clsPerson
{
private:
	
	string _Title;
	string _Salary;
	string _Department;

public:
	void setTitle(string Title)
	{
		_Title = Title;
	}
	string Title()
	{
		return _Title;
	}
	
	void setSalary(string Salary)
	{
		_Salary = Salary;
	}
	string Salary()
	{
		return _Salary;
	}
	void setDepartment(string Department)
	{
		_Department = Department;
	}
	string Department()
	{
		return _Department;
	}

	
	
};
int main()
{
	clsEmployee Employee1;
	Employee1.setFirstName("oussama");
	Employee1.setLastName("Abdelli");
	Employee1.setEmail("My email.Yahoo.com");
	Employee1.setPhone("96301996");
	Employee1.print();
	Employee1.sendEmail("Hi", "How Are You");
	Employee1.sendSMS("How Are You ?");
	system("pause>0");
	return 0;
}