using System;
using System.Linq;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            
            string reverseWordString = string.Join(" ", originalString
            .Split(' ')
            .Select(x => new String(x.Reverse().ToArray())));
            string WordString = string.Empty;
            foreach (char c in reverseWordString)
            {
                WordString = c + WordString;
            }
            Console.Write($"Reverse Word String is : {WordString} ");
            Console.ReadLine();
        }      
    }
}



            