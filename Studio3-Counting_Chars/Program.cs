using System;
using System.Collections.Generic;

namespace Studio3_Counting_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reduce amount of times iterating in the text by removing already searched words
            string textInput = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //create a dynamic data structure where more can be added
            //dictionary
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for (int i = 0; i < textInput.Length; i++)
            {
                //textInput[i];//create dictionary key if it doesnt exist
                //int count = 1;
                if (charCount.ContainsKey(textInput[i]))
                {
                    //count++;
                    charCount[textInput[i]] ++;
                }
                else
                {
                    charCount.Add(textInput[i], 1);//create key, initialize counts
                }
                //find key, not case sensitive, get value and count++
            }

            foreach (KeyValuePair<char, int> charInString in charCount)
            {
                Console.WriteLine(charInString.Key + " (" + charInString.Value + ")");
            }
        }
    }
}

//here's my solution for reference -Will: https://github.com/w911m560/CountingCharacters/blob/master/CountingCharacters/Program.cs