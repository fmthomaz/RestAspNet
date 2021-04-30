using RestAspNet.Model;
using System.Collections.Generic;

namespace RestAspNet.Provider
{
    public interface IPersonProvider
    {
        Person Create(Person person);
        Person FindById(int id);
        void Delete(int id);
        List<Person> FindAll();
        Person Update(Person person);
    }
}
