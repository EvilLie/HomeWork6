using System;
using System.IO;

namespace HomeWork6
{
    internal class Program
    {
        static string fileName = "database.txt";
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
            WriteToFile(fileName, newEmployee);
        }
        static void Main(string[] args)
        {
            int ID=0;
            while (true)
            {
                
                Output("If you want to add new employee press 1, to read database please press 2, to exit press 0");
                string userChoice = $"{Console.ReadLine().Trim()}";
                switch (Convert.ToInt32(userChoice))
                {
                    case 1:
                        {
                            string s = String.Empty;
                            ID++;
                            s += $"{ID}#";
                            //DateTime dateTime = DateTime.Now;
                            //s += $"{dateTime}#";
                            //Output("Please enter full name of emloyee: ");
                            //s += $"{Console.ReadLine()}#";
                            //Output("Please enter age of new employee: ");
                            //s += $"{Console.ReadLine()}#";
                            //Output("Please enter height of new employee: ");
                            //s += $"{Console.ReadLine()}#";
                            //Output("Enter date of birth: DD.MM.YYYY");
                            //DateTime date = Convert.ToDateTime(Console.ReadLine());
                            //s += $"{date.ToShortDateString()}#";
                            //Output("Please enter place of birth: ");
                            //s += $"{Console.ReadLine()}";
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