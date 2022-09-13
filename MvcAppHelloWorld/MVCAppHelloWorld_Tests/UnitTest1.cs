using DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MVCAppHelloWorld_Tests
{
    [TestClass] // - M/S test framework
    public class HighSchoolStudents_Repository_Tests
    {
        [TestMethod] // - M/S test framework

                        //nameofmethod_scenario_expectedbehavior
        public void EditStudentDetails_StudentIsEdited_ReturnsTrue()
        {
            //Arrange
            var highSchoolRepository = new HighSchoolStudents_Repository();

            //Act
            var result = highSchoolRepository.EditStudentDetails(new HighSchoolStudents_Repository.operationResult);

            //Assert
            Assert.IsTrue(result);
        }
    }


}
