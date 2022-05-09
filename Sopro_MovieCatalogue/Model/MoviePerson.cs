using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class MoviePerson
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }

        //public Guid RoleId { get; set; }
     

    }
}
