
using DataAcces;
using Model;
using Model.PersonDTO;
using Repository.Interfaces;
using System;
using System.Linq;

namespace Repository
{

    public class PersonRepository : IPersonRepository
    {

        private readonly DataContext _dc;

        public PersonRepository(DataContext dc)
        {
            _dc = dc;
        }

        public IQueryable<Person> GetAll()
        {
            return _dc.Persons.AsQueryable();
        }

        public Person GetById(int id)
        {
            return _dc.Persons.SingleOrDefault(x => x.Id == id);

        }
        
        public Person Add(Person person)
        {
           _dc.Persons.Add(person);  
            _dc.SaveChanges();

            return person;
        }

        public bool Update(Person person)
        {
            _dc.Update(person);
            _dc.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var person = _dc.Persons.SingleOrDefault(x => x.Id == id);
            if (person == null) return false;
           
            _dc.Persons.Remove(person);
            _dc.SaveChanges();

            return true;

        }


    }
}
