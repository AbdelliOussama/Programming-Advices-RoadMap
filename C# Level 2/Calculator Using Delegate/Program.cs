using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Calculator
{
    public delegate void CalculatorDelegate(double x, double y);
    public CalculatorDelegate _Calculator;

    public Calculator(CalculatorDelegate calculator)
    {
        _Calculator = calculator;
    }
    public void Calculate(double x, double y)
    {
        _Calculator(x, y);
    }
}
public class Program
{
    public static void Add(double x, double y)
    {
        Console.WriteLine($"The Sum Of {x} and {y}  =  " + x + y);
    }
    public static void Substract(double x, double y)
    {
        Console.WriteLine($"The substraction Of {x} and {y}  =  " + (x - y));
    }
    public static void Multiply(double x, double y)
    {
        Console.WriteLine($"The Multiplication Of {x} and {y}  =  " + (x * y));
    }
    public static void Divise(double x, double y)
    {
        Console.WriteLine($"The Division Of {x} and {y}  =  " + (x / y));
    }
    static void Main(string[] args)
    {
        Calculator calculator = new Calculator(Add);
        Calculator calculator1 = new Calculator(Substract);
        Calculator calculator2 = new Calculator(Multiply);
        Calculator calculator3 = new Calculator(Divise);


        calculator.Calculate(3, 7);
        calculator1.Calculate(3, 7);
        calculator2.Calculate(3, 7);
        calculator3.Calculate(3, 7);


        Console.ReadKey();


    }
}
