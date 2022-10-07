//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using Moq;
//using DataAccess;
//using BusinessObjectModel;
//using BusinessLayer;
//using System.Data.Entity;

//namespace UnitTestProject1
//{
//    [TestClass]
//    public class HighSchoolServiceTest
//    {
//        private Mock<DbSet<HighSchool>> _mockHighSchoolDBSet;
//        private HighSchool _modelState;
//        private HighSchoolService _service;

//        [TestInitialize]
//        public void Initialize()
//        {
//            _mockRepository = new Mock<HighSchoolRepository>();
//            _modelState = new HighSchool();
//            _service = new HighSchoolService(_mockRepository.Object);
//        }


//        //public void CreateHighSchoolStudent()
//        //{
//        //    // Arrange
//        //    var student = Students.CreateNewStudent(1, "Steven", "Stevenovic", new DateTime(1999 / 04 / 05), "stevenstevenovic@gmail.com", "34234234", "Adresa 45", "Skola 344", new DateTime(2014 / 05 / 08));

//        //    // Act
//        //    var result = _service.CreateNewStudent(student);

//        //    // Assert
//        //    Assert.IsTrue(result);
//        //}
//    }
//}
