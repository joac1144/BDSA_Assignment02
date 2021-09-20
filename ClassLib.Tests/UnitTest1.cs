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
        
        [Fact]
        public void ImmutableStudent_Equality_For_Records(){
            //Arrange
            ImmutableStudent immutableStudent = new ImmutableStudent(1, "Joachim", "Koefoed", new DateTime(2020, 09, 16), new DateTime(2021, 09, 16), new DateTime(2022, 09, 16)); 
            ImmutableStudent immutableStudent2 = new ImmutableStudent(1, "Joachim", "Koefoed", new DateTime(2020, 09, 16), new DateTime(2021, 09, 16), new DateTime(2022, 09, 16)); 

            //Act
            

            //Assert
            Assert.True(immutableStudent == immutableStudent2);
        }

        [Fact]
        public void ImmutableStudent_expect_false_equality(){
            //Arrange
            ImmutableStudent immutableStudent = new ImmutableStudent(1, "Joachim", "Koefoed", new DateTime(2020, 09, 16), new DateTime(2021, 09, 16), new DateTime(2022, 09, 16)); 
            ImmutableStudent immutableStudent2 = new ImmutableStudent(2, "Joachim", "Koefoed", new DateTime(2020, 09, 16), new DateTime(2021, 09, 16), new DateTime(2022, 09, 16)); 

            //Act
            

            //Assert
            Assert.False(immutableStudent == immutableStudent2);
        }

        [Fact]
        public void ImmutableStudent_ToString_for_Records(){
            //Arrange
            ImmutableStudent immutableStudent = new ImmutableStudent(1, "Joachim", "Koefoed", new DateTime(2020, 09, 16), new DateTime(2021, 09, 16), new DateTime(2022, 09, 16)); 


            //Act
            string output = immutableStudent.ToString();
            string expected = "Name: Joachim Koefoed. ID: 1. StartDate: 16-09-2020 00:00:00. EndDate: 16-09-2021 00:00:00. GraduationDate: 16-09-2022 00:00:00. Status: Dropout";

            //Assert
            Assert.Equal(expected, output);
        }
    }
}
