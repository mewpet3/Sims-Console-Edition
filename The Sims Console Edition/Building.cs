using System;
using System.Collections.Generic;
using System.Text;

namespace TheSimsConsoleEdition
{
    class Building
    {
        int roomCount;
        int inhabitants;
        Room entranceRoom;
        List<Room> Rooms = new List<Room>();

        public Building()
        {
            entranceRoom = new Room("Entrance");
            Rooms.Add(entranceRoom);
            roomCount = 1;
        }
        private void RecalculateInhabitance()
        {
            inhabitants = 0;
            foreach (Room r in Rooms)
                inhabitants += r.getPersonCountInRoom();
        }
        public int getInhabitanceCount()
        {
            RecalculateInhabitance();
            return inhabitants;
        }
        public void addRoom(string newRoomName, Room connectedRoom)
        {
            Room newRoom = new Room(newRoomName, connectedRoom);
            Rooms.Add(newRoom);
            connectedRoom.addConnection(newRoom);
            roomCount++;
        }
        public int getRoomCount()
        {
            return roomCount;
        }
        public Room getEntrance()
        {
            return Rooms[0];
        }
    }
}
