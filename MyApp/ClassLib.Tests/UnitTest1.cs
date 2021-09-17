using System;
using Xunit;
using System.Globalization;

namespace ClassLib.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Status_is_only_readable()
        {
            //Arrannge
            Student student = new Student(1, "Joachim", "Koefoed", new DateTime(2020, 09, 16), new DateTime(2021, 09, 16), new DateTime(2022, 09, 16));

            //Act
            var output = student.Status;

            //Assert
            Assert.Equal(Status.Dropout, output);
            

        }
    }
}
