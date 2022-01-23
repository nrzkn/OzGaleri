using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzGaleri
{
    public class DataTransport
    {
        public List<Vehicles> GetVehiclesList()
        {
            return new List<Vehicles>()
            {
                new Vehicles {CarBrand = "BMW", GearSize = 5, GearType = false},
                new Vehicles {CarBrand = "Mercedes", GearSize = 6, GearType = true},
                new Vehicles {CarBrand = "Fiat", GearSize = 7, GearType = false},
                new Vehicles {CarBrand = "Tofas", GearSize = 5, GearType = true},
                new Vehicles {CarBrand = "BMW", GearSize = 6, GearType = true},
                new Vehicles {CarBrand = "Masserati", GearSize = 7, GearType = true},
                new Vehicles {CarBrand = "Ferrari", GearSize = 6, GearType = true},
                new Vehicles {CarBrand = "BMW", GearSize = 6, GearType = false},
            };
        }

        public List<Vehicles> GetVehiclesByName(string name)
        {
            var vehicles = GetVehiclesList();

            return vehicles.Where(x => x.CarBrand == name).ToList();
        }

        public List<Vehicles> GetVehiclesByGearSize(int gearSize, List<Vehicles> filteredVehicles)
        {
            return filteredVehicles.Where(x => x.GearSize == gearSize).ToList();
        }

        public string TestDrive(Vehicles model)
        {
            return $"{model.CarBrand} markasi ile test surusu basliyor!!";
        }
    }
}
