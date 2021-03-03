using System;

namespace City_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Streets streets1 = new Streets("Str. Avram Iancu", 13, "Principala");
            Streets streets2 = new Streets("Str. Nicolae Iorga", 5, "Laturalnica");
            Streets streets3 = new Streets("Bd. Lalelelor", 7, "Bulevard");

            Console.WriteLine("Detalii strazi:");
            Console.WriteLine($"#1: {streets1.StreetName}, {streets1.StreetNumber}, {streets1.StreetType}");
            Console.WriteLine($"#2: {streets2.StreetName}, {streets2.StreetNumber}, {streets2.StreetType}");
            Console.WriteLine($"#3: {streets3.StreetName}, {streets3.StreetNumber}, {streets3.StreetType}");

            Buildings building1 = new Buildings("Palatul Culturii", "Cladire Istorica", "34.236, 35 mp");
            Buildings building2 = new Buildings("Liceul de Arte", "Scoala", "279 mp");
            Buildings building3 = new Buildings("Biblioteca Judeteana", "Biblioteca", "205 mp");

            Console.WriteLine("\n");
            Console.WriteLine("Detalii cladiri:");
            Console.WriteLine($"#1: {building1.BuildingName}, {building1.BuildingSurface}, {building1.BuildingType}");
            Console.WriteLine($"#2: {building2.BuildingName}, {building2.BuildingSurface}, {building2.BuildingType}");
            Console.WriteLine($"#3: {building3.BuildingName}, {building3.BuildingSurface}, {building3.BuildingType}");

            Parks park1 = new Parks("Parcul 1 Decembrie", "1784 mp");
            Parks park2 = new Parks("Parcul 22 Decembrie", "1042 mp");

            Console.WriteLine("\n");
            Console.WriteLine("Detalii parcuri:");
            Console.WriteLine($"#1: {park1.ParkName}, {park1.ParkSurface}");
            Console.WriteLine($"#2: {park2.ParkName}, {park2.ParkSurface}");

            Cars car1 = new Cars("Volkswagen", "Touareg", "Black", "BH-92-HUS", 2013);
            Cars car2 = new Cars("Suzuki", "Vitara", "Camo", "BH-34-UYB", 2005);
            Cars car3 = new Cars("Mazda", "CX6", "Navy Blue", "BH-08-IUN", 2017);
            Cars car4 = new Cars("Dacia", "Stepway", "White", "BH-71-KMB", 2018);
            Cars car5 = new Cars("Skoda", "Superb", "Black", "BH-89-CYB", 2016);
            Cars car6 = new Cars("Lamborghini", "Urus", "Black", "BH-16-MBN", 2020);
            Cars car7 = new Cars("Ford", "Fiesta", "Yellow", "BH-33-PSL", 2007);

            Console.WriteLine("\n");
            Console.WriteLine("Detalii masini:");
            Console.WriteLine($"#1: {car1.Brand}, {car1.Model}, {car1.Color}, {car1.Plate}, {car1.Year}");
            Console.WriteLine($"#2: {car2.Brand}, {car2.Model}, {car2.Color}, {car2.Plate}, {car2.Year}");
            Console.WriteLine($"#3: {car3.Brand}, {car3.Model}, {car3.Color}, {car3.Plate}, {car3.Year}");
            Console.WriteLine($"#4: {car4.Brand}, {car4.Model}, {car4.Color}, {car4.Plate}, {car4.Year}");
            Console.WriteLine($"#5: {car5.Brand}, {car5.Model}, {car5.Color}, {car5.Plate}, {car5.Year}");
            Console.WriteLine($"#6: {car6.Brand}, {car6.Model}, {car6.Color}, {car6.Plate}, {car6.Year}");
            Console.WriteLine($"#7: {car7.Brand}, {car7.Model}, {car7.Color}, {car7.Plate}, {car7.Year}");
        }
    }
}
