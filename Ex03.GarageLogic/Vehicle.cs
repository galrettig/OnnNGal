using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Vehicle
    {
        private string m_modelName,
            m_licenseNumber;
        private float m_remainingEnergyPercentage;//NEEDS TO BE UPDATE ON EACH FUELUP
        private List<Wheels> m_wheels;

        public Vehicle(string i_modelName, string i_licenseNumber, float i_remainingEnergyPercentage, List<Wheels> i_wheels)
        {
            m_modelName = i_modelName;
            m_licenseNumber = i_licenseNumber;
            RemainingEnergyPercentage = i_remainingEnergyPercentage;//current / max * 100
            m_wheels = i_wheels;
        }

        public float RemainingEnergyPercentage
        {
            get
            {
                return m_remainingEnergyPercentage;
            }

            set
            {
                m_remainingEnergyPercentage = value;
            }
        }

        public string getModelName() { return m_modelName; }
        public string getLicenseNumber() { return m_licenseNumber; }

        
        public bool addPressureToAllWheels(float i_pressureToAdd)
        {
            bool presssureAddedToAllWheels = true;
            foreach(Wheels wheel in m_wheels)
            {
                presssureAddedToAllWheels = presssureAddedToAllWheels && wheel.addPressureToWheel(i_pressureToAdd);
            }

            return presssureAddedToAllWheels;
        }

        public void updateEnergyPercentage(float i_current, float i_max)
        {
            this.m_remainingEnergyPercentage = (i_current / i_max) * 100;
        }

        
        public static List<Wheels> createWheels(string i_WheelManufactureName, float i_currentAirPressure, float i_maximalAirPressure, int amountOfWheels)
        {
            List<Wheels> createdWheels = new List<Wheels>();
            for(int i = 0; i < amountOfWheels; i++)
            {
                createdWheels.Add(new Wheels(i_WheelManufactureName, i_currentAirPressure, i_maximalAirPressure));
            }
            return createdWheels;
        }


    }
}
