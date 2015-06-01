using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03.GarageLogic
{
    public enum VehicleStatus
    {
        inFix,
        Fixed,
        Paid
    }

    class Garage
    {
        private Dictionary<string, Vehicle> m_mapLicenseToVehicle;
        private Dictionary<string, VehicleStatus> m_mapLicenseToStatus;
        private Dictionary<string, string[]> m_mapLicenseToOwnerDetails;//"211-33-44"==>[OwnerName, OwnerPhone]

        public Garage()
        {
            m_mapLicenseToOwnerDetails = new Dictionary<string, string[]>();
            m_mapLicenseToStatus = new Dictionary<string, VehicleStatus>();
            m_mapLicenseToVehicle = new Dictionary<string, Vehicle>();
        }

        //return false in case that the vehicle already existed true if not
        public bool insertNewVehicle(string i_ownerName, string i_ownerPhone, Vehicle i_vehicle)
        {
            string license = i_vehicle.getLicenseNumber();
            bool notExists = !inGarage(license);
            if (notExists)
            {
                m_mapLicenseToOwnerDetails.Add(license, new string[2] { i_ownerName, i_ownerPhone });
                m_mapLicenseToStatus.Add(license, VehicleStatus.inFix);
                m_mapLicenseToVehicle.Add(license, i_vehicle);
            }
            else
            {
                m_mapLicenseToStatus[license] = VehicleStatus.inFix;
            }
            return notExists;

        }

        

        private bool inGarage(string i_license)
        {
            
            bool allExists = vehicleExists(i_license) && statusExists(i_license) && ownerExists(i_license);

            return allExists;
        }
        private bool vehicleExists(string i_license) { return m_mapLicenseToVehicle.ContainsKey(i_license); }
        private bool statusExists(string i_license) { return m_mapLicenseToStatus.ContainsKey(i_license); }
        private bool ownerExists(string i_license) { return m_mapLicenseToOwnerDetails.ContainsKey(i_license); }


        public List<string> getAllLicenseByFilter(VehicleStatus status)
        {
            //Filtering from the entire dictionary only the values that thier status is what we are asking for
            //moreover since we want to return only the license plates that matches this filter we need to cast it
            //to subDictionary and then to the list of plates we looked for
            Dictionary<string, VehicleStatus> licenses = m_mapLicenseToStatus.Where(container => container.Value == status).ToDictionary(container => container.Key, container => container.Value);
            return licenses.Keys.ToList();

        }

        public List<string> getAllLicenseByFilter()
        {
            return m_mapLicenseToStatus.Keys.ToList();
        }

        public bool fuelUpVehicle(string i_license, FuelType i_fuelType, float i_fuelToAdd)
        {
            bool fuelOperation = false;
            if (inGarage(i_license))
            {
                Vehicle vehicle = m_mapLicenseToVehicle[i_license];
                if (vehicle.GetType() == typeof(FuelVehicle))
                {
                    fuelOperation = ((FuelVehicle)vehicle).fuelUpVehicle(i_fuelToAdd, i_fuelType);
                }
                
            }
            else
            {
                throw new Exception("License doesn't exist!");
            }
            return fuelOperation;
        }

        public bool rechargeVehicle(string i_license, float i_amountToRecharge)
        {
            bool fuelOperation = false;
            if (inGarage(i_license))
            {
                Vehicle vehicle = m_mapLicenseToVehicle[i_license];
                if (vehicle.GetType() == typeof(ElectricVehicle))
                {
                    fuelOperation = ((ElectricVehicle)vehicle).rechargeBattery(i_amountToRecharge);
                }

            }
            else
            {
                throw new Exception("License doesn't exist!");
            }
            return fuelOperation;
        }

    }
}
