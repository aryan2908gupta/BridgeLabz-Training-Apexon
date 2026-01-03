using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderDesign
{
    internal interface IHouseBuilder
    {
        void AddRooms(int count);
        void AddKitchen();
        void AddBathroom();
        void AddGarage();
        House Build();
    }
}

// Builder