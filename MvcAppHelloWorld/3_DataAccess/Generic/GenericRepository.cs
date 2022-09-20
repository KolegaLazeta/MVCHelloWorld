﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class GenericRepository<T> : TuxContext, IGenericRepository<T> where T : class
    {
        private TuxContext _context = null;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._context = new TuxContext();
            table = _context.Set<T>();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Create(T obj)
        {
            table.Add(obj);
        }

        public void Delete(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void EditDetails(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        public T GetByID(int id)
        {
            return table.Find(id);
        }

        public List<T> GetList()
        {
            return table.ToList();
        }

        public virtual IEnumerable<T> Search(string searchString)
        {
            return null;
        }

        public virtual void Export(int id)
        {
            
        }
       
    }
}