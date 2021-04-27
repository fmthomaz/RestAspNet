using RestAspNet.Model;
using System.Collections.Generic;

namespace RestAspNet.Repository

{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        void Delete(long id);
        List<Person> FindAll();
        Person Update(Person person);
        bool Exists(long id);
       
    }
}
