﻿using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IManager accountingVP = new CEO();

            accountingVP.FirstName = "Emma";
            accountingVP.LastName = "Stone";
            accountingVP.CalculatePerHourRate(4);
            Console.WriteLine($"{ accountingVP.FirstName }'s salary is ${ accountingVP.Salary }/hour.");


            BaseEmployee emp = new CEO();

            emp.FirstName = "Tim";
            emp.LastName = "Corey";
            //emp.AssignManager(accountingVP);
            emp.CalculatePerHourRate(4);

            Console.WriteLine($"{ emp.FirstName }'s salary is ${ emp.Salary }/hour.");

            Console.ReadLine();
        }
    }
}
