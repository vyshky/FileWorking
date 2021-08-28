using System;
using System.IO;

namespace FileWorking
{
    class Program
    {
        static void Main()
        {
            var path_input = @"C:\Users\vyshk\RiderProjects\FileWorking\FileWorking\input.txt";
            string temp;
            using( StreamReader file = new StreamReader(path_input))
            {
                temp = file.ReadToEnd(); // в темп хранится все содержимое файла
            }
            Console.WriteLine(temp);
        }
    }
}