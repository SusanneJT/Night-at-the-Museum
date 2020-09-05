using System;
using Xunit;
using System.Collections.Generic;

namespace EnNattPaMuseet.test
{
    public class TestZornMuseet
    {
        [Fact]
        public void CheckIfMuseumTwoIsCreatedWithRightNumberOfRooms()
        {
            //Arrange

            //Build the test museum
            ZornMuseet builder = new ZornMuseet();
            Museum testMuseum = builder.BuildZornMuseet();
            //Get the list of rooms in the museum
            List<Room> listOfRooms = testMuseum.GetListOfRooms();

            //Act
            int numberOfRooms = listOfRooms.Count;
            int rightNumberOfRooms = 4;
            
            //Assert
            Assert.Equal(rightNumberOfRooms, numberOfRooms);

        }
    }
}
