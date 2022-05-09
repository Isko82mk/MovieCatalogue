using DataAcces;
using Model;
using Model.DTO;
using Repository.Interfaces;
using System;
using System.Linq;

namespace Repository
{
    public class MovieRepository : IMovieRepository
    {
        private readonly DataContext _dataContext;

        public MovieRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        IQueryable<Movie> IMovieRepository.GetAll()
        {
            return _dataContext.Movies.AsQueryable();
        }

        public Movie GetById(int id)
        {
            return _dataContext.Movies.FirstOrDefault(x => x.Id == id);
        }


        public Movie AddMovie(Movie movie)
        {
            
            _dataContext.Movies.Add(movie); 
            _dataContext.SaveChanges();

            return movie;
        }

        public Movie UpdateMovie(Movie movie)
        {
            _dataContext.Update(movie);
            _dataContext.SaveChanges();

            return movie;
        }

        public bool DeleteMovie(int id)
        {
           var movieDb = _dataContext.Movies.FirstOrDefault(x => x.Id == id);
            if (movieDb == null) return false;

            _dataContext.Remove(movieDb);
            _dataContext.SaveChanges();

            return true;
        }

    }
}
