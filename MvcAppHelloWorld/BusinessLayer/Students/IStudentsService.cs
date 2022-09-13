using System.Collections.Generic;

namespace BusinessLayer
{
    public interface IStudentsService<T>
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
