using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DataAccess
{
    public class StudentsRepository<T> : TuxContext, IStudentsRepository<T> where T : class
    {
        private TuxContext _context = null;
        private DbSet<T> table = null;

        public StudentsRepository()
        {
            this._context = new TuxContext();
            table = _context.Set<T>();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void CreateNewStudent(T student)
        {
            table.Add(student);
        }

        public void DeleteStudent(int id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void EditStudentDetails(T student)
        {
            table.Attach(student);
            _context.Entry(student).State = EntityState.Modified;
        }

        public T GetByID(int id)
        {
            return table.Find(id);
        }

        public List<T> GetStudentList()
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
