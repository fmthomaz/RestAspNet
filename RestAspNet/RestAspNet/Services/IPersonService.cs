using RestAspNet.Model;
using System.Collections.Generic;

namespace RestAspNet.Services
{
    public interface IPersonService
    {
        Person Create(Person person);
        Person FindById(long id);
        void Delete(long id);
        List<Person> FindAll();
        Person Update(Person person);
    }
}
