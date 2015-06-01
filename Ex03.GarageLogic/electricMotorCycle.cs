using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    
    class ElectricMotorCycle : ElectricVehicle
    {
        private LicenseType m_licenseType;
        private int m_engineVolume;

        public ElectricMotorCycle(string i_modelName, string i_licenseNumber, string i_wheelManafacture, float i_currentAirPressure, float i_currentAmountOfFuel,
            LicenseType i_licenseType, int i_engineVolmune) : base(i_modelName, i_licenseNumber,0, Vehicle.createWheels(i_wheelManafacture, i_currentAirPressure, 31, 2), (float)1.2, 0)
        {
            m_licenseType = i_licenseType;
            m_engineVolume = i_engineVolmune;
        }


        public LicenseType getLicenseType() { return m_licenseType; }
        public int getEngineVolume() { return m_engineVolume; }
    }
}
