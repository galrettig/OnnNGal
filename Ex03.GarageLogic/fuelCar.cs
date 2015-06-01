using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    enum carColor { Green, Black, White, Red};
    enum carDoor { Two, Three, Four, Five};

    class FuelCar : FuelVehicle
    {
        private carColor m_carColor;
        private carDoor m_amountOfDoors;


        public FuelCar(string i_modelName, string i_licenseNumber, string i_wheelManafacture, float i_currentAirPressure, float i_currentAmountOfFuel,
            carColor i_carColor, carDoor i_amountOfDoors) : 
            base(i_modelName, i_licenseNumber, (Vehicle.createWheels(i_wheelManafacture, i_currentAirPressure, 31, 4)), 
                FuelType.Octan96, 35, i_currentAmountOfFuel)
        {
            m_carColor = i_carColor;
            m_amountOfDoors = i_amountOfDoors;
        }

        public carColor getCarColor() { return m_carColor; }
        public carDoor getAmountOfDoors() { return m_amountOfDoors; }
    }
}
