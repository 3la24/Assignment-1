using System;
namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            
            int len = inputString.Length;
            Console.WriteLine("All substrings for given string are : ");
            
            //This loop maintains the starting character  
            for (int i = 0; i < len; i++)
            {
                //This loop adds the next character every iteration for the substring and then print
                for (int j = 0; j < len - i; j++)
                {
                    Console.Write (inputString.Substring(i, j + 1) + " ");
                }
            }
            
            Console.ReadKey();
        }
    }
}