//using BusinessLayer.High_School_Students;
//using DataAccess;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
//using System;
//using System.Threading.Tasks;

//namespace HighSchoolStudents.Moq
//{
//    [TestClass]
//    public class HighSchoolStudentsServiceTests
//    {
//        private readonly HighSchoolStudents_Service _sut;
//        private readonly Mock<IHighSchoolStudents_Repository> _highSchoolStudentsRepoMock = new Mock<IHighSchoolStudents_Repository>();
       
//        public HighSchoolStudentsServiceTests()
//        {
//            _sut = new HighSchoolStudents_Service(_highSchoolStudentsRepoMock.Object);
//        }

//        [TestMethod]
//        public async Task GetHighSchoolStudentDetails_ShouldReturnSTudents_WhenStudentsExists()
//        {
//            // Arrange
//            var highSchoolStudentID = BitConverter.ToInt32(Guid.NewGuid().ToByteArray(),0);
//            var highSchoolStudentName = "Mirko Mirkovic";


//            // Act
//            var highSchoolStudent = await _sut.GetHighSchoolStudentDetails(highSchoolStudentID);

//            // Assert
//            Assert.Equals(highSchoolStudentID, highSchoolStudent.ID);
//        }
//    }
//}
