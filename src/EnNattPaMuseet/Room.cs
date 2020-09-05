using System;
using System.Collections.Generic;

namespace EnNattPaMuseet
{
    public class Room
    {
        
        private string roomName;
        private List<Room> adjoiningRooms = new List<Room>();
        private List<Artwork> artworks = new List<Artwork>();

        public Room(string roomName) {
            this.roomName = roomName;
            List<Room> adjoiningRooms = new List<Room>();
        }

        public void AddAdjoiningRoom(Room adjoiningRoom) {
            adjoiningRooms.Add(adjoiningRoom);
        }

        public void AddArtwork(Artwork artwork) {
            artworks.Add(artwork);
        }

        public string GetRoomName(){
            return roomName;
        }

        public List<Room> GetAdjoiningRooms() {
            return adjoiningRooms;
        }

        public List<Artwork> GetArtworks() {
            return artworks;
        }

    }
}
