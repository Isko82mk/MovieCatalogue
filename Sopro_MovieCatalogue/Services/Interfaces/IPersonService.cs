using Model;
using Model.PersonDTO;
using System.Collections.Generic;

namespace Services.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<GetPersonDTO> GetAll();
        GetPersonDTO GetById(int id);
        Person Add(AddPersonDto newModel);
        Person Update(UpdatePersonDto updatedModel);
        bool Delete(int id);

    }
}
