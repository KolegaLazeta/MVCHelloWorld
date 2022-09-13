//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Moq;
//using DataAccess.Students_HC;
//using BusinessObjectModel_Students;
//using BusinessLayer.Students_HC;

//namespace UnitTestProject1
//{
//    [TestClass]
//    public class HighSchoolServiceTest
//    {
//        private Mock<IStudentsHC_Repository> _mockRepository;
//        private Students _modelState;
//        private StudentsHC_Service _service;

//        [TestInitialize]
//        public void Initialize()
//        {
//            _mockRepository = new Mock<IStudentsHC_Repository>();
//            _modelState = new Students();
//            _service = new StudentsHC_Service(_mockRepository.Object);
//        }
//        [TestMethod]
//        public void CreateHighSchoolStudent()
//        {
//            // Arrange
//            var student = Students.CreateNewStudent(1, "Steven", "Stevenovic", new DateTime(1999 / 04 / 05), "stevenstevenovic@gmail.com", "34234234", "Adresa 45", "Skola 344", new DateTime(2014 / 05 / 08));

//            // Act
//            var result = _service.CreateNewStudent(student);

//            // Assert
//            Assert.IsTrue(result);
//        }
//    }
//}
