using System;
using System.ComponentModel.Design.Serialization;

namespace lesson2
{
    class Program
    {
        private static void MinNumber()
        {
            int a = 23;
            int b = 14;
            int c = 67;
            int min;
            if (a < b && a < c)
            {
                min = a;
            }
            else if (a < b || a > c)
            {
                min = c;
            }
            else
            {
                min = b;
            };
            return;
        }
        private static void Count()
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            while (n != 0)
            {
                count++;
                n = n / 10;
            }
            Console.WriteLine(count);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("студент Екатерина Семадени");

            string log = "root";
            string pass = "geekbrains";
            int count = 0;
            do
            {
                Console.WriteLine("Введите логин: ");
                string checkLog = Console.ReadLine();

                Console.WriteLine("Введите пароль: ");
                string checkPass = Console.ReadLine();

                if (log == checkLog && pass == checkPass)
                {

                    Console.WriteLine("Доступ разрешен");
                    break;
                }
                Console.WriteLine("Ошибка доступа. Попробуйте еще раз: ");
                ++count;
            } while (count < 3);


            Console.WriteLine("Запущена программа вычисления индекса массы тела (ИМТ).");
            Console.WriteLine("Укажите ваш рост и вес и я скажу вам, в норме ли ваш ИМТ.");
            Console.WriteLine("Укажите ваш рост в сантиметрах:");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Укажите ваш вес в килограммах:");
            double w = Convert.ToDouble(Console.ReadLine());

            double imt = Convert.ToDouble(w / ((h * h)) * 10000);
            Console.WriteLine($"ваш имт равен {imt}");

            if (imt < 18.5)
            {
                Console.WriteLine("Слишком мало, нужно набрать вес");
            }
            else if (imt > 25)
            {
                Console.WriteLine("Слишком много, нужно сбросить вес");
            }
            else Console.WriteLine("Вы в отличной форме.");





        }

    }




}
