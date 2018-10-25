using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
                                                                                        
namespace TheSimsConsoleEdition
{
    class Game
    {
        bool paused;
        Timer t;
        Player pd;
        List<SimObject> tickingObjects = new List<SimObject>();
        Building curBuilding = new Building();
        public Game()
        {
            t = new Timer(callback, "paused", TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
            curBuilding = new Building();
            pd = new Player(curBuilding.getEntrance());
        }
        private void callback(Object state)
        {
            foreach (SimObject so in tickingObjects)
                so.Tick();
        }
        public void pauseTimer()
        {
            t.Change(-1, -1);
            paused = true;
            Console.WriteLine("Game is now paused.");
        }
        public void resumeTimer()
        {
            t.Change(TimeSpan.FromSeconds(1), TimeSpan.FromSeconds(1));
            paused = false;
            Console.WriteLine("Game has now resumed.");
        }
        public bool isPaused()
        {
            return paused;
        }
        public string getSurroundings()
        {
            return pd.getRoom().ToString();
        }
        public void newRoom(string newRoomName)
        {
            curBuilding.addRoom(newRoomName, pd.getRoom());
        }
        public Player getPlayer()
        {
            return pd;
        }
        public Building getBuilding()
        {
            return curBuilding;
        }
    }
}
