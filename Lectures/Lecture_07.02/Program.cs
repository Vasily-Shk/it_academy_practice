using System;

namespace Lecture_07._02
{
    class Program
    {
        static void Main (string[] args)
        {
            string testArr = new { 32, A,Hello};
            for (int i = 0; i < 4; i++)
            {
                string s = testArr(i);
                Console.WriteLine(s);
            }
            
            Console.WriteLine("Hello World!");
        }
    }
}
