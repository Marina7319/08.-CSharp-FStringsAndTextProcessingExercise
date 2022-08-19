using System;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string reallyBigNum = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            if(num == 0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sb = new StringBuilder();
            int reminder = 0;
            for(int i = reallyBigNum.Length-1; i >= 0; i--)
            {
                char lastNum = reallyBigNum[i];//4
                int lastNumAsDigit = int.Parse(lastNum.ToString());//4
                int result = lastNumAsDigit * num;
                sb.Append(result % 10);
                reminder = result / 10;
            }
            if(reminder != 0)
            {
                sb.Append(reminder);
            }
            StringBuilder reversedString = new StringBuilder();
            for(int x = sb.Length-1; x >= 0; x--)
            {
                reversedString.Append(sb[x]);
            }
            Console.WriteLine(reversedString);
        }
    }
}
