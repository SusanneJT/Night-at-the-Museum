using System;
using System.Collections.Generic;

namespace EnNattPaMuseet
{
    public class Museum
    {
        private string museumName;
        private List<Room> rooms = new List<Room>();

        public Museum(string museumName) {
            this.museumName = museumName;  
        }

        public void AddRoomToList(Room room){
            rooms.Add(room);
        }

        public List<Room> GetListOfRooms() {
            return rooms;
        }

        public string GetMuseumName() {
            return museumName;
        }

    }
}
