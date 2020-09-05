using System;
using Xunit;
using System.Collections.Generic;

namespace EnNattPaMuseet.test
{
    public class TestArtworksZornMuseum
    {
        [Fact]
        public void CheckIfEachMuseumHaveExpextedAmountOfArtworks()
        {
            //Arrange

            //Build the test museum
            ZornMuseet builder = new ZornMuseet();
            Museum testMuseum = builder.BuildZornMuseet();
            //Get the list of rooms in the museum
            List<Room> listOfRooms = testMuseum.GetListOfRooms();

            //Act
            int numberOfArtworks = 0;
            foreach(var room in listOfRooms) {
                //Get the list of artworks for each room
                List<Artwork> artworks = room.GetArtworks();
                numberOfArtworks = numberOfArtworks + artworks.Count;
            }
            
            //Assert
            //Check that the total amount of artworks in the museum is 6
            Assert.Equal(6, numberOfArtworks);
        }
    }
}
