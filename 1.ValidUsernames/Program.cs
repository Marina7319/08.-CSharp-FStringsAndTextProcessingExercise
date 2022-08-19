using System;
using System.Linq;
using System.Collections.Generic;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> validUserName = new List<string>();
            bool isValid = true;
            foreach (var userName in input)
            {
                if (userName.Length >= 3 && userName.Length <= 16)
                {
                    for (int i = 0; i < userName.Length; i++)
                    {
                        char currChar = userName[i];
                        if (currChar == '-' || currChar == '_' || char.IsLetterOrDigit(currChar))
                        {
                            isValid = true;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        validUserName.Add(userName);
                    }
                }
            }
            Console.Write(string.Join(", ", validUserName));
        }
    }
}
