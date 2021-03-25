using ConsoleDI;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestExample
{
    public class ServiceTests
    {
        [Fact]
        public void Service_Calls_LogMessage_from_Logger_Once() 
        {
            //Arrange
            Mock<ILoggerUtil> mockLogger = new Mock<ILoggerUtil>();

            mockLogger.Setup(m => m.StoreMessage(It.IsAny<string>())).Returns(It.IsAny<string>());

            //Act
            var service = new Service(mockLogger.Object);
            var result = service.LogMessage("test123");

            //Assert.Throws<NotImplementedException>(() => service.LogMessage("any text"));

            //Assert
            Assert.Null(result);
            mockLogger.Verify(m => m.StoreMessage(It.IsAny<string>()), Times.Once());
            //mockLogger.Verify(m => m.StoreMessage(It.IsAny<string>()), Times.Exactly(2));
        }
    }
}
