using System;
using Xunit;
using System.Collections.Generic;

namespace EnNattPaMuseet.test
{
    public class TestOmodernaMuseet
    {
        [Fact]
        public void CheckIfMuseumOneIsCreatedWithRightNumberOfRooms()
        {
            //Arrange

            //Build the test museum
            OmodernaMuseet builder = new OmodernaMuseet();
            Museum testMuseum = builder.BuildOmodernaMuseet();
            //Get the list of rooms in the museum
            List<Room> listOfRooms = testMuseum.GetListOfRooms();

            //Act
            int numberOfRooms = listOfRooms.Count;
            
            //Assert
            Assert.Equal(8, numberOfRooms);

        }
    }
}
