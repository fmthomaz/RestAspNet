using RestAspNet.Model;
using RestAspNet.Repository;
using RestAspNet.Repository.Generic;
using System.Collections.Generic;

namespace RestAspNet.Provider.Implementations
{
    public class PersonProviderImplementation : IPersonProvider
    {
        private readonly IRepository<Person> _repository;

        public PersonProviderImplementation(IRepository<Person> repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {

            return _repository.FindAll();
        }

        public Person FindById(int id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }        
    }
}
