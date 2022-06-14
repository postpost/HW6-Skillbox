using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6_Skillbox
{
    internal class Program
    {
        static void AddNewNote()
        {
            string path = "newStaff.txt";
            using (StreamWriter sw = new StreamWriter (path, true, Encoding.Unicode))
            {
                char key = 'д';
                int ID = 0;

                    //string [] data = sw.ReadAllLines(path);
                    //StringBuilder sb = new StringBuilder(data.Length);
                    //ID = sb[0];
             
                do 
                {
                    string note = string.Empty;
                    note += $"{++ID}#";
                    string dateTime = DateTime.Now.ToShortDateString();
                    note += $"{dateTime}#";
                    Console.WriteLine("\nФ.И.О.");
                    string fullName = Console.ReadLine();
                    note += $"{fullName}#";
                    Console.WriteLine("Возраст");
                    string age = Convert.ToString(Console.ReadLine());
                    note += $"{age}#";
                    Console.WriteLine("Рост");
                    string height = Console.ReadLine();
                    note += $"{height}#";
                    Console.WriteLine("Дата рождения");
                    DateTime birthday = DateTime.Parse(Console.ReadLine());
                    note += $"{birthday.ToShortDateString()}#";
                    Console.WriteLine("Место рождения");
                    string placeOfBirthday = Console.ReadLine();
                    note += $"{placeOfBirthday}\t";
                    sw.WriteLine(note);
                    Console.Write("Продолжить н/д?");
                    key = Console.ReadKey(true).KeyChar;
                } while (char.ToLower(key) == 'д');
            }
        }

        static void ReadFile(string path)
        {
            using(StreamReader sr = new StreamReader(path, Encoding.Unicode))
            {
                string line;
                while ((line = sr.ReadLine())!= null)
                {
                   string[]data = line.Split('#');
                   foreach (var item in data) Console.WriteLine(item);
                }
            }
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Нажмите 1 для вывода данных на экран; 2 - для добавления новой записи");
                       
            if (Console.ReadLine() == "1")
            {   
                Console.WriteLine();
                ReadFile("newStaff.txt");
            } else
            {
                Console.WriteLine("Введите следующие данные сотрудника");
                AddNewNote();
            }
            
            Console.ReadKey();
            Console.WriteLine();
        }
    }
}
