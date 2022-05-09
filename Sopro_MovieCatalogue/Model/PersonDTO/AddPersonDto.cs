using Model.Enums;

namespace Model.PersonDTO
{
    public class AddPersonDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
    }
}
