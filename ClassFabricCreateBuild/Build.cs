using ClassFabricCreateBuild.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassFabricCreateBuild
{
    public abstract class Build : Identity
    {
        protected static int _counter = 0;
        protected int _houseNumber;
        protected int _height;
        protected int _numberOfFloors;
        protected int _numberOfApartments;
        protected int _entrances;    

        protected abstract string TypeBuild { get; }
        public static int Counter { get { return _counter; } private set { _counter = value; }}    
        public int HouseNumber { get { return _houseNumber; } private set { _houseNumber = Counter; } } 
        public int Height { get { return _height; } set { _height = value; } }  
        public int NumberOfFloors { get { return _numberOfFloors;} set { _numberOfFloors = value; } }
        public int NumberOfApartments { get { return _numberOfApartments; } set { _numberOfApartments = value; } }
        public int Entrances { get { return _entrances; } set { _entrances = value; } }

        protected static int HouseNumberIterator ()
        {
            return _counter += 1;
        }

        public virtual double NumberOfApartmentsOnFloors()
        {
            return NumberOfFloors / NumberOfApartments;
        }
        public virtual double HeightFloor ()
        {
            return Height / NumberOfFloors;
        }

        public virtual string Init()
        {
            return TypeBuild;
        }

        protected Build() 
        {
            ID = Guid.NewGuid();
            Counter = HouseNumberIterator();
            HouseNumber = Counter;
        }

    }
}
