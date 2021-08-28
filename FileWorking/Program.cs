using System;
using System.Collections.Generic;
using System.IO;

namespace FileWorking
{
    public class User
    {
        public string Name { get; set; }
        public DateTime DateOfBithday { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string path = @"C:\Users\vyshk\RiderProjects\FileWorking\FileWorking\user.csv";
            User user = new User();
            user.Name = "Alexandr";
            user.DateOfBithday = new DateTime(1994, 03, 27);

            string output = $"{user.Name};{user.DateOfBithday.ToString("d")}";
            using (StreamWriter file = new StreamWriter(path, false)) //запись в файл из output
            {
                file.WriteLine(output);
            }

////////////////////////////////////////////////////////////////////////////////////////////////////////
            User person = new User();
            string line;
            using (StreamReader file = new StreamReader(path)) //считывание из файла в line
            {
                line = file.ReadLine();
            }

            //Console.WriteLine(line[0]);// выводит по одному символу
            string[] temp = line.Split(";"); // расщепляем слова разделительным символом ";" 
            person.Name = temp[0];
            person.DateOfBithday = Convert.ToDateTime(temp[1]);
            Console.WriteLine($"Name - {user.Name}\t,Date of birth - {user.DateOfBithday:d}"); // найди отличие с нижней строчкой,а работает также
            Console.WriteLine($"Name - {user.Name}\t,Date of birth - {user.DateOfBithday.ToString("d")}");
        }
    }
}