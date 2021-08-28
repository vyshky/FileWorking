using System;
using System.Collections.Generic;
using System.IO;

namespace FileWorking
{
    class Program
    {
        static void Main()
        {
            var path_input = @"C:\Users\vyshk\RiderProjects\FileWorking\FileWorking\input.txt";
            List<string> temp = new List<string>();//массив строк
            using (StreamReader file = new StreamReader(path_input))
            {
                // temp = file.ReadToEnd(); // в темп хранится все содержимое файла

                string line;
                while ((line = file.ReadLine()) != null)
                {
                    temp.Add(line);//записываем построчно в темп
                }
            }
            
            foreach (var str in temp)
            {
                Console.WriteLine(str);
            }
            
        }
    }
}