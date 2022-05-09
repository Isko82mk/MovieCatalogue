using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.DTO
{
    public class AddMovieDto
    {
     
        public int Id { get; set; }
        public string MovieTitle { get; set; }

        public string Description { get; set; }
        public string Year { get; set; }

        
    }
}
