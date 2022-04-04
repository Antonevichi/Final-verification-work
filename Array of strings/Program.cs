// Написать программу, которая из массива строк формирует массив из строк, длина которых меньше либо равна трём символам.

using System;

class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите массив из строк ");
            string text = Console.ReadLine();
             string[] spled = text.Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries);

            
            var res = from word in spled
                      where word.Length <= 3
                      select word;
            if (res.Count() == 0)
            {
                Console.WriteLine("Значения меньше, либо равные трем символам отсутствуют");
            }
            else
            {
                foreach (string s in res)
                {
                    Console.WriteLine("Занчения которые отвечают критерию запроса  " + s);
                }
            }
            Console.ReadLine();
        }
    }

