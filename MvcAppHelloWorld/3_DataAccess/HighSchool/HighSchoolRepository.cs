using BusinessObjectModel;
using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;

namespace DataAccess
{
    public class HighSchoolRepository : StudentsRepository<HighSchool>
    {
        public override IEnumerable<HighSchool> Search(string searchString)
        {
            using (var db = new TuxContext())
            {
                var students = from m in db.HighSchool
                               select m;

                if (string.IsNullOrEmpty(searchString))
                {
                    return db.HighSchool.ToList();
                }
                else
                {
                    return db.HighSchool.ToList().Where(s => s.Name.Contains(searchString) |
                                                     s.Lastname.Contains(searchString) |
                                                     s.Email.Contains(searchString) |
                                                     s.House_Address.Contains(searchString) |
                                                     s.Birthday_date.ToString().Contains(searchString) |
                                                     s.Phone_Number.ToString().Contains(searchString) |
                                                     s.School_Name.Contains(searchString) |
                                                     s.Enrollment_date.ToString().Contains(searchString));

                }
            }
        }

        public override void Export(int id)
        {
            using (var db = new TuxContext())
            {
                var model = db.HighSchool.Find(id);

                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string downloadArea = Path.Combine(@"C:\\Users\\apetras\\Desktop");

                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, downloadArea, "Student Details.txt")))
                {

                    try
                    {
                        var name = $"Name: {model.Name}";
                        var lastName = $"Last name: {model.Lastname}";
                        var birthday_date = $"Birthday date: {model.Birthday_date}";
                        var email = $"Email: {model.Email}";
                        var phone_number = $"Phone Number: {model.Phone_Number}";
                        var house_address = $"House Address: {model.House_Address}";
                        var school_name = $"School Name: {model.School_Name}";
                        var enrollment_date = $"Enrollment date: {model.Enrollment_date}";

                        outputFile.WriteLine(name);
                        outputFile.WriteLine(lastName);
                        outputFile.WriteLine(birthday_date);
                        outputFile.WriteLine(email);
                        outputFile.WriteLine(phone_number);
                        outputFile.WriteLine(house_address);
                        outputFile.WriteLine(school_name);
                        outputFile.WriteLine(enrollment_date);
                    }
                    catch
                    {

                    }
                }
            }
        }
    }
}
