using System;
using System.IO;

namespace FileWorking
{
    class Program
    {
        static void Main()
        {
            var path_input = @"C:\Users\vyshk\RiderProjects\FileWorking\FileWorking\input.txt";
            StreamReader file = new StreamReader(path_input);
            var temp = file.ReadToEnd(); // в темп хранится все содержимое файла
            file.Close();
            
            Console.WriteLine(temp);
            
        }
    }
}