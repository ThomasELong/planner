using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building numberOne = new Building("512 8th Avenue")
            {
                Stories = 3,
                Width = 45.5,
                Depth = 30.0,
            };
            numberOne.Purchase("Joe Johnson");
            Building numberTwo = new Building("634 8th Avenue")
            {
                Stories = 5,
                Width = 30.0,
                Depth = 27.75,
            };
            numberTwo.Purchase("Lena Long");

            Building numberThree = new Building("818 8th Avenue")
            {
                Stories = 2,
                Width = 75.0,
                Depth = 145.25,
            };
            numberThree.Purchase("Derek Buckley");

            
            City Megalopolis = new City("Megalopolis");

            Megalopolis.addBuilding(numberOne);
            Megalopolis.addBuilding(numberTwo);
            Megalopolis.addBuilding(numberThree);

            foreach (Building building in Megalopolis.Buildings()) {
                building.BuildingReport();
            };
            
        }
    }
}
