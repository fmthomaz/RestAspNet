using RestAspNet.Model;
using RestAspNet.Model.Context;
using RestAspNet.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestAspNet.Provider.Implementations
{
    public class PersonProviderImplementation : IPersonProvider
    {
        private readonly IPersonRepository _repository;

        public PersonProviderImplementation(IPersonRepository repository)
        {
            _repository = repository;
        }

        public Person Create(Person person)
        {
            return _repository.Create(person);
        }

        public void Delete(long id)
        {
            _repository.Delete(id);
        }

        public List<Person> FindAll()
        {

            return _repository.FindAll();
        }

        public Person FindById(long id)
        {
            return _repository.FindById(id);
        }

        public Person Update(Person person)
        {
            return _repository.Update(person);
        }        
    }
}
