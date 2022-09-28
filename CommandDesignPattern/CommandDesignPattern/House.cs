using System.Collections.Generic;

namespace CommandDesignPattern
{
    internal class House
    {
       internal List<Room> rooms;
        public House()
        {
            rooms = new List<Room>();
        }
        public void AddRooms(Room room) { 
             
        rooms.Add(room);
        }
    }
}
