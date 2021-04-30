using RestAspNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNet.Provider
{
    public interface IBookProvider
    {
        Book Create(Book person);
        Book FindById(int id);
        void Delete(int id);
        List<Book> FindAll();
        Book Update(Book person);
    }
}
