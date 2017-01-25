using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    public class MovieReviewContext : DbContext //entity has *migrations* - allow us to make changes to the entity framework project
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
