using System;

namespace Planner
{
public class Building
    {
        private string _designer = "Thomas Long";
        private DateTime _dateConstructed = DateTime.Now;
        private string _address;
        private string _owner;
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double volume {
            get
            { return Width * Depth * (3 * Stories); }
        }
        public Building( string Address ) 
        {
            _address = Address;
        }    
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase( string Owner)
        {
            _owner = Owner;
        }

public void BuildingReport()
{
    Console.WriteLine(this._address);
    Console.WriteLine("--------------");
    Console.WriteLine($"Designed by {this._designer}");
    Console.WriteLine($"Constructed on {this._dateConstructed}");
    Console.WriteLine($"Owned by {this._owner}");
    Console.WriteLine($"{this.volume} cubic meters of space");


}


    }



}
