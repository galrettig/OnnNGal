using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricCar : ElectricVehicle
    {
        private carColor m_carColor;
        private carDoor m_amountOfDoors;

        public ElectricCar(string i_modelName, string i_licenseNumber, string i_wheelManafacture, float i_currentAirPressure, float i_currentBatteryLife,
            carColor i_carColor, carDoor i_amountOfDoors) :
            base(i_modelName, i_licenseNumber, 0, Vehicle.createWheels(i_wheelManafacture, i_currentAirPressure, 31, 4), (float)(2.2), i_currentBatteryLife)
        {
            m_carColor = i_carColor;
            m_amountOfDoors = i_amountOfDoors;
            base.updateEnergyPercentage(i_currentBatteryLife, 31);

        }

        public carColor getCarColor() { return m_carColor; }
        public carDoor getAmountOfDoors() { return m_amountOfDoors; }

    }
}
