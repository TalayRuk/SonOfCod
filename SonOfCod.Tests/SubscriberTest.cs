using SonOfCod.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace SonOfCod.Tests
{
    public class SubscriberTest
    {
        [Fact]
        public void GetEmailTest()
        {
            //Arrange
            var subscriber = new Subscriber();
            //Act
            var result = subscriber.Email;
            //Assert
            Assert.Equal("Talay@me", result);
        }
    }
}
