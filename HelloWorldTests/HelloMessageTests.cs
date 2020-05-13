using System;
using NUnit;
using NUnit.Framework;
using HelloWorld;

namespace HelloWorldTests
{
    [TestFixture]
    public class HelloMessageTests
    {
        [TestCase]
        public void Should_Be_Valid_Message()
        {
            //Arrange
            string expectedMessage = "Hello World!";
            var message = new Message();
            message.MyMessage = "Hello World!";

            //Act
            string actualMessage = message.MyMessage;

            //Assert
            Assert.AreEqual(expectedMessage, actualMessage, "Invalid Message");
        }

        [TestCase]
        public void Should_Be_Invalid_Message()
        {
            //Arrange
            string expecMsg = "Hello World!";
            var msg = new Message();
            msg.MyMessage = "Helllll";

            //Act
            string actMsg = msg.MyMessage;

            //Assert
            Assert.AreNotEqual(expecMsg, actMsg, "Invalid Message");
        }
    }
}
