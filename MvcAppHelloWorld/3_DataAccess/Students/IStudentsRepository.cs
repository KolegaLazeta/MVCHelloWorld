using System.Collections.Generic;

namespace DataAccess
{
    public interface IStudentsRepository<T> where T : class
    {
        List<T> GetStudentList();
        IEnumerable<T> Search(string searchString);
        void Export(int id);
        T GetByID(int id);
        void EditStudentDetails(T student);
        void CreateNewStudent(T student);
        void DeleteStudent(int id);
        void Save();
    }
}
