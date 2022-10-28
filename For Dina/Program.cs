using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_Dina
{
    abstract class Person 
    {
        public string name { get; set; }
        public Person(string Name)
        {
            name = Name;
        }
    }
    class Workgiver : Person
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string otchestvo { get; set; }
        public byte age { get; set; }
        public string comppany { get; set; }
        public string phone { get; set; }
        public Workgiver(string Name) : base(Name) { }
        public void Print1()
        {
            Console.WriteLine($"Имя: {name}");
        }
    }
    class WorkFinder
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string otchestvo { get; set; }
        public byte age { get; set; }
        public bool sportsman { get; set; }
        public string phone { get; set; }
        public bool experience { get; set; }
    }
    class Place
    {
        public string country { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int home { get; set; }
        public void Place1(string country, string city, string street, int home)
        {
            this.country = country;
            this.city = city;
            this.street = street;
            this.home = home;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
