using System;
using Xunit;
using System.Collections.Generic;

namespace EnNattPaMuseet.test
{
    public class TestAdjoiningRoomsOmodernaMuseet
    {
        [Fact]
        public void CheckIfEachRoomHaveOneAdjoiningRoom()
        {
            //Arrange
            //Build the test museum
            OmodernaMuseet builder = new OmodernaMuseet();
            Museum testMuseum = builder.BuildOmodernaMuseet();
            //Get the list of rooms in the museum
            List<Room> listOfRooms = testMuseum.GetListOfRooms();

            //Act
            foreach(var room in listOfRooms) {
                //Get the list of adjoining rooms
                List<Room> adjoiningRooms = room.GetAdjoiningRooms();
                int numberOfAdjoiningRooms = adjoiningRooms.Count;

                //Assert
                //Check that adjoining rooms is greater than zero in each room
                Assert.True(numberOfAdjoiningRooms > 0);
            }
            
        }
    }
}
