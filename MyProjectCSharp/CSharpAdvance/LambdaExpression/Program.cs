using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> lsitPersonsinCity = new List<Person>();
            AddRecords(lsitPersonsinCity);
        }   
        private static void AddRecords(List<Person> listPersonsinCity)
        {
            listPersonsinCity.Add(new Person("2016456215", "Sourabh", "12 Main Street, Kolhapur, Maharashtra", 15));
            listPersonsinCity.Add(new Person("2016456+54", "Karan", "56 Main Street, Kolhapur, Maharashtra", 25));
            listPersonsinCity.Add(new Person("2016456223", "Abhi", "63 Main Street, Kolhapur, Maharashtra", 35));
            listPersonsinCity.Add(new Person("2016453235", "Rohan", "55 Main Street, Kolhapur, Maharashtra", 55));
            listPersonsinCity.Add(new Person("2016665565", "Prafull", "9562 Main Street, Kolhapur, Maharashtra", 65));
            listPersonsinCity.Add(new Person("2015465965", "Harish", "156 Main Street, Kolhapur, Maharashtra", 65));
            listPersonsinCity.Add(new Person("2016444551", "Sandip", "196 Main Street, Kolhapur, Maharashtra", 85));
            listPersonsinCity.Add(new Person("2016444551", "Amol", "84 Main Street, Kolhapur, Maharashtra", 95));
          
        }
        private static void Retrieving_TopTwoRecord_LessThanSixty(List<Person> listPersonsinCity)
        {
            foreach (Person person in listPersonsinCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name : " + person.Name + "\t\tAge : " + person.Age);
            }
        }
    }
}
