using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in a word and the programme will check if it's a palindrome.");
            Console.Write("Your word: ");
            PalindromeChecker();
            Console.ReadLine();
        }

        private static void PalindromeChecker()
        {
            string input = Console.ReadLine();
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);

            if (input.ToLower() == reverse.ToLower())
            {
                Console.WriteLine("{0} is a palindrome!", input);
            }
            else
            {
                Console.WriteLine("{0} is not a palindrome.", input);
            }

        }
    }
}
