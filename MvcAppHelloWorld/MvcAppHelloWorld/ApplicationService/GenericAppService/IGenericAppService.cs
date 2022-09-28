using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcAppHelloWorld
{
    public interface IGenericAppService<T>
    {
        List<T> GetList();
        IEnumerable<T> Search(string searchString);
        void Export(int id);
        T GetByID(int id);
        void EditDetails(T obj);
        void Create(T obj);
        void Delete(int id);
        void Save();
    }
}
