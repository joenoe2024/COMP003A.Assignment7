/*
 * Author: Joseph Sandoval
 * Course: intro to programming C#
 * purpose: Basic Data structure 
 * */

using System.Reflection.Metadata.Ecma335;

namespace COMP003A.Assignment7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Array - CharacterCounter Section");

            Console.WriteLine("Please enter a letter:");
            char letter = Console.ReadKey().KeyChar;
            Console.WriteLine("\nPlease enter a word:");
            string word = Console.ReadLine();

            int count = CharacterCounter(letter, word);
            Console.WriteLine($"There's {count} letter {letter} in the word {word}");

            SectionSeparator("Array - IsPalindrome Section");
            
            Console.WriteLine("Please enter a word to check if it is a palindrome:");
            string response = Console.ReadLine();
            IsPalindrome(response);
            Console.WriteLine($"Is the word {response} palindrome:{true}");

            SectionSeparator("List - Add Section");

            List<string> names = new List<string>();

            char userInput = default;

            do
            {
                Console.WriteLine("Please enter a name (or press (e) to exit)");
                string input = Console.ReadLine();

                if (input.ToLower()=="e")
                {
                    break;
                }
                names.Add(input);
            }
            while (true);
            Console.WriteLine("Names collected: ");
            foreach (string name in names)
            {
                Console.WriteLine(name);   
            }

            SectionSeparator("List - Traversal Section");

            ListTraversal(names);

            SectionSeparator("List - Reverse Traversal Section");

            TraverseListReverse(names);






        }


        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n{section} section\n" + "".PadRight(50, '*'));
        }


        static int CharacterCounter(char character, string word)
        {
            int count = 0;
            foreach (char c in word)
            {
                if (c == character)
                {
                    count++;
                }
                    
            }
            return count;
        }

        static bool IsPalindrome(string response)
        {
            int left = 0;
            int right = response.Length -1;
            while (left<right)
            {
                if (response[left]!= response[right])
                    return false;

                left++;
                right--;
   
            }
            return true;
        }

        static void ListTraversal (List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void TraverseListReverse(List<string> list)
        {
            for (int i = list.Count -1; i>=0; i--)
            {
                Console.WriteLine(list[i]);
            }
        }
    }


}




   
