using Microsoft.EntityFrameworkCore;
using Model;
using Model.Enums;
using Genre = Model.Genre;

namespace DataAcces
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Movie> Movies { get; set; }

        public DbSet<MoviePerson> MoviePersons { get; set; }

        public DbSet<Person> Persons { get; set; }



        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            mb.Entity<MoviePerson>()
                 .HasKey(mp => new { mp.MovieId, mp.PersonId });


            Seed(mb);
        }

        public void Seed(ModelBuilder mb)
        {
            mb.Entity<Movie>().HasData(

                new Movie()
                {
                    Id = 1,
                    MovieTitle = "Rambo",
                    Description = "Some Rambo Movie Description",
                    Year = "1982",
                    

                },
                new Movie()
                {
                    Id = 2,
                    MovieTitle = "Terminator",
                    Description = "Some Terminator Movie Description",
                    Year = "1986"
                },
                new Movie()
                {
                    Id = 3,
                    MovieTitle = "Batman",
                    Description = "Some  Batman Movie Description",
                    Year = "1986",

                }); ;

            mb.Entity<Person>().HasData(

                new Person()
                {
                    Id = 1,
                    FirstName = "Silvester",
                    LastName = "Stalone",
                    Role = Role.actor,


                },
                new Person()
                {
                    Id = 2,
                    FirstName = "Ted",
                    LastName = " Kotcheff",
                    Role = Role.director,

                },
                new Person()
                {
                    Id = 3,
                    FirstName = "Buzz ",
                    LastName = "Feitshans",
                    Role = Role.producer,

                },
                new Person()
                {
                    Id = 4,
                    FirstName = "Arnold",
                    LastName = "Schwarzenegger",
                    Role = Role.actor,
                },
                new Person()
                {
                    Id = 5,
                    FirstName = "Michael ",
                    LastName = "Keaton",
                    Role = Role.actor,
                }


                );

            mb.Entity<Genre>().HasData(

                 new Genre()
                 {
                     Id = 1,
                     GenreMovie = GenreEnum.action,
                     MovieId = 1
                 },
                 new Genre()
                 {
                     Id = 2,
                     GenreMovie = GenreEnum.action,
                     MovieId = 2

                 },
                 new Genre()
                 {
                     Id = 3,
                     GenreMovie = GenreEnum.action,
                     MovieId = 3

                 });


            mb.Entity<MoviePerson>().HasData(

                new MoviePerson()
                {
                    Id = 1,
                    MovieId = 1,
                    PersonId = 1,

                },
                new MoviePerson()
                {
                    Id = 2,
                    MovieId = 2,
                    PersonId = 4,

                },
                new MoviePerson()
                {
                    Id = 3,
                    MovieId = 3,
                    PersonId = 5,

                }


                );


        }

    }
}
