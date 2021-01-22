using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigLatinTranslator
{
    class Program
    {
        private static char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };

        static void Main(string[] args)
        {
            string userInput = null;
            bool askAgain = true;

            Console.WriteLine("Welcome to the Pig Latin Translator.");

            while(askAgain)
            {
                //TODO add logic to clear userInput string on every fresh run when program is finished

                Console.WriteLine("Please enter the word or phrase you want to translate");
                userInput = ValidateInput(Console.ReadLine());

                if(userInput != null)
                {
                    askAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid input, cannot be blank");
                }
                Translator(userInput);
            }

        }

        public static string ValidateInput(string input)
        {
            if (input.Trim() != null && input.Trim() != "")
            {
                return input.Trim();
            }
            else
            {
                return null;
            }
        }

        //Note: note used in main, used in the Translate method below
        //Also need to add logic to check if word starts with a vowel or not
        public static string Translator(string input)
        {
            string consonants;
            string remaining;
            string translated;

            consonants = input.Substring(0, input.IndexOfAny(vowels));
            remaining = input.Substring(input.IndexOfAny(vowels));
            translated = $"{remaining}{consonants}ay";

            //TODO remove cws when done, for debugging purposes
            Console.WriteLine(consonants);
            Console.WriteLine(remaining);
            Console.WriteLine(translated);
            return consonants;
        }

        public static string[] Translate(string[] splitInput)
        {
            string[] translated = new string[splitInput.Length];
            return null;
        }

    }
}
