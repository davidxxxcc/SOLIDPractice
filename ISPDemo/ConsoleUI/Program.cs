using DemoLibrary;
using DemoLibrary.DigitalMovie;
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
            IBorrowableDVD DVD = new DVD();
            IBorrowableDVD movie = new DigitalMovie();
             

            Console.ReadLine();
        }
    }
}
