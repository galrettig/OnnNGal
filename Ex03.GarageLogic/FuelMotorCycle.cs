using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    enum LicenseType { A, A2, AB, B1 };
    class FuelMotorCycle : FuelVehicle
    {
        private LicenseType m_licenseType;
        private int m_engineVolume;

        public FuelMotorCycle(string i_modelName, string i_licenseNumber, string i_wheelManafacture, float i_currentAirPressure, float i_currentAmountOfFuel,
            LicenseType i_licenseType, int i_engineVolmune) : base(i_modelName, i_licenseNumber, Vehicle.createWheels(i_wheelManafacture, i_currentAirPressure, 34, 2), FuelType.Octan98, 8, 0)
        {
            m_licenseType = i_licenseType;
            m_engineVolume = i_engineVolmune;
        }


        public LicenseType getLicenseType() { return m_licenseType; }
        public int getEngineVolume() { return m_engineVolume; }
    }

    
}
