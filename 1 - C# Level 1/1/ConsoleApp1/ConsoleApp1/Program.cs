using System;

namespace ConsoleApp1
{
    class Program
    {
        static void MyName()
            {
            Console.WriteLine("Студент Екатерина Семадени.");
            }
        static void Main(string[] args)
        {

            #region Анкета 1

            //Console.WriteLine("студент Екатерина Семадени.");
            MyName();
            Console.WriteLine("Задание 1. Анкета.");
            Console.ReadKey();
            Console.WriteLine("Привет! Давайте познакомимся.");
            Console.WriteLine("Для начала напишите свое имя и фамилию:");
            string name = Console.ReadLine();
            Console.WriteLine("Сколько вам лет?");
            string age = Console.ReadLine();
            Console.WriteLine("Ваш рост?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Укажите, пожалуйста, ваш вес:");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Итак, вас зовут " + name + ", " + "вам " + age + " лет," + "ваш рост " + height + " см, " + "и ваш вес " + weight + " кг.");
            Console.WriteLine($"Итак, вас зовут {name}, вам {age} лет, ваш рост {height} см, и ваш вес {weight} кг.");
            //если честно, не поняла третий способ
            Console.ReadKey();
            #endregion

            #region ИМТ
            
            Console.WriteLine("Задание 2.Индекс массы тела.");
            Console.WriteLine("Давайте расcчитаем индекс массы тела.");
            Console.ReadLine();
            double imt = Convert.ToDouble(weight / (height * height));
            Console.WriteLine($"На основе введеных вами данных ваш ИМТ равен {imt}");

            #endregion

            #region Обмен значениями

            int k = 10;
            int l = 20;
            int m = k;
            k = l;
            l = m;

            int a = 10;
            int b = 20;
            a = a + b;
            b = a - b;
            a = a - b;
            #endregion
        }
    }

}
