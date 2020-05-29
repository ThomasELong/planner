using System;
using System.Collections.Generic;

namespace Planner
{

    public class City
    {
    private string _cityName;
    public string mayor { get; set; }
    public int yearEstablished { get; set; }
    
    private List<Building> _buildings = new List<Building>();
    public void addBuilding(Building newBuilding)
    {
        _buildings.Add(newBuilding);
    }

    public City(string cityName)
    {
        _cityName = cityName;
    }

    public List<Planner.Building> Buildings()
    {
        return _buildings;
    }


    }
};

