#include<vector>
#include<iostream>
using namespace std;
struct stEmployee
{
	string FirstName;
	string LastName;
	float Salary;
};
void read_employee(vector<stEmployee>& vEmployees)
{
	stEmployee tempEmployee;
	char add_more = 'Y';
	while (add_more == 'Y' || add_more == 'y')
	{
		cout << "enter the first name of the employee ? \n";
		cin >> tempEmployee.FirstName;
		cout << "enter the last name of the employee ? \n";
		cin >> tempEmployee.LastName;
		cout << "enter the salary of the employee ? \n";
		cin >> tempEmployee.Salary;
		cout << "do you want to add more employee Y/N \n";
		cin >> add_more;
		vEmployees.push_back(tempEmployee);

	}
}
void printemployees(vector<stEmployee>& vEmployees)
{
	for (stEmployee& Employee : vEmployees)
	{
		cout << "____________________________________________\n";
		cout << "FirstName: " << Employee.FirstName << endl;
		cout << "LastName : " << Employee.LastName << endl;
		cout << "Salary   : " << Employee.Salary << endl;
		cout << "____________________________________________\n";
		cout << endl;
	}
	cout << endl;
}
int main()
{
	// std::vector<T> vector_name;
	vector <stEmployee> vEmployees;
	read_employee(vEmployees);
	printemployees(vEmployees);
	return 0;
}