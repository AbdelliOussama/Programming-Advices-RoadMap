#include<vector>
#include<iostream>
using namespace std;
void read_number(vector <int>& vNumbers)
{
	char addnumber = 'Y';
	int number;

	while (addnumber == 'y' || addnumber == 'Y')
	{
		cout << "please enter a number\n";
		cin >> number;
		vNumbers.push_back(number);
		cout << "do you want to add numbers Y\\N\n";
		cin >> addnumber;
	} 
} 

void printvector(vector <int>& vNumbers)
{
	for (int number : vNumbers)
	{
		cout << number << " ";
	}
	cout << endl;
}
int main()
{
	vector <int> vNumbers;
	read_number(vNumbers);
	printvector(vNumbers);

	
	return 0;
}