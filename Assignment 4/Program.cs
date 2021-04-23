using System;

namespace Assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string charMessenge = Console.ReadLine();
            

            string text = Words.CountCharactersInSentence(charMessenge);
            Console.WriteLine(text);
        }
    }
}
