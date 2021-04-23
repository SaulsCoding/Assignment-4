using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4
{
    class Words
    {
        public static string CountCharactersInSentence(string inputString)
        {
            string intNumbers = inputString;
            string strLetters = ""; // this will be used at the end of the code

            intNumbers = intNumbers.Replace(" ", string.Empty).ToLower();
            while (intNumbers != "")// loops checks if thre's an empty string if not
            {
                char letters = intNumbers[0];//chaning the string to an array and the [0] is
                int echo = 0;//created an interger to count the individual characters
                for (int count = 0; count < intNumbers.Length; count++)//length is loops through the entire string
                {
                    if (intNumbers[0] == intNumbers[count])// to compare the array string wordNumber[0] to string 
                    {
                        echo++;
                    }
                }
                strLetters += $" {letters} -> {echo} ";
                intNumbers = intNumbers.Replace(new String(letters, 1), string.Empty);
                //initialising the first character of the of the string
            }
            return strLetters;
        }
    }
}
