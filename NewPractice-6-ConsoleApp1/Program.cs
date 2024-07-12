using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPractice_6_ConsoleApp1
{
    internal class Program
    {
        static void Record(string path, string text)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                Console.Write("ID: ");
                string t = Console.ReadLine();
                text += $"{t}";

                string now = DateTime.Now.ToShortTimeString();
                Console.Write($"Время записи: {now}");
                text += $"{now}";

                Console.Write("\nФИО: ");
                string t1 = Console.ReadLine();
                text += $"{t1}";

                Console.Write("Возраст: ");
                string t2 = Console.ReadLine();
                text += $"{t2}";

                Console.Write("Рост: ");
                string t3 = Console.ReadLine();
                text += $"{t3}";

                Console.Write("Дата рождения: ");
                string t4 = Console.ReadLine();
                text += $"{t4}";

                Console.Write("Место рождения: ");
                string t5 = Console.ReadLine();
                text += $"{t5}";

                string[] values = new string[] { t, now, t1, t2, t3, t4, t5 };
                string t10 = string.Join("#", values);
                sw.WriteLine(t10);
            }
        }
        static void ReadText(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            string path = "newFile.txt";
            string text = string.Empty;
            while (true)
            {
                Console.WriteLine("Нажмите 1, чтобы вывести список на экран");
                Console.WriteLine("Нажмите 2, чтобы добавить данные сотрудника");
                Console.WriteLine("Нажмите 0, чтобы выйти");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "0":
                        return;
                    case "1":
                        ReadText(path);
                        break;
                    case "2":
                        Record(path, text);
                        break;
                    default:
                        Console.WriteLine("Неизвестный пункт меню");
                        break;
                }
            }
        }
    }
}
