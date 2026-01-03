using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderDesign
{
    internal class HouseBuilder : IHouseBuilder
    {
        private House house = new  House();

        public void AddRooms(int count)
        {
            house.Room = count;
        }

        public void AddKitchen()
        {
            house.Kitchen = true;
        }

        public void AddBathroom()
        {
            house.BathRoom = true;
        }

        public void AddGarage()
        {
            house.Garage = true;
        }

        public House Build()
        {
            return house;
        }
    }
}

//Concreate Builder