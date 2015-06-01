using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class deleteLater
    {
        public deleteLater()
        {
            Vehicle v = new Vehicle("s", "123", 100, new List<Wheels>());

            /*  if(v.GetType() == typeof(FuelVehicle)){ }
              ((FuelVehicle)v).f()*/

            FuelCar c = new FuelCar("a", "123", "gay", 20, 10, carColor.Black, carDoor.Five);

            List<Vehicle> k = new List<Vehicle>();
            
        }

    }
}
