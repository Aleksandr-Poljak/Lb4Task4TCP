using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using MSACAL;
using static System.Console;



namespace Lb4Task4TCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calendar calendar = new Calendar();
            WriteLine("Объект MSACA.Calendar создан.");
            WriteLine($"Текущая дата: {calendar.Day}.{calendar.Month}.{calendar.Year}");
            calendar.Month = 3;
            calendar.Year = 2026;
            WriteLine($"Текущая дата: {calendar.Day}.{calendar.Month}.{calendar.Year}");
        }
    }
}
