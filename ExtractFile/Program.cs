using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            char separator = (char)92;
            string[] pathToFile = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int x = pathToFile.Length - 1;
            string[] file = pathToFile[x].Split(".");
            string fileName = file[0];
            Console.WriteLine("File name: " + fileName);
            string fileExtension = file[1];
            Console.WriteLine("File extension: " + fileExtension);
        }
    }
}

