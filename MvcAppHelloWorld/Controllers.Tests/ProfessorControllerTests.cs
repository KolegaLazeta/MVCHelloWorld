using System;
using Xunit;
using MvcAppHelloWorld;
using System.Web.Mvc;
using BusinessObjectModel;
using Moq;
using AutoMapper;

namespace Controllers.Tests
{
    public class ProfessorControllerTests
    {
        private readonly ProfessorController _controller;
        private readonly Mock<IGenericAppService<ProfessorViewModel, Professor>> _professorMock = new Mock<IGenericAppService<ProfessorViewModel, Professor>>();
        private readonly Mock<IGenericAppService<RoleViewModel, Role>> _roleMock = new Mock<IGenericAppService<RoleViewModel, Role>>();
        private readonly Mock<IMapper> _mapper = new Mock<IMapper>();
        public ProfessorControllerTests()
        {
            _controller = new ProfessorController(_professorMock.Object, _roleMock.Object, _mapper.Object);
        }

        [Fact]
        public void TestDetailsView()
        {
            var result = _controller.Details(2) as ViewResult;
            Assert.Equal("Details", result.ViewName);
        }
    }
    
}
