#include<iostream>
#include<string>
#include<iomanip>
using namespace std;
class clsEmployee
{
private:
	int _ID;
	string _FirstName;
	string _LastName;
	string _FullName;
	string _Title;
	string _Email;
	string _Phone;
	string _Salary;
	string _Department;
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

	void setTitle(string Title)
	{
		_Title = Title;
	}
	string Title()
	{
		return _Title;
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

	clsEmployee(int ID, string FirstName, string LastName, string Title,string Email, string Phone,string Salary ,string Department)
	{
		_ID = ID;
		_FirstName = FirstName;
		_LastName = LastName;
		_Title = Title;
		_Email = Email;
		_Phone = Phone;
		_Salary = Salary;
		_Department = Department;
	}
	void print()
	{
		cout << "______________________\n";
		cout << setw(10) << "ID        : " << ID() << endl;
		cout << setw(10) << "FirstName : " << FirstName() << endl;
		cout << setw(10) << "LastName  : " << LastName() << endl;
		cout << setw(10) << "FullName  : " << FullName() << endl;
		cout << setw(10) << "Title     : " << Title() << endl;
		cout << setw(10) << "Email     : " << Email() << endl;
		cout << setw(10) << "Salary    : " << Salary() << endl;
		cout << setw(10) << "Department: " << Department() << endl;
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
int main()
{
	clsEmployee Employee1(10, "Mohamed", "Abu_Hadhoud","Software Ingeneer", "My@Gmail.com", "0098387727","450000","Polyclinique H.lif");
	Employee1.print();
	Employee1.sendEmail("Hi", "How Are You");
	Employee1.sendSMS("How Are You ?");
	system("pause>0");
	return 0;
}