using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Truck : FuelVehicle
    {
        private float m_currentWeightCarried;
        private bool m_isCarryingToxic;
        public Truck(string i_modelName, string i_licenseNumber, string i_wheelManafacture, float i_currentAirPressure, float i_currentAmountOfFuel,
            float i_currentWeightCarried, bool i_isCarryingToxic) :
            base(i_modelName, i_licenseNumber, (Vehicle.createWheels(i_wheelManafacture, i_currentAirPressure, 25, 16)),
                FuelType.Soler, 170, i_currentAmountOfFuel)
        {
            base.updateEnergyPercentage(i_currentAmountOfFuel, 170);
            m_currentWeightCarried = i_currentWeightCarried;
            m_isCarryingToxic = i_isCarryingToxic;
        }


        public float getCurrentWeightCarried() { return m_currentWeightCarried; }
        public bool isCarryingToxins() { return m_isCarryingToxic; }
    }
}
