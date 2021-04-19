using System;
using System.Text.RegularExpressions;

namespace StudentKB
{
    class Program
    {
        static void Main(string[] args)
        {
            int nRecord;
            bool tryC;
            do
            {
                Console.Write("Введите количество записей:");
                tryC = Int32.TryParse(Console.ReadLine(), out nRecord);
                if (tryC == false || nRecord <= 0)
                {
                    tryC = false;
                    Console.WriteLine("Введёно не верное значение. Введите целое число больше 0.");
                }
            }
            while (!tryC);
            Student[] st = new Student[nRecord];
            string sn="", fn="";
            int nRB;

            for (int i=0; i < nRecord; i++)
            {
                
                do
                {
                    tryC = true;
                    Console.Write("Введите Фамилию:");
                    sn = Console.ReadLine();

                    if (!Regex.IsMatch(sn, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Введёно не верное значение. Введите слово без цифр и с заглавной буквы.");
                        tryC = false;
                    }
                }
                while (!tryC);
                do
                {
                    tryC = true;
                    Console.Write("Введите Имя:");
                    fn = Console.ReadLine();
                    if (!Regex.IsMatch(fn, @"^[a-zA-Z]+$"))
                    {
                        Console.WriteLine("Введёно не верное значение. Введите слово без цифр и с заглавной буквы.");
                        tryC = false;
                    }
                }
                while (!tryC);
                do
                {
                    tryC = true;
                    Console.Write("Введите номер зачётной книжки:");
                    tryC = Int32.TryParse(Console.ReadLine(), out nRB);
                    if (tryC == false || nRecord <= 0)
                    {
                        tryC = false;
                        Console.WriteLine("Введёно не верное значение. Введите целое число больше 0");
                    }
                }
                while (!tryC);
                st[i] = new Student(sn, fn, nRB);
            }

            Student.cout(st, nRecord);
            Student.sortUpSF(st, nRecord);
            Console.WriteLine("");
            Student.cout(st, nRecord);
        }
    }
}
