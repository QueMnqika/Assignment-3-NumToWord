using System;

namespace Assignment_3_NumToWord
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumToWord numberConvert = new NumToWord();
            Console.WriteLine("What is the 4-digits number you'd like to convert to a word?");
            string reply = Console.ReadLine();
            int newReply = int.Parse(reply);
            string output = numberConvert.NumberConverter(newReply);
            Console.WriteLine(output);
        }
    }

}
