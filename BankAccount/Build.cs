using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Build
    {
        protected int _houseNumber;
        protected int _height;
        protected int _numberOfFloors;
        protected int _numberOfApartments;
        protected int _entrances;    

        protected abstract string TypeBuild { get; }
        public int HouseNumber {  get { return _houseNumber; } set {  _houseNumber = value; } }    
        public int Height { get { return _height; } set { _height = value; } }  
        public int NumberOfFloors { get { return _numberOfFloors;} set { _numberOfFloors = value; } }
        public int NumberOfApartments { get { return _numberOfApartments; } set { _numberOfApartments = value; } }
        public int Entrances { get { return _entrances; } set { _entrances = value; } }

    }
}
