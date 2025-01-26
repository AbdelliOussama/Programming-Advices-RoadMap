using EmpDataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Case_Statment
{
    internal class Program
    {
       
        public static void CalculateBonuse(DataTable dtEmployees)
        {
            float Bonus = 0;
            foreach(DataRow row in dtEmployees.Rows)
            {
                if ((string)row["Department"]=="Sales")
                {
                    if ((int)row["PerformanceRating"] > 90)
                    {
                        Bonus = (int)row["Salary"] * 0.15f;
                    }
                    else if((int)row["PerformanceRating"] < 90 && (int)row["PerformanceRating"] > 75)
                    {
                        Bonus = (int)row["Salary"] * 0.10f;

                    }
                    else
                    {
                        Bonus = (int)row["Salary"] * 0.05f;
                    }
                }
                else if ((string)row["Department"] == "HR")
                {
                    if ((int)row["PerformanceRating"] > 90)
                    {
                        Bonus = (int)row["Salary"] * 0.10f;
                    }
                    else if ((int)row["PerformanceRating"] < 90 && (int)row["PerformanceRating"] > 75)
                    {
                        Bonus = (int)row["Salary"] * 0.80f;

                    }
                    else
                    {
                        Bonus = (int)row["Salary"] * 0.04f;
                    }
                }
                else
                {
                    if ((int)row["PerformanceRating"] > 90)
                    {
                        Bonus = (int)row["Salary"] * 0.80f;
                    }
                    else if ((int)row["PerformanceRating"] < 90 && (int)row["PerformanceRating"] > 75)
                    {
                        Bonus = (int)row["Salary"] * 0.60f;

                    }
                    else
                    {
                        Bonus = (int)row["Salary"] * 0.03f;
                    }
                    Console.WriteLine("Bonus = "+Bonus);
                }

            }
        }
        static void Main(string[] args)
        {
            DataTable Employes = clsEmpData.GetAllEmployee();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            CalculateBonuse(Employes);
            stopwatch.Stop();
            Console.WriteLine("Time Passed  = "+stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
