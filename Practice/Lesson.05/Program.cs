using System;
namespace Lesson._05
{
    class Program
    {
        static void Main()
        {
            TimeSpan CurTime = System.DateTime.Now.TimeOfDay;
            int CurHours = CurTime.Hours;
            string OutputConsoleString;
            if (CurHours > 9 & CurHours < 12)
            {
                OutputConsoleString = "Good morning, guys!";
            }
            else if (CurHours >= 12 & CurHours < 15)
            {
                OutputConsoleString = "Good day, guys!";
            }
            else if (CurHours >= 15 & CurHours < 22)
            {
                OutputConsoleString = "Good evening, guys!";
            }
            else
            {
                OutputConsoleString = "Все лабораторку кодите? Удачи!";
            }
            Console.WriteLine(OutputConsoleString + "\nCurrent Time: " + CurTime.ToString());
        }
    }
}