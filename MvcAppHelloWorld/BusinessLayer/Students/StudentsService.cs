using DataAccess;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class StudentsService<T> : IStudentsService<T> where T : class
    {
        private IStudentsRepository<T> _studentsRepository;


        public StudentsService(IStudentsRepository<T> studentsRepository)
        {
            _studentsRepository = studentsRepository;
        }

        public List<T> GetStudentList()
        {
            return _studentsRepository.GetStudentList();
        }

        public T GetByID(int id)
        {
            return _studentsRepository.GetByID(id);
        }
        public void EditStudentDetails(T student)
        {
            _studentsRepository.EditStudentDetails(student);
        }

        public IEnumerable<T> Search(string searchString)
        {
            return _studentsRepository.Search(searchString);
        }

        public void Export(int id)
        {
            _studentsRepository.Export(id);
        }

        public void CreateNewStudent(T student)
        {
            _studentsRepository.CreateNewStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentsRepository.DeleteStudent(id);
        }

        public void Save()
        {
            _studentsRepository.Save();
        }

        //public bool ExportDetails(int id)
        //{

        //    var model = _genericRepository.GetByID(id);

        //    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        //    string downloadArea = Path.Combine(@"C:\\Users\\apetras\\Desktop");
        //    using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, downloadArea, "Student Details.txt")))
        //    {
        //        bool operationResult;
        //        try
        //        {
        //            var name = $"Name: {model.Name}";
        //            var lastName = $"Last name: {model.Lastname}";
        //            var birthday_date = $"Birthday date: {model.Birthday_date}";
        //            var email = $"Email: {model.Email}";
        //            var phone_number = $"Phone Number: {model.Phone_Number}";
        //            var house_address = $"House Address: {model.House_Address}";
        //            var school_name = $"School Name: {model.School_Name}";
        //            var enrollment_date = $"Enrollment date: {model.Enrollment_date}";

        //            outputFile.WriteLine(name);
        //            outputFile.WriteLine(lastName);
        //            outputFile.WriteLine(birthday_date);
        //            outputFile.WriteLine(email);
        //            outputFile.WriteLine(phone_number);
        //            outputFile.WriteLine(house_address);
        //            outputFile.WriteLine(school_name);
        //            outputFile.WriteLine(enrollment_date);

        //            operationResult = true;
        //        }
        //        catch
        //        {
        //            operationResult = false;
        //        }
        //        return operationResult;
        //    }
        //}
    }
}
