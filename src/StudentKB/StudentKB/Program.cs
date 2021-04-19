using System;


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
                    Console.Write("Введёно не верное значение. Введите целое не отрицательное число");
                }
            }
            while (!tryC);
            Student[] student;
        }
    }
}
