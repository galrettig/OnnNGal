using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class ElectricVehicle : Vehicle
    {
        
        private float m_batteryCapacity, m_currentBatteryLife;


        public ElectricVehicle(string i_modelName, string i_licenseNumber, float i_remainingEnergyPercentage, List<Wheels> i_wheels,
             float i_BatteryCapacity, float i_currentBatteryLife) : base(i_modelName, i_licenseNumber, i_remainingEnergyPercentage, i_wheels)
        {
            
            m_batteryCapacity = i_BatteryCapacity;
            m_currentBatteryLife = i_currentBatteryLife;
        }

        public bool rechargeBattery(float i_batteryToAdd)
        {
            bool underCapacity = m_currentBatteryLife + i_batteryToAdd <= m_batteryCapacity;
           
            if (underCapacity)
            {
                m_currentBatteryLife += i_batteryToAdd;
                base.updateEnergyPercentage(m_currentBatteryLife, m_batteryCapacity);
            }
            else
            {
                throw new Exception("couldn't recharge more then the maximum amount");
            }
            
            return underCapacity;
        }

        public float getBatteryCapacity() { return m_batteryCapacity; }
        public float getCurrentBattery() { return m_currentBatteryLife; }
    }
}
