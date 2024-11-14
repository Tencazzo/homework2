using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        struct Info
        {
            public string Name;
            public string City;
            public int Age;
            public string Pincode;

            public void Print1()
            {
                Console.WriteLine($"Имя: {Name}");
                Console.WriteLine($"Город: {City} ");
                Console.WriteLine($"Возраст: {Age}");
                Console.WriteLine($"PIN-код: {Pincode}");
            }
            static void Main(string[] args)
            {
                Console.WriteLine("Задание 1");
                Console.WriteLine("Логический тип");
                Console.WriteLine("bool -  true или false");
                Console.WriteLine("Целочисленные типы");
                Console.WriteLine("byte - 255 - 0 ");
                Console.WriteLine("sbyte -  127 - (- 128)");
                Console.WriteLine("short - 32767 - (-32768 )");
                Console.WriteLine("ushort - 65535 - 0");
                Console.WriteLine("int - 2147483647 -  (-2147483648) ");
                Console.WriteLine("uint - 4294967295 - 0");
                Console.WriteLine("long - 9 223 372 036 854 775 807 - (–9 223 372 036 854 775 808) ");
                Console.WriteLine("ulong - 18 446 744 073 709 551 615 - 0");
                Console.WriteLine("Вещественные типы");
                Console.WriteLine("float - 3.402823e38 - (-3.402823)");
                Console.WriteLine("double - 1.797693e308 - (-1.797693e308)");
                Console.WriteLine("decimal - 7.922816e28 - (-7.922816e28)");
                Console.WriteLine("Задание 2");
                Info user;
                Console.WriteLine("Введите имя");
                user.Name = Console.ReadLine();
                Console.WriteLine("Введите город");
                user.City = Console.ReadLine();
                Console.WriteLine("Введите возраст");
                user.Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите PIN-код:");
                user.Pincode = Console.ReadLine();
                user.Print1();
                Console.WriteLine("Задание 3");
                Console.WriteLine("Введите строку");
                string a = Console.ReadLine();
                string b = "";
                int g = a.Length;
                if (g > 0)
                {
                    for (int i = 0; i < g; i++)
                    {
                        int chr = Convert.ToInt32(a[i]);
                        if (chr <= 90 && chr >= 65)
                        {
                            char c = Convert.ToChar(chr + 32);
                            b = b + c;
                        }
                        else if (chr >= 97 && chr <= 122)
                        {
                            char c = Convert.ToChar(chr - 32);
                            b = b + c;
                        }
                        else
                        {
                            Console.WriteLine("Введите строку правильно");
                        }

                    }
                }

                Console.WriteLine("Задание 4");
                Console.WriteLine("Введите строку");
                string str = Console.ReadLine();
                Console.WriteLine("Введите подстроку");
                string str1 = Console.ReadLine();
                if (str.Length > str1.Length)
                {
                    int count = str.Split(str1).Length - 1;
                    Console.WriteLine($"Количество вхождений: {count}");
                }

                Console.WriteLine("Задание 5");
                Console.WriteLine("Введите стандартную цену");
                double normPrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите  цену в Duty Free");
                double salePrice = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите стоимость отпуска");
                double holidayPrice = Convert.ToDouble(Console.ReadLine());
                double countBottle = holidayPrice / ((normPrice * salePrice) / 100);
                Console.WriteLine($"Сколько бутылок вам надо :{Math.Floor(countBottle)}");
            }
        }
    }
}

