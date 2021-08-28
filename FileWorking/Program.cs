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
            using (StreamWriter file = new StreamWriter(path, false))
            {
                file.WriteLine(output);
            }
        }
    }
}