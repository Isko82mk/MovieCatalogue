using Model;
using Model.PersonDTO;
using Repository.Interfaces;
using Services.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public IEnumerable<GetPersonDTO> GetAll()
        {
            return _personRepository.GetAll().Select(x => new GetPersonDTO
            {

                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Role = x.Role,

            }).AsEnumerable();
        }

        public GetPersonDTO GetById(int id)
        {
            var dbPerosn = _personRepository.GetById(id);

            return new GetPersonDTO
            {
                Id = dbPerosn.Id,
                FirstName = dbPerosn.FirstName,
                LastName = dbPerosn.LastName,
                Role = dbPerosn.Role,
            };
        }

        public Person Add(AddPersonDto newModel)
        {
            var newPerson = new Person
            {
                Id = newModel.Id,
                FirstName = newModel.FirstName,
                LastName = newModel.LastName,
                Role = newModel.Role,
            };
            _personRepository.Add(newPerson);
            return newPerson;
        }

        public Person Update(UpdatePersonDto updatedModel)
        {
            var personDb = _personRepository.GetById(updatedModel.Id);

            if (personDb == null) return null;

            personDb.Id = updatedModel.Id;
            personDb.FirstName = updatedModel.FirstName;
            personDb.LastName = updatedModel.LastName;
            personDb.Role = updatedModel.Role;

            _personRepository.Update(personDb);
            return personDb;

        }

        public bool Delete(int id) => _personRepository.Delete(id);


    }
}
