using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    enum type { Текущий, Сберегательный };
    class Schet
    {
        private type type { get; set; }
        private string num_sch { get; set; }
        private string balance { get; set; }
        public Schet(string num_sch, string balance, type type)
        {
            this.num_sch = num_sch;
            this.balance = balance;
            this.type = type;
        } 
        public void Print1()
        {
            Console.WriteLine($"Номер лицевого счета: {num_sch} \nБаланс: {balance} \nТип банковского счета: {type}" );
        }
    }
    class Schet2
    {
        static Random random = new Random();
        private type type { get; set; }
        private int num_sch = random.Next(1000000, 9999999);
        private string balance { get; set; }
        public Schet2(string balance, type type)
        {
            this.balance = balance;
            this.type = type;
        }
        public void Print1()
        {
            Console.WriteLine($"Номер лицевого счета: {num_sch} \nБаланс: {balance} \nТип банковского счета: {type}");
        }
    }
    class Schet3
    {
        static Random random = new Random();
        private type type { get; set; }
        private int num_sch = random.Next(1000000, 9999999);
        private uint balance { get; set; }
        public Schet3(uint balance, type type)
        {
            this.balance = balance;
            this.type = type;
        }
        public void Snyat()
        {
            int x = int.Parse(Console.ReadLine());
            if (x>balance)
            {
                Console.WriteLine("Невозможно снять запрошенную сумму!");
            } 
            else
            {
                Console.WriteLine($"Баланс при снятии: {balance - x}");
            }
        }
        public void Polozh()
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine($"Баланс при пополнении: {balance + x}");
        }
        public void Print1()
        {
            Console.WriteLine($"Номер лицевого счета: {num_sch} \nБаланс: {balance} \nТип банковского счета: {type}");
        }
    }
    class Building
    {
        static Random rand = new Random();
        private int num_build = rand.Next(1000000, 9999999);
        private double height { get; set; }
        private byte kol_etazh { get; set; }
        private int kol_kvart { get; set; }
        private byte kol_podezd { get; set; }
        public Building(double height, byte kol_etazh, int kol_kvart, byte kol_podezd)
        {
            this.height = height;
            this.kol_etazh = kol_etazh;
            this.kol_kvart = kol_kvart;
            this.kol_podezd = kol_podezd;
        }
        public void HeightEtazh()
        {
            double height_etazh = height / kol_etazh;
            Console.WriteLine($"Высота этажа: {height_etazh}");
        }
        public void KolKvartPodezd()
        {
            int kol_kvart_podezd = kol_kvart / kol_podezd;
            Console.WriteLine($"Количество квартир в подъезде: {kol_kvart_podezd}");
        }
        public void KolKvartEtazh()
        {
            int kol_kvart_etazh = kol_kvart / kol_etazh;
            Console.WriteLine($"Количество квартир на этаже: {kol_kvart_etazh}");
        }
        public void Print4()
        {
            Console.WriteLine($"Уникальный номер здания: {num_build} \nВысота здания: {height}\nКоличество этажей: {kol_etazh}\nКоличество квартир: {kol_kvart}\nКоличество подъездов: {kol_podezd}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Задание 7.1.");
            Console.WriteLine();
            Schet schet = new Schet("55565448916", "80 000 000", type.Текущий);
            schet.Print1();

            Console.WriteLine();
            
            Console.WriteLine("Задание 7.2.");
            Console.WriteLine();
            Schet2 schet2 = new Schet2("10 000 000", type.Сберегательный);
            schet2.Print1();
            
            Console.WriteLine();

            Console.WriteLine("Задание 7.3.");
            Console.WriteLine();
            Schet3 schet3 = new Schet3(10000000, type.Сберегательный);
            Console.Write("Введите сумму, которую хотите снять / положить: ");
            schet3.Polozh();
            Console.Write("Введите сумму, которую хотите снять / положить: ");
            schet3.Snyat();
            */
            Console.WriteLine();

            Console.WriteLine("Домашнее задание 7.1.");
            Console.WriteLine();
            Building building = new Building(3, 9, 108, 3);
            building.Print4();
            building.HeightEtazh();
            building.KolKvartEtazh();
            building.KolKvartPodezd();
        }
    }
}
