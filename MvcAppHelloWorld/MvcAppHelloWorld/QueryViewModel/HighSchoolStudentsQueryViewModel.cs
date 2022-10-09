using System;

namespace MvcAppHelloWorld
{
    public class HighSchoolStudentsQueryViewModel : UsersQueryViewModel
    {
        public string School_Name { get; set; }
        public DateTime Enrollment_Date { get; set; }
    }
}