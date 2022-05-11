using System;
using System.IO;

namespace HomeWork6
{
    internal class Program
    {
        public static void Output(string text)
        {
            Console.WriteLine(text);
        }
        public static void WriteToFile(string fileName, string s)
        {
            File.AppendAllText(fileName, $"{s}\n");
        }
        public static string ReadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                return File.ReadAllText(fileName);
            }
            else
            {
                return "";
            }
        }
        public static void WriteEmployee(string newEmployee)
        {
            string fileName = "datebase.txt";
            WriteToFile(fileName, newEmployee);
        }
        static void Main(string[] args)
        {
            string fileName = "database.txt";

            while (true)
            {
                Output("If you want to add new employee press 1, to read database please press 2, to exit press 0");
                string userChoice = $"{Console.ReadLine().Trim()}";
                switch (Convert.ToInt32(userChoice))
                {
                    case 1:
                        {
                            Output("Please enter full name of emloyee: ");
                            string s = Console.ReadLine();
                            WriteEmployee(s);
                            continue;
                        }
                    case 2:
                        {
                            Output("Current employees: ");
                            Output(ReadFromFile(fileName));
                            continue;
                        }
                    case 0:
                        {
                            Output("Program executed by user");
                            break;
                        }

                }
                if (Convert.ToInt32(userChoice) == 0)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}