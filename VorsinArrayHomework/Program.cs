using System;

namespace VorsinArrayHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1
            /*
             Console.WriteLine( "Write your numbers") ;
            string consoleNumbers = Console.ReadLine();
            consoleNumbers = consoleNumbers.Replace(" ", ",");
            int length=1;
            char ch = ',';
            foreach (char c in consoleNumbers)
            {
                if (c == ch) {
                    length++;
                }; 
            }
            

            
            string [] yourArray = new string[] { consoleNumbers };
            int [] yourArrayInInt = Array.ConvertAll(yourArray, s => int.Parse(s));
            Console.WriteLine(yourArray[0]);
            */

            Console.WriteLine("Write your numbers");
            string consoleNumbers = Console.ReadLine();

            int length = 1;
            char ch = ' ';
            foreach (char c in consoleNumbers)
            {
                if (c == ch)
                {
                    length++;
                };
            }
           int[] yourNumbers= Array.ConvertAll(consoleNumbers.Split(' '),int.Parse);
            
            for(int i=0; i < length;)
            {
                Console.Write(yourNumbers[i]);
                i++;

            }
            
            
            
        }
    }
}
