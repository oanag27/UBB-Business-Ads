﻿namespace UBB_Business_Ads.Tests
{
    using Backend.Models;
    using Backend.Services;
    using Moq;
    using Xunit;

    public class TODOServicesTest
    {
        [Fact]
        public void GetTODOServicesInstanceTest()
        {
            // Act
            TODOServices instance1 = TODOServices.Instance;
            TODOServices instance2 = TODOServices.Instance;

            // Assert
            Xunit.Assert.Equal(instance1, instance2);
        }

        [Fact]
        public void GetTODOS_Test()
        {
            var todoServices = TODOServices.Instance;

            // Act
            var result = todoServices.getTODOS();

            // Assert
            Xunit.Assert.NotNull(result);
        }

        [Fact]
        public void AddTODO_Test()
        {
            // Arrange
            var mockServices = new Mock<IServicesTODO>();
            var todoObj = new TODOClass();

            // Act
            mockServices.Object.addTODO(todoObj);

            // Assert
            // Verify that the addTODO method is called on the mock services exactly once
            mockServices.Verify(s => s.addTODO(todoObj), Times.Once);
        }

        [Fact]
        public void RemoveTODO_Test()
        {
            // Arrange
            var todoServices = TODOServices.Instance;
            int nonExistingId = 9999; // Non-existing id
            int size = todoServices.getTODOS().Count;

            // Act
            todoServices.removeTODO(nonExistingId);

            // Assert
            // Verify that no actions are performed
            // The list of TODOs remains same
            Xunit.Assert.Equal(size, todoServices.getTODOS().Count);
        }
    }
}
