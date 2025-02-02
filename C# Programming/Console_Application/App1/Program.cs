using System;
using System.Linq;
namespace App1
{
    internal class Program
    {


        //EnummType
        /*  enum enWeekDays
          {
              Monday,     // 0
              Tuesday,    // 1
              Wednesday,  // 2
              Thursday,   // 3
              Friday,     // 4
              Saturday,   // 5
              Sunday      // 6
          }

          //if you set a value , it will auto number everything after it.
          enum enCategories
          {
              Electronics,    // 0
              Food,           // 1
              Automotive = 6, // 6
              Arts,           // 7
              BeautyCare,     // 8
              Fashion         // 9
          }



          //Enum can have any numarical data type byte, sbyte, short, ushort, int, uint, long, or ulong
          //but not string

          enum enCategories2 : byte
          {
              Electronics = 1,
              Food = 5,
              Automotive = 6,
              Arts = 10,
              BeautyCare = 11,
              Fashion = 15
          }
        */


        // struct Type
        /*
         struct stStudent
          {
            public string FirstName;
            public string LastName;
          }
        */

       
        static void Main(string[] args)
        {
            //WriteLine && Write && Formating String
            //Console.WriteLine("Hello Its Oussama Again Learning C#");
            //Console.WriteLine("The Sum of 5 + 6 is " + (5 + 6));
            //Console.Write("Hello");
            //Console.Write("World");
            //Console.WriteLine("{0} {1}", "Hello", "  World");

            //Escape Characters
            /* Console.WriteLine("Hi its \n Oussama");
             Console.WriteLine("Hello \t World");
             Console.WriteLine("Hello \b World");
             Console.WriteLine("Hello \" World");
             Console.WriteLine("Hello \' World");
             Console.WriteLine("Hello \\ World");
             Console.WriteLine("Hello \a World");
            */

            //Variables

            /*String My_String = "Oussama";
            char MyChar = 'A';
            int x = 10;
            double y = 14.45;
            bool MyBool = true;
            Console.WriteLine("My Name is  " + My_String);
            Console.WriteLine(" First Character is  " + MyChar);
            Console.WriteLine("{0}  {1}", x, y);
            Console.WriteLine(MyBool);
            */



            /* Implicitly typed variables
             

            Alternatively in C#, we can declare a variable without knowing 
            its type using var keyword. 
            Such variables are called implicitly typed local variables.

            Variables declared using var keyword must be initialized at the time of declaration.
           */

            //var x = 10;
            //var y = 10.5;
            //var z = "Mohammed";

            //Console.WriteLine("x={0}, y={1}, z={2}", x, y, z);



            //Numbers Data Type

            //Byte

            /* byte b1 = 255;
             //  byte b2 = -128;// compile-time error: Constant value '-128' cannot be converted to a 'byte'
             sbyte sb1 = -128;
             sbyte sb2 = 127;
             Console.WriteLine("\nByte:");
             Console.WriteLine("Min={0} , Max={1}", Byte.MinValue, Byte.MaxValue);


             Console.WriteLine("\nSByte:");
             Console.WriteLine("Min={0} , Max={1}", SByte.MinValue, SByte.MaxValue);

             //Short
             short s1 = -32768;
             short s2 = 32767;
             // short s3 = 35000;//Compile-time error: Constant value '35000' cannot be converted to a 'short'

             ushort us1 = 65535;
             //  ushort us2 = -32000; //Compile-time error: Constant value '-32000' cannot be converted to a 'ushort'

             Console.WriteLine("\nShort:");
             Console.WriteLine("Min={0} , Max={1}", Int16.MinValue, Int16.MaxValue);

             Console.WriteLine("\nUShort:");
             Console.WriteLine("Min={0} , Max={1}", UInt16.MinValue, UInt16.MaxValue);

             //int
             int i = -2147483648;
             int j = 2147483647;
             //  int k = 4294967295; //Compile-time error: Cannot implicitly convert type 'uint' to 'int'.

             uint ui1 = 4294967295;
             // uint ui2 = -1; //Compile-time error: Constant value '-1' cannot be converted to a 'uint'

             Console.WriteLine("\nInt:");
             Console.WriteLine("Min={0} , Max={1}", Int32.MinValue, Int32.MaxValue);

             Console.WriteLine("\nUInt:");
             Console.WriteLine("Min={0} , Max={1}", UInt32.MinValue, UInt32.MaxValue);

             //Long
             long l1 = -9223372036854775808;
             long l2 = 9223372036854775807;

             ulong ul1 = 18223372036854775808ul;
             ulong ul2 = 18223372036854775808UL;

             Console.WriteLine("\nLong:");
             Console.WriteLine("Min={0} , Max={1}", Int64.MinValue, Int64.MaxValue);

             Console.WriteLine("\nULong:");
             Console.WriteLine("Min={0} , Max={1}", UInt64.MinValue, UInt64.MaxValue);


             //Float
             float f1 = 123456.5F;
             float f2 = 1.123456f;

             Console.WriteLine("\nFloat:");
             Console.WriteLine("Min={0} , Max={1}", float.MinValue, float.MaxValue);


             //double
             double d1 = 12345678912345.5d;
             double d2 = 1.123456789123456d;

             Console.WriteLine("\nDouble:");
             Console.WriteLine("Min={0} , Max={1}", double.MinValue, double.MaxValue);



             //Decimal
             //The decimal type has more precision and a smaller range
             //than both float and double,
             //and so it is appropriate for financial and monetary calculations.
             decimal d3 = 123456789123456789123456789.5m;
             decimal d4 = 1.1234567891345679123456789123m;

             Console.WriteLine("\nDecimal:");
             Console.WriteLine("Min={0} , Max={1}", decimal.MinValue, decimal.MaxValue);


             //Scientific Notation
             //Use e or E to indicate the power of 10 
             //as exponent part of scientific notation with float, double or decimal.

             double d = 0.12e2;
             Console.WriteLine(d);  // 12;

             float f = 123.45e-2f;
             Console.WriteLine(f);  // 1.2345

             decimal m = 1.2e6m;
             Console.WriteLine(m);// 1200000



             //hex & Binary
             int hex = 0x2F;
             int binary = 0b_0010_1111;

             Console.WriteLine(hex);
             Console.WriteLine(binary);
            */



            //Default Value

            /*   //get default value using default(type)
             int i = default(int); // 0
             float f = default(float);// 0
             decimal d = default(decimal);// 0
             bool b = default(bool);// false
             char c = default(char);// '\0'

             // C# 7.1 onwards
             //get default value using default
             int i2 = default; // 0
             float f2 = default;// 0
             decimal d2 = default;// 0
             bool b2 = default;// false
             char c2 = default;// '\0'
            */



            //Enums

            /* enWeekDays WeekDays;

             WeekDays = enWeekDays.Friday;
            */



            //Nullable Type

            /* //  Nullable<int> can be assigned any value
             //  from -2147483648 to 2147483647, or a null value.

             Nullable<int> i = null;
             Console.WriteLine(i);
            */


            //AnanymousType

            /* //you dont specify any type here , automatically will be specified
             var student = new { Id = 20, FirstName = "Mohammed", LastName = "Abu-Hadhoud" };

             Console.WriteLine("\nExample1:\n");
             Console.WriteLine(student.Id); //output: 20
             Console.WriteLine(student.FirstName); //output: Mohammed
             Console.WriteLine(student.LastName); //output: Abu-Hadhoud

             //You can print like this:
             Console.WriteLine(student);


             //anonymous types are read-only
             //you cannot change the values of properties as they are read-only.

             // student.Id = 2;//Error: cannot chage value
             // student.FirstName = "Ali";//Error: cannot chage value


             //An anonymous type's property can include another anonymous type.
             var student2 = new
             {
                 Id = 20,
                 FirstName = "Mohammed",
                 LastName = "Abu-Hadhoud",
                 Address = new { Id = 1, City = "Amman", Country = "Jordan" }
             };

             Console.WriteLine("\nExample2:\n");
             Console.WriteLine(student2.Id);
             Console.WriteLine(student2.FirstName);
             Console.WriteLine(student2.LastName);

             Console.WriteLine(student2.Address.Id);
             Console.WriteLine(student2.Address.City);
             Console.WriteLine(student2.Address.Country);
             Console.WriteLine(student2.Address);
            */


            //Struct Type

            /*  //A struct object can be created with or without the new operator,
              //same as primitive type variables.

              stStudent Student;
              stStudent Student2 = new stStudent();


              Student.FirstName = "Mohammed";
              Student.LastName = "Abu-Hadhoud";


              Console.WriteLine(Student.FirstName);
              Console.WriteLine(Student.LastName);


              Student2.FirstName = "Ali";
              Student2.LastName = "Ahmed";


              Console.WriteLine(Student2.FirstName);
              Console.WriteLine(Student2.LastName);
            */

            // Dynamic Type 
            /*
            dynamic MyDynamicVar = 100;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = "Hello World!!";
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = true;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());

            MyDynamicVar = DateTime.Now;
            Console.WriteLine("Value: {0}, Type: {1}", MyDynamicVar, MyDynamicVar.GetType());
            */

            // Date And Time

            /*
             //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);
            

            //GetCurrent DateTime
            DateTime dt1 = new DateTime();
            dt1 = DateTime.Now;
            Console.WriteLine(dt1);


            //DateTime Static Fields

            DateTime currentDateTime = DateTime.Now;  //returns current date and time
            DateTime todaysDate = DateTime.Today; // returns today's date
            DateTime currentDateTimeUTC = DateTime.UtcNow;// returns current UTC date and time
            DateTime maxDateTimeValue = DateTime.MaxValue; // returns max value of DateTime
            DateTime minDateTimeValue = DateTime.MinValue; // returns min value of DateTime

            Console.WriteLine("currentDateTime: "+currentDateTime);
            Console.WriteLine("Today: " + todaysDate);
            Console.WriteLine("currentDateTimeUTC: " + currentDateTimeUTC);
            Console.WriteLine("minDateTimeValue: " + minDateTimeValue);
            Console.WriteLine("maxDateTimeValue: " + maxDateTimeValue);



            //Time Span


             DateTime dt = new DateTime(2023, 2, 21);

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);


            //Substraction is TimeSpan

            DateTime Dt1 = new DateTime(2020, 12, 4);
            DateTime Dt2 = new DateTime(2022, 10, 4);
            TimeSpan Result = Dt2.Subtract(Dt1);
            Console.WriteLine(Result);


            // Operator in DateTime
             DateTime dt1 = new DateTime(2024, 5, 8);
            DateTime TimeNow = DateTime.Now;
            Console.WriteLine(dt1 + " " + TimeNow);
            Console.WriteLine(dt1 = TimeNow);
            Console.WriteLine(dt1 > TimeNow);
            Console.WriteLine(dt1 <= TimeNow);


            // Convert String DateTime To A DateTime Object

             var MyStringTime = "04/12/2020";
            DateTime Dt1;
            var isValideDate = DateTime.TryParse(MyStringTime,out  Dt1);
            if (isValideDate == false)
            {
                Console.WriteLine("{0} Is not a Valid DateTime String", MyStringTime);
            }
            else
                Console.WriteLine("{0} Is  Valid DateTime String", MyStringTime);


            //Working With String


            string S1 = "Mohammed Abu-Hadhoud";

            Console.WriteLine(S1.Length);

            //this will take 5 characters staring position 2
            Console.WriteLine(S1.Substring(2, 5));
            Console.WriteLine(S1.ToLower());
            Console.WriteLine(S1.ToUpper());
            Console.WriteLine(S1[2]);
            Console.WriteLine(S1.Insert(3, "KKKK"));
            Console.WriteLine(S1.Replace("m", "*"));
            Console.WriteLine(S1.IndexOf("m"));
            Console.WriteLine(S1.Contains("m"));
            Console.WriteLine(S1.Contains("x"));
            Console.WriteLine(S1.LastIndexOf("m"));

            string S2 = "Ali,Ahmed,Khalid";

            string[] NamesList = S2.Split(',');

            Console.WriteLine(NamesList[0]);
            Console.WriteLine(NamesList[1]);
            Console.WriteLine(NamesList[2]);

            string S3 = "  Abu-Hadhoud  ";
            Console.WriteLine(S3.Trim());
            Console.WriteLine(S3.TrimStart());
            Console.WriteLine(S3.TrimEnd());


             //  String Interpolation

            string firstName = "Mohammed";
            string lastName = "Abu-Hadhoud";
            string code = "107";

            //You shold use $ to $ to identify an interpolated string 
            string fullName = $"Mr. {firstName} {lastName}, Code: {code}";

            Console.WriteLine(fullName);

             // String Interpolation  Exemple 2
            string MyName = "Oussama";
            string Occupation = "Software And Researcher";
            string Contry = "Tunisian";

            string Full_Info =$"Mr.{MyName} I work As a {Occupation}  I live in {Contry} ";
            Console.WriteLine(Full_Info);



            /////Type Casting In C#//////
            
            // Implicit Casting :: Automatically from larger Size to Smaller Size
            int Myint = 12;
            Double Mydouble = Myint;
            Console.WriteLine(Mydouble);
            Console.WriteLine(Myint);

            // Explicit Casting 
            
            Double Mydouble =20.54;
            int Myint = (int)Mydouble;
            Console.WriteLine(Mydouble);
            Console.WriteLine(Myint);

            // Casting Types Methods
              int Myint = 3;
            double Mydouble = 13.75;
            bool Mybool = false;
            Console.WriteLine(Convert.ToSByte(Myint));
            Console.WriteLine(Convert.ToString(Mybool));
            Console.WriteLine(Convert.ToInt32(Mydouble));


            // Enums Casting 

                        Console.WriteLine(WeekDays.Friday); //output: Friday 
            int day = (int) WeekDays.Friday; // enum to int conversion
            Console.WriteLine(day); //output: 4 

            var wd = (WeekDays) 5; // int to enum conversion
            Console.WriteLine(wd);//output: Saturday 

            ///////User  Input (ReadLine)///////
            
            Console.WriteLine("Enter Your Name");
            string Name =Console.ReadLine();
            Console.WriteLine($"Your Name is {Name}");

             Console.WriteLine("Enter Your Age");
            int Age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your Age is {Age}");


                     //////// Operator in C#//////////
            //  Unary Operator 

            
            int number = 10, result;
            bool flag = true;

            result = +number;
            Console.WriteLine("+number = " + result);

            result = -number;
            Console.WriteLine("-number = " + result);

            result = ++number;
            Console.WriteLine("++number = " + result);

            result = --number;
            Console.WriteLine("--number = " + result);

            Console.WriteLine("!flag = " + (!flag));

            Console.WriteLine((number++));
            Console.WriteLine((number));

            Console.WriteLine((++number));
            Console.WriteLine((number));


            // Ternary Opertor

             int x = 5;
            bool MyBool= (x == 5)?true:false;
            Console.Write(MyBool);


            //////    Control  Flow ////////
            // if else Statment
             int x = 10; int y = 20;

            //if then statement
            if (x == 10 && y <= 20)
            {
                Console.WriteLine("yes x = 10 and y<=20");
            }



            //if then else statement
            if (x == 11)
            {
                Console.WriteLine("yes x = 11 ");
            }
            else
            {
                Console.WriteLine("yes x != 11 ");
            }


            //if else if statement
            int number = 12;

            if (number < 5)
            {
                Console.WriteLine("{0} is less than 5", number);
            }
            else if (number > 5)
            {
                Console.WriteLine("{0} is greater than 5", number);
            }
            else
            {
                Console.WriteLine("{0} is equal to 5");
            }



            // Switch Statment 

             string Name = "Oussama";
            switch(Name.ToLower())
            {
                case "oussama":
                    Console.WriteLine("Yes Oussama");break;
                case "salim":
                    Console.WriteLine("Yes Salim");break;
                default:
                    Console.WriteLine("No One");break;
            }



              char op;
            double first, second, result;

            Console.Write("Enter first number: ");
            first = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second number: ");
            second = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter operator (+, -, *, /): ");
            op = (char)Console.Read();

            switch (op)
            {
                case '+':
                    result = first + second;
                    Console.WriteLine("{0} + {1} = {2}", first, second, result);
                    break;

                case '-':
                    result = first - second;
                    Console.WriteLine("{0} - {1} = {2}", first, second, result);
                    break;

                case '*':
                    result = first * second;
                    Console.WriteLine("{0} * {1} = {2}", first, second, result);
                    break;

                case '/':
                    result = first / second;
                    Console.WriteLine("{0} / {1} = {2}", first, second, result);
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;

            }



                      char ch;
            Console.WriteLine("Enter a letter?");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                    Console.WriteLine("Vowel");
                    break;
                case 'e':
                    Console.WriteLine("Vowel");
                    break;
                case 'i':
                    Console.WriteLine("Vowel");
                    break;
                case 'o':
                    Console.WriteLine("Vowel");
                    break;
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }



            char ch;
            Console.WriteLine("Enter a letter");
            ch = Convert.ToChar(Console.ReadLine());

            switch (Char.ToLower(ch))
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                default:
                    Console.WriteLine("Not a vowel");
                    break;
            }



            // For Loop

                     Console.WriteLine("\nForward Loop:");
            //forward loop
            for (int i = 1; i <= 10; i++)

            {

                Console.WriteLine(i);

            }

            Console.WriteLine("\nBackword Loop:");
            //backword loop
            for (int i = 10; i >= 1; i--)

            {

                Console.WriteLine(i);

            }


            Console.WriteLine("\nNested Loops:");
            //forward loop
            for (int i = 1; i <= 10; i++)

            {

                for (int j = 0; j < 10; j++)

                {

                    Console.WriteLine("i={0} and j={1}", i, j);

                }

            }



            // While Loop

            int i = 1;
            while (i <= 5)
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;
            }


            // Do While Loop

             int i = 1;
            do
            {
                Console.WriteLine("C# while Loop: Iteration {0}", i);
                i++;

            } while (i <= 5);


            // Break Statment

             int i = 1;
            do
            {

                Console.WriteLine("C# while Loop: Iteration {0}", i);
               
                if (i == 3)
                    break;
               
                i++;

            } while (i <= 5);


            // Continue Statment

            
            for (int i = 1; i <= 5; ++i)
            {

                if (i == 3)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

                        ///////// Arrays //////////
                       
              // create an array
            int[] numbers = { 1, 2, 3 };

            //access first element
            Console.WriteLine("Element in first index : " + numbers[0]);

            //access second element
            Console.WriteLine("Element in second index : " + numbers[1]);

            //access third element
            Console.WriteLine("Element in third index : " + numbers[2]);


            //through loop
            Console.WriteLine("\nAccess array using loop:\n");
            for (int i = 0;i < numbers.Length; i++)
            {
                Console.WriteLine("Element in index {0} : {1} " ,i, numbers[0]);
            }

            // 2D Array

                   //initializing 2D array
            int[,] numbers = { { 12, 13 }, { 55, 77 } };

            // access first element from the first row
            Console.WriteLine("Element at index [0, 0] : " + numbers[0, 0]);

            // access first element from second row
            Console.WriteLine("Element at index [1, 0] : " + numbers[1, 0]);


            // Foreach Loop

              char[] myArray = { 'H', 'e', 'l', 'l', 'o' };

            foreach (char ch in myArray)
            {
                Console.WriteLine(ch);
            }


            ////Operation In Arrays Using System.Linq/////
            

            int[] Age = { 14, 17, 20, 24, 27, 29 };
            Console.WriteLine($"The Maximum Element is {Age.Max()}");
            Console.WriteLine($"The Maximum Element is {Age.Min()}");
            Console.WriteLine($"The Elements Sum is {Age.Sum()}");
            Console.WriteLine($"The Number of Elements is {Age.Count()}");
            Console.WriteLine($"The Average Element is {Age.Average()}");



                   ////////////////////     C# Math ///////////////////////
              
             Console.WriteLine("Max of 5, 10 is: {0}", Math.Max(5, 10));
            Console.WriteLine("Min of 5, 10 is: {0}", Math.Min(5, 10));
            Console.WriteLine("Squir Root of 64 is: {0}", Math.Sqrt(64));
            Console.WriteLine("Absolute (positive) value of  -4.7 is: {0}", Math.Abs(-4.7));
            Console.WriteLine("Round of 9.99 is: {0}", Math.Round(9.99));


            ///////////////////////////   C# Methods ////////////////////////////
           
           //Methds

             static void PrintMyName(string MyName)
        {
            Console.WriteLine($"My Name is {MyName}");
        }
            PrintMyName("Oussama");

            //Methods Parametrs

             static void PrintMyInfo(string Name,byte Age)
        {
            Console.WriteLine("Name= {0} , Age= {1}",Name,Age);
        }
            PrintMyInfo("Mohammed-AbuHadhoud",45);
        
        


        // Default Value
            static void PrintMyInfo(string Name,byte Age,string Address ="No Address")
        {
            Console.WriteLine("Name= {0} , Age= {1}, Address= {2}",Name,Age,Address);
        }
             //First we did not provide the address it's optional
            PrintMyInfo("Mohammed-AbuHadhoud",45);

            //second we provided the address
            PrintMyInfo("Mohammed-AbuHadhoud", 45,"Amman-Jordan");


        // Return Value
            static string GetMyName()
        {
            return "Mohammed-AbuHadhoud";

        }
            Console.WriteLine("My Name is {0}", GetMyName());

        // Named Argument
             static void MyMethod(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
             //see the order of sending parameters is not important.

            MyMethod(child3: "Omar", child1: "Saqer", child2: "Hamza");


        // Methods OverLoading
            static int Sum(int Num1, int Num2)

        {
            return Num1+Num2;
        }

        static int Sum(int Num1, int Num2,int Num3)

        {
            return Num1 + Num2+ Num3;
        }
        static int Sum(int Num1, int Num2, int Num3,int Num4)

        {
            return Num1 + Num2 + Num3+Num4;
        }
        //we have 3 diffrent methods but with the same name.

            Console.WriteLine(Sum(10, 20));
            Console.WriteLine(Sum(10, 20,30));
            Console.WriteLine(Sum(10, 20, 30,40));

        //////      Exception(Try /Catch )
          try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
          */






            Console.ReadKey();
        }
    }
}
