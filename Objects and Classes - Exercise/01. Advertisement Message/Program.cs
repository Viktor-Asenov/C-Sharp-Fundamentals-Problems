using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> phrases = new List<string> {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."};

            List<string> events = new List<string> {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"};

            List<string> authors = new List<string> { 
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" };

            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var random = new Random();            

            for (int i = 0; i < phrases.Count; i++)
            {
                var randomIndex = random.Next(0, phrases.Count); 
                
                string randomPhrase = phrases[randomIndex];
                var phrase = phrases[i];

                phrases[randomIndex] = phrase;
                phrases[i] = randomPhrase;
            }

            for (int i = 0; i < events.Count; i++)
            {
                var randomIndex = random.Next(0, events.Count);

                string randomEvent = events[randomIndex];
                var currentEvent = events[i];

                events[randomIndex] = currentEvent;
                events[i] = randomEvent;
            }

            for (int i = 0; i < authors.Count; i++)
            {
                var randomIndex = random.Next(0, authors.Count);

                string randomAuthor = authors[randomIndex];
                var author = authors[i];

                authors[randomIndex] = author;
                authors[i] = randomAuthor;
            }

            for (int i = 0; i < cities.Count; i++)
            {
                var randomIndex = random.Next(0, cities.Count);

                string randomCity = cities[randomIndex];
                var city = cities[i];

                cities[randomIndex] = city;
                cities[i] = randomCity;
            }

            int n = int.Parse(Console.ReadLine());            

            for (int i = 0; i < n; i++)
            {                
                Console.WriteLine($"{phrases[i]} {events[i]} {authors[i]} – {cities[i]}.");
            }
        }
    }
}
