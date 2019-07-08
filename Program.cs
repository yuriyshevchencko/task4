using System;
using System.Text.RegularExpressions;

namespace task4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string world;
            Console.WriteLine("Enter the word");
            world = Console.ReadLine();
            string s = world.ToLower();

            Match match = Regex.Match(s, @"^[a-zа-я]+$");

            if (match.Success)
            {
                Console.WriteLine($"The correct word is {match.Value}");
            }

            string resultworld = match.Value;

            IsPalindrome(resultworld);

        }


        public static void IsPalindrome(string resultworld)
        {

            {

                char[] chars = resultworld.ToCharArray();
                for (int i = 0; i < (chars.Length / 2); i++)
                {
                    if (chars[i] != chars[chars.Length-1 - i])
                    {
                        Console.WriteLine("The entered word is not palindrome!");
                    }

                    if(i == (chars.Length / 2)-1)
                    {
                        Console.WriteLine("The entered word is palindrome!");
                    }

                }

            }

        }
    }
}












