using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MovieReviewContext())
            {
                Movie movie = new Movie
                {
                    Title = "Days of Thunder",
                    Genre = "Action",
                    ReleaseDate = DateTime.Now
                };

                Person myPerson = new Person
                {
                    Occupation = "Race Car Driver",
                    Age = 30
                };

                Review myReview = new Review
                {
                    Person = myPerson,
                    Movie = movie,
                    Rating = 7
                };

                db.Movies.Add(movie);
                db.Persons.Add(myPerson);
                db.Reviews.Add(myReview);
                db.SaveChanges();
            }












            /*
            Person austin = new Person { Occupation = "Developer", Gender = "M", City = "Greenville", Age = 25 };
            Person bill = new Person { Occupation = "Developer", City = "Barcelona" };

            Movie littleShop = new Movie
            {
                Title = "Little Shop of Horrors",
                Genre = "Musical",
                ReleaseDate = DateTime.Now
            };

            Review myReview = new Review
            {
                Person = austin,
                Movie = littleShop,
                Rating = 8
            };

            Review billReview = new Review
            {
                Person = bill,
                Movie = littleShop,
                Rating = 3
            };

            Console.WriteLine(billReview);
            Console.WriteLine(myReview);
            */
        }
    }
}
