using Microsoft.AspNetCore.Mvc;
using Model;
using Model.DTO;
using Services.Interfaces;
using System.Collections.Generic;

namespace Api_Catalogue.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }


        [HttpGet("getall")]
        public ActionResult<IEnumerable<GetAllDto>> GetAll()
        {
            return Ok(_movieService.GetAll());
        }

        [HttpGet("getbyid")]
        public ActionResult<Movie> GetById(int movieId)
        {
            return Ok(_movieService.GetById(movieId));
        }

        [HttpPost("add")]
        public ActionResult<Movie> Add([FromBody] AddMovieDto model)
        {
            return Ok(_movieService.Add(model));
        }

        [HttpPut("edit")]
        public ActionResult<Movie> Edit(EditMovieDto model)
        {
            return Ok(_movieService.Update(model));
        }

        [HttpDelete("delete")]
        public ActionResult<bool> Add(int id)
        {
            return _movieService.Delete(id);
        }
    }
}
