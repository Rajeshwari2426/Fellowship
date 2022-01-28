using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projects
{
    internal class VowelConsonant
    {
        public static void VowelCheck()
        {
            Console.WriteLine("Enter the Alphabet: ");
            char alphabet = Convert.ToChar(Console.ReadLine());

            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is a Vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is a Vowel");
                    break;
                default:
                    Console.WriteLine("It is a Consonent");
                    break;
            }

        }
    }
}
