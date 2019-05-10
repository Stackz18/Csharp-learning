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
            char[] cArray = input.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }

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
