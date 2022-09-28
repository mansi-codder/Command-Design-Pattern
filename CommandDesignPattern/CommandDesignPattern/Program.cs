using System;
using System.Collections;

namespace CommandDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            House house = new House();

            house.AddRooms(new BedRoom(new SwitchLightsCommand(new Light())));
            house.AddRooms(new LivingRoom(new SwitchLightsCommand(new Light())));
            foreach (var item in house.rooms)
            {
                item.ExecuteCommand();
            }

            BedRoom room = new BedRoom(new SwitchLightsCommand(new Light()));
            room.ExecuteCommand();

        }
    }
    internal class SwitchLightsCommand : ICommand
    {
        private Light light;

        public SwitchLightsCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.SwitchLights();
        }
    }
}
