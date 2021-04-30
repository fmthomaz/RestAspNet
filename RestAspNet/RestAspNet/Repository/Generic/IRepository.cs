using RestAspNet.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAspNet.Repository.Generic
{
   public interface IRepository <T> where T : BaseEntity
    {
        T Create(T item);
        T FindById(int id);
        void Delete(int id);
        List<T> FindAll();
        T Update(T item);
        bool Exists(int id);
    }
}
