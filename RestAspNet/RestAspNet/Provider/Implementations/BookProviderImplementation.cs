using RestAspNet.Model;
using RestAspNet.Repository;
using RestAspNet.Repository.Generic;
using System.Collections.Generic;

namespace RestAspNet.Provider.Implementations
{
    public class BookProviderImplementation : IBookProvider
    {
        private readonly IRepository<Book> _repository;

        public BookProviderImplementation(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public Book Create(Book book)
        {
            return _repository.Create(book);
        }
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
        public List<Book> FindAll()
        {

            return _repository.FindAll();
        }
        public Book FindById(int id)
        {
            return _repository.FindById(id);
        }
        public Book Update(Book book)
        {
            return _repository.Update(book);
        }
    }
}
