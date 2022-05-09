using Model;
using Model.DTO;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IMovieService
    {
        IEnumerable<GetAllDto> GetAll();
        Movie GetById(int id);
        Movie Add(AddMovieDto model);
        Movie Update(EditMovieDto model);
        bool Delete(int id);


    }
}
