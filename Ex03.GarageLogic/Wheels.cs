using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    class Wheels
    {
        private string m_WheelManufactureName;
        private float m_currentAirPressure;
        private float m_maximalAirPressure;

        public float MaximalAirPressure
        {
            get
            {
                return m_maximalAirPressure;
            }

            set
            {
                m_maximalAirPressure = value;
            }
        }

        public float CurrentAirPressure
        {
            get
            {
                return m_currentAirPressure;
            }

            set
            {
                m_currentAirPressure = value;
            }
        }

        public string WheelManufactureName
        {
            get
            {
                return m_WheelManufactureName;
            }

            set
            {
                m_WheelManufactureName = value;
            }
        }

        public Wheels(string i_WheelManufactureName, float i_currentAirPressure, float i_maximalAirPressure)
        {
            CurrentAirPressure = i_currentAirPressure;
            MaximalAirPressure = i_maximalAirPressure;
            WheelManufactureName = i_WheelManufactureName;
        }

        public bool addPressureToWheel(float i_amountOfAirToAdd)
        {
            bool underPressureCapacity = CurrentAirPressure + i_amountOfAirToAdd <= MaximalAirPressure;

            if (underPressureCapacity)
            {
                addPressure(i_amountOfAirToAdd);
                
            }
            else
            {
                throw new Exception("Failed to add pressure to wheel");
            }

            return underPressureCapacity;
        }

        private void addPressure(float i_pressureToAdd)
        {
            this.CurrentAirPressure += i_pressureToAdd;
        }

        
    }
}
