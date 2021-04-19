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
                    Console.Write("Введёно не верное значение. Введите целое число больше 0.");
                }
            }
            while (!tryC);
            Student[] st = new Student[nRecord];
            string sn, fn;
            int nRB;
            for (int i=0; i < nRecord; i++)
            {
                do
                {
                    Console.Write("Введите Фамилию:");
                    sn = Console.ReadLine();
                    
                    if (Regex.IsMatch(sn, @"^[a-zA-Z]+$"))
                    {
                        Console.Write("Введёно не верное значение. Введите слово без цифр и с заглавной буквы.");
                        tryC = false;
                    }
                }
                while (!tryC);
                st[i].surname = sn;

                do
                {
                    Console.Write("Введите Имя:");
                    fn = Console.ReadLine();


                    if (Regex.IsMatch(sn, @"^[a-zA-Z]+$"))
                    {
                        Console.Write("Введёно не верное значение. Введите слово без цифр и с заглавной буквы.");
                        tryC = false;
                    }
                }
                while (!tryC);
                st[i].firstname = fn;

                do
                {
                    Console.Write("Введите номер зачётной книжки:");
                    tryC = Int32.TryParse(Console.ReadLine(), out nRB);
                    if (tryC == false || nRecord <= 0)
                    {
                        tryC = false;
                        Console.Write("Введёно не верное значение. Введите целое число больше 0");
                    }
                }
                while (!tryC);
                st[i].numberRecordBook = nRB;
            }

        }
    }
}
