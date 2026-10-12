using System;
using System.Globalization;
using System.Collections.Generic;
using ExercícioResolvidoEnum02.Entities;

namespace ExercícioResolvidoEnum02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.ParseExact("21/06/2018 13:05:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                "Traveling to New Zealand",
                "I'm going to travel to New Zeland",
                12
            );
            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("Good night");
            Comment c4 = new Comment("May the Force be with you");

            Post p2 = new Post(
                DateTime.ParseExact("28/07/2018 23:14:19", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                "Good night guys",
                "See you tomorrow",
                5
            );
            p2.AddComment(c3);
            p2.AddComment(c4);

            foreach (Post post in new List<Post> { p1, p2 })
            {
                Console.WriteLine(post);
            }
        }
    }
}