using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataAccess;
using BusinessObjectModel_HighSchoolStudents;

namespace MvcAppHelloWorld.UnitTests
{
    [TestClass] // - M/S test framework
    public class HighSchoolStudents_Repository_Tests
    {
        [TestMethod] // - M/S test framework

                       //nameofmethod_scenario_expectedbehavior
        public void EditStudentDetails_StudentIsEdited_ReturnsTruer()
        {
            //Arrange
            var highSchoolRepository = new HighSchoolStudents_Repository();

            //Act
            highSchoolRepository.EditStudentDetails(new HighSchoolStudents_Repository {operationResult = true });


            //Assert
        }
    }
}
