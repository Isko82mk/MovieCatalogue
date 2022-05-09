using Model;
using Model.DTO;
using Repository.Interfaces;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class MovieService : IMovieService
    {

        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public IEnumerable<GetAllDto> GetAll()
        {
            try
            {
                return _movieRepository.GetAll()
                        .Select(x => new GetAllDto
                        {
                            Id = x.Id,
                            MovieTitle = x.MovieTitle,
                            Description = x.Description,
                            Year = x.Year
                        }).AsEnumerable();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public Movie GetById(int id)
        {
            try
            {
                return _movieRepository.GetById(id);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Movie Add(AddMovieDto model)
        {
            try
            {
                var newNote = new Movie
                {
                    Id = model.Id,
                    MovieTitle = model.MovieTitle,
                    Description = model.Description,
                    Year = model.Year,
                };

                return _movieRepository.AddMovie(newNote);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public Movie Update(EditMovieDto model)
        {
            var movieDb = _movieRepository.GetAll().FirstOrDefault(x => x.Id == model.Id);
            if (movieDb == null) return null;



            movieDb.Description = model.Description;
            movieDb.Year = model.Year;

            _movieRepository.UpdateMovie(movieDb);

            return movieDb;
        }

        public bool Delete(int id)
        {
            _movieRepository.DeleteMovie(id);
            return true;
        }

    }
}
