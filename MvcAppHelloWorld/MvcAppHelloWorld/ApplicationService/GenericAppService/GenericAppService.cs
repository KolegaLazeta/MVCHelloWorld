using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BusinessLayer;
using BusinessObjectModel;

namespace MvcAppHelloWorld
{
    public class GenericAppService<T> : IGenericAppService<T>
    {
        private readonly IGenericService<T> _genericService;

        public GenericAppService(IGenericService<T> genericService)
        {
            _genericService = genericService;
        }
        public List<T> GetList()
        {
            return _genericService.GetList();
        }

        public T GetByID(int id)
        {
            return _genericService.GetByID(id);
        }
        public void EditDetails(T obj)
        {
            _genericService.EditDetails(obj);
        }

        public IEnumerable<T> Search(string searchString)
        {
            return _genericService.Search(searchString);
        }

        public void Export(int id)
        {
            _genericService.Export(id);
        }

        public void Create(T obj)
        {
            _genericService.Create(obj);
        }

        public void Delete(int id)
        {
            _genericService.Delete(id);
        }

        public void Save()
        {
            _genericService.Save();
        }
    }
}