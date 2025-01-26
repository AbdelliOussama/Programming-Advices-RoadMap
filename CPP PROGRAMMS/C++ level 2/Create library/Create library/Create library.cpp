#include <iostream>
#include<string>
using namespace std;
#include "Myfirstlib.h"
#include "My math function.h"
//we can use using name space to avoid namespace::
//using namespace my_first_lib;

int main()
{
	float Number= my_first_lib::read_number("please enter a number");
	cout << "my ceil result is: " << Mymathlib:: myceilnumber(Number) << endl;

} 
