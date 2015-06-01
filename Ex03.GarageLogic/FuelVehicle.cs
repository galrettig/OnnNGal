using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public enum FuelType
    {
        Soler,
        Octan95,
        Octan96,
        Octan98
    }

    class FuelVehicle : Vehicle
    {
        private FuelType m_fuelType;
        private float m_fuelTankCapacity, m_currentAmountOfFuel;


        public FuelVehicle(string i_modelName, string i_licenseNumber, List<Wheels> i_wheels,
            FuelType i_fuelType, float i_fuelTankCapacity, float i_currentAmountOfFuel) : base(i_modelName, i_licenseNumber, 0, i_wheels)
        {
            m_fuelType = i_fuelType;
            m_fuelTankCapacity = i_fuelTankCapacity;
            m_currentAmountOfFuel = i_currentAmountOfFuel;
            base.updateEnergyPercentage(m_currentAmountOfFuel, i_fuelTankCapacity);
        }
        
        public bool fuelUpVehicle(float i_fuelToAdd, FuelType i_fuelType)
        {
            bool underCapacity = m_currentAmountOfFuel + i_fuelToAdd <= m_fuelTankCapacity;
            bool isSameFuelType = i_fuelType == m_fuelType;

            if (underCapacity && isSameFuelType)
            {
                m_currentAmountOfFuel += i_fuelToAdd;
                base.updateEnergyPercentage(m_currentAmountOfFuel, m_fuelTankCapacity);
            }

            if (!isSameFuelType)
            {
                throw new Exception("Not same Fuel Type.");
            }

            return underCapacity && isSameFuelType;
        }

        public FuelType getFuelType() { return m_fuelType; }
        public float getTankCapacity() { return m_fuelTankCapacity; }
        public float getCurrentTank() { return m_currentAmountOfFuel; }
    }

    // Vehicle
}
