using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Методичка
    {
        enum cheks
        {
            savingchek = 5108,
            usingchek = 2554,
        }
        struct BankInfo
        {
            public int Index;
            public string Type;
            public int money;

            public void Info()
            {
                Console.WriteLine($"Индекс: {Index}");
                Console.WriteLine($"Тип: {Type} ");
                Console.WriteLine($"Денег на счету: {money}");
            }

        }
        public enum Unik
        {
            КГУ = 1,
            КАИ = 2,
            КХТИ = 3
        }
        public struct Worker
        {
            public Unik university;
            public string Name;
            public void Print()
            {
                Console.WriteLine($"Имя: {Name} ");
                Console.WriteLine($"Университет: {university}");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 3.1");
            cheks now = cheks.usingchek;
            Console.WriteLine("Текущий счёт");
            Console.WriteLine($"денег на счете:{(int)now}");
            cheks now1 = cheks.savingchek;
            Console.WriteLine("Сберегательный счёт");
            Console.WriteLine($"денег на счете:{(int)now1}");
            Console.WriteLine("Упражнение 3.2");
            BankInfo user;
            user.Index = 228778335;
            user.Type = "Накопительный";
            user.money = 5108;
            user.Info();
            Console.WriteLine("Домашнее задание 3.1");
            Worker people1;
            Console.WriteLine("Введите имя");
            people1.Name = Console.ReadLine();
            Console.WriteLine("Выберите вуз: КГУ(1),КАИ(2),КХТИ(3)");
            int i = int.Parse(Console.ReadLine());
            people1.university = (Unik)(i);
            people1.Print();

        }
    }
}

