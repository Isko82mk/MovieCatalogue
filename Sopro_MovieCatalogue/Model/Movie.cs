using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string MovieTitle { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }

        public IList<MoviePerson> MoviePersons { get; set; }
        public IList<Genre> Genres { get; set; }
    }
}
