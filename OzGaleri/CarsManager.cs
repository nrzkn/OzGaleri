using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzGaleri
{
    public class CarsManager
    {
        private string _brand;
        private readonly int _gearSize;
        private readonly bool _gearType;

        public CarsManager(string brand, int gearSize, bool gearType)
        {
            _brand = brand;
            _gearSize = gearSize;
            _gearType = gearType;
        }

        //public void Gear()
        //{
        //    if (cars.GearType == true)
        //    {
        //        Console.WriteLine("Araç türü -Otomatik- seçildi");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Araç türü -Manuel- seçildi");
        //    }
        //}

        //public void Brand()
        //{
        //    Console.WriteLine(cars.CarBrand);
        //}

        //public void Size()
        //{
        //    if (cars.GearSize < 4)
        //    {
        //        Console.WriteLine("4 vitesten aşağı araba mı olur gardaş!");
        //    }
        //    else if (cars.GearSize == 4)
        //    {
        //        Console.WriteLine("1999 model araba 50 bin gayme");
        //    }
        //    else if (cars.GearSize == 5)
        //    {
        //        Console.WriteLine("İyi aile babası, efendi efendi sür.");
        //    }
        //    else if (cars.GearSize >= 6)
        //    {
        //        Console.WriteLine("Seni Çılgın.");
        //    }
        //    else if (cars.GearSize < 8)
        //    {
        //        Console.WriteLine("Hayalperestsin güzel hayaller peşinde.");
        //    }
        //}
    }
}
