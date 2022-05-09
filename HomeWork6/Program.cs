using System;
using System.IO;

namespace HomeWork6
{
    internal class Program
    {
        public static void Output(string text)
        {
            Console.Write(text);
        }
        public static void Message()
        {
            Console.Write("If you want to add more employees enter 2, to read database please enter 1, to exit please press 0: \n");
        }
        //public static void Reading()
        //{
        //    string[] lines = File.ReadAllLines("database.txt");
        //    foreach (var line in lines)
        //    {
        //        string[] elems = line.Split(new[] { '#' }, StringSplitOptions.RemoveEmptyEntries);
        //        foreach (string elem in elems)
        //        {
        //            Output($"{elem} ");
        //        }
        //    }
        //    Message();
        //    Writing(Console.ReadLine());
        //}
        public static void Read()
        {
            using (StreamReader reader = new StreamReader("database.txt"))
            {
                
                while(!reader.EndOfStream)
                {
                    string []line = reader.ReadLine().Split('#');
                    foreach (var elem in line)
                    {
                        Output(elem);
                    }
                }
            }
        }
        public static void Writing(string key)
        {
            {
                using (StreamWriter stream = new StreamWriter("datebase.txt"))
                {
                    while (key == $"{2}")
                    {
                        string newEmployee = string.Empty;
                        Output("Please write ID of new employee: ");
                        newEmployee += $"{Console.ReadLine()}#";
                        string now = DateTime.Now.ToString();
                        newEmployee += $"{now}#";
                        Output("Please enter full name of new employee: ");
                        newEmployee += $"{Console.ReadLine().Trim()}#";
                        Output("Enter the age of employee: ");
                        newEmployee += $"{Console.ReadLine()}#";
                        Output("Enter height of new emloyer: ");
                        newEmployee += $"{Console.ReadLine()}#";
                        Output("Please enter day, month and year of birth: ");
                        DateTime dateOfBirth = Convert.ToDateTime(Console.ReadLine());
                        newEmployee += $"{dateOfBirth}#";
                        Output("Please enter place of birth: ");
                        newEmployee += $"{Console.ReadLine()}#";
                        stream.WriteLine(newEmployee);
                        Message();
                        key = Console.ReadLine();
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Output("If you want to add more employees enter 2, to read database please enter 1, to exit please press 0: \n");
            string key = Console.ReadLine();
            while (true)
            {
                switch (int.Parse(key))
                {
                    case 0: Output("Program is exterminated by user \n"); break;
                    case 1: Read(); ; break; 
                    case 2: Writing(key); break;
                }
            }
        }
    }
}
