using System;
using System.Collections.Generic;
using System.Linq;

namespace OzGaleri
{
    public class Program
    {
        static void Main(string[] args)
        {
            DataTransport getData = new DataTransport();
            Console.WriteLine("Hosgeldiniz! Secmek Istediginiz Araba Modelini Lutfen Listede Seciniz : ");
            var allVehiclesList = getData.GetVehiclesList();

            foreach (var item in allVehiclesList)
            {
                Console.WriteLine(string.Format("Aracin Markasi {0}", item.CarBrand));
            }

            var marka = Console.ReadLine();
            Console.WriteLine($"Siz bu markayi sectiniz: {marka}");
            var result = getData.GetVehiclesByName(marka).ToList();

            if (result.Count > 1)
            {
                Console.WriteLine($"{marka} model aracimdan {result.Count} adet bulunmaktadir. Bunlar :");
                foreach (var item in result)
                {
                    Console.WriteLine($"Marka : {item.CarBrand}, Vites : {item.GearSize}");
                }

                Console.Write("Lutfen Vites Sayinizi Seciniz: ");
                var vitesSayisi = Console.ReadLine();
                var secondResult = getData.GetVehiclesByGearSize(Convert.ToInt32(vitesSayisi), result);

                if (secondResult.Count > 1)
                {
                    Console.WriteLine($"{marka} model aracimdan {vitesSayisi} vitesli olarak {secondResult.Count} adet bulunmaktadir. Bunlar :");
                    foreach (var item in secondResult)
                    {
                        Console.WriteLine($"Marka : {item.CarBrand}, Vites : {item.GearSize}, Vites Turu : {(item.GearType ? "Otomatik" : "Manuel")}");
                    }

                    Console.Write("Vites turunu seciniz: [0] - Otomatik & [M] - Manuel");
                    var vitesTuru = Console.ReadLine();
                    var lastResult = secondResult.Where(x => x.GearType == (vitesTuru == "O" ? true : false)).First();
                    Console.WriteLine(getData.TestDrive(lastResult));
                }
                else
                {
                    Console.WriteLine(getData.TestDrive(secondResult.First()));
                }
            }
            else if (!result.Any())
            {
                Console.WriteLine("Boyle Bir Modelimiz Bulunmamaktadir!");
                Console.WriteLine("Size Baska Modellerde Yardimci Olabiliriz!");
            }
            else
            {
                Console.WriteLine(getData.TestDrive(result.First()));
            }

            Console.ReadLine();
        }
    }
}
