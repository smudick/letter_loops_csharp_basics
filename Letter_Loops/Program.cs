using System;

namespace Letter_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Letter Loops 

            Console.WriteLine("Enter a random group of letters");
            var stringInput = Console.ReadLine();
            var output = "";
            for (int i = 0; i < stringInput.Length; i++)
            {
                var letter = stringInput[i];
                var letterSequence = new String(letter, i + 1);
                var letterSequenceUpperCase = char.ToUpper(letterSequence[0]) + letterSequence.Substring(1);
                output += letterSequenceUpperCase + "-";
            }
            Console.WriteLine(output.TrimEnd('-'));
        }
    }
}
