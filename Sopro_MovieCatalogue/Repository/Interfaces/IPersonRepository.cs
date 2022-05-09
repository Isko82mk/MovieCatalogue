using Model;
using Model.PersonDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Interfaces
{
    public interface IPersonRepository
    {
        IQueryable<Person> GetAll();
        Person GetById(int id);
        Person Add(Person newPerson);
        bool Update(Person person);
        bool Delete(int id);
    }
}
