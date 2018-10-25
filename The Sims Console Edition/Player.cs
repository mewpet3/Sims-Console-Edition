using System;
using System.Collections.Generic;
using System.Text;

namespace TheSimsConsoleEdition
{
    class Player
    {
        float money;
        DateTime dateTime;
        Room curRoom;
        public Player(Room startingRoom)
        {
            money = 10000.00f;
            dateTime = new DateTime();
            curRoom = startingRoom;
        }

        public void setRoom(Room newRoom)
        {
            curRoom = newRoom;
        }
        public Room getRoom()
        {
            return curRoom;
        }
        public float getMoney()
        {
            return money;
        }
    }
}
