using System;
using System.Linq;
using System.Collections.Generic;

namespace ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> usernameList = new List<string>();
            for (int i = 0; i < username.Length; i++)
            {
                string currentUserName = username[i];
                if (currentUserName.Length > 3 && currentUserName.Length < 16)
                {
                    bool isValid = true;
                    for (int x = 0; x < currentUserName.Length; x++)
                    {
                        char userNameChar = currentUserName[x];
                        if (!(userNameChar == '-' || userNameChar == '_' || char.IsLetterOrDigit(userNameChar)))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        usernameList.Add(currentUserName);
                    }
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine, usernameList));
        }
    }
}
