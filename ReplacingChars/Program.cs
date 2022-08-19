using System;

namespace ReplacingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            for (int i = 0; i < input.Length - 1; i++)
            {
                bool isDifferent = true;
                if (input[i] == input[i + 1])
                {
                    isDifferent = false;
                }
                if (isDifferent)
                {
                    result += input[i + 1];
                }
            }
            Console.Write(input[0]);
            Console.Write(result);
        }
    }
}
