using System;

namespace Timurkrasavchik
{


    public class Building
    {

        private int Number { get; set; }

        private int Hight { get; set; }

        private int NumberOfFloors { get; set; }

        private int NumberOfEntrance { get; set; }

        private int NumberOfApartments { get; set; }



        public Building(int number, int hight, int numberOfFloors, int numberOfEntrance, int numberOfApartments)
        {
            this.Number = number;
            this.Hight = hight;
            this.NumberOfFloors = numberOfFloors;
            this.NumberOfEntrance = numberOfEntrance;
            this.NumberOfApartments = numberOfApartments;
        }

        public void ShowBuildInfo()
        {
            Console.WriteLine($"Номер здания:#{Number}");
            Console.WriteLine($"Высота здания:{Hight} М");
            Console.WriteLine($"Количество этажей:{NumberOfFloors}");
            Console.WriteLine($"Количество подъездов:{NumberOfEntrance}");
            Console.WriteLine($"Количество квартир:{NumberOfApartments}");
        }

        public int CalculateHigh()
        {
            int floorhigh = Hight / NumberOfFloors;
            return floorhigh;

        }

        public int CalculateNumberOfApartementInEntrance()
        {
            int apartmentInEntrance = NumberOfApartments / NumberOfEntrance;
            return apartmentInEntrance;

        }

        public int CalculateNumberOfApartementOnFloor()
        {
            int apartmentOfFloor = CalculateNumberOfApartementInEntrance() / NumberOfFloors;
            return apartmentOfFloor;

        }
    }
    class Program
    {
        static void Main()
        {
            Building building = new Building(68,74,512,48,15);

            building.ShowBuildInfo();
            Console.WriteLine($"Высота каждого этажа:{building.CalculateHigh()} М");
            Console.WriteLine($"Количество квартир в подъезде:{building.CalculateNumberOfApartementInEntrance()}");
            Console.WriteLine($"Количество квартир на этаже:{building.CalculateNumberOfApartementOnFloor()}");
            Console.ReadLine();



        }
    }
}
