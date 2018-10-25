using System;
using System.Collections.Generic;
using System.Text;

namespace TheSimsConsoleEdition
{
    class Room
    {
        private string roomName;
        private List<Room> ConnectedRooms = new List<Room>();
        private List<SimObject> Contents = new List<SimObject>();

        public Room(string roomName)
        {
            this.roomName = roomName;
        }
        public Room(string roomName, Room connectedRoom)
        {
            this.roomName = roomName;
            ConnectedRooms.Add(connectedRoom);
        }

        public int getPersonCountInRoom()
        {
            int count = 0;
            foreach (SimObject so in Contents)
                if (so.GetType() == new Actor().GetType())
                    count++;
            return count;
        }
        public void addConnection(Room newConnection)
        {
            ConnectedRooms.Add(newConnection);
        }
        public string getName()
        {
            return roomName;
        }
        public override string ToString()
        {
            string returnString = "You are looking in the " + getName() + ".\nIt connects to these rooms:\n";
            foreach (Room r in ConnectedRooms)
                returnString += r.getName() + "\n";
            returnString += "In this room there is:\n";
            foreach (SimObject so in Contents)
                returnString += so.getName() + "\n";
            return returnString;
        }
    }
}
