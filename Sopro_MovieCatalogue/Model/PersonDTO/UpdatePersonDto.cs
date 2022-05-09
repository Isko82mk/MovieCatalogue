using Model.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.PersonDTO
{
    public class UpdatePersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
    }
}
