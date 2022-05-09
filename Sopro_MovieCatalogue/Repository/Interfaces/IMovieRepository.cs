using Model;
using Model.DTO;
using System.Linq;

namespace Repository.Interfaces
{
    public interface IMovieRepository
    {
        IQueryable<Movie> GetAll();
        Movie GetById(int id);
        Movie AddMovie(Movie model);
        Movie UpdateMovie(Movie model);
        bool DeleteMovie(int id);  
    }
}
