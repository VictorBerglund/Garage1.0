using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_1._0
{
    class Vehicle
    {
        public Vehicle()
        {

        }

        private int regNr;
        public virtual int RegNr
        {
            get { return regNr; }
            set { regNr = value; }
        }

        private string colour;
        public virtual string Colour
        {
            get { return colour; }
            set { colour = value; }
        }

        private int nbrOfSeats;
        public virtual int NbrOFSeats
        {
            get { return nbrOfSeats; }
            set { nbrOfSeats = value; }
        }

        public virtual string Stats()
        {
            return "Registration Number: " + RegNr
                + "\nColour: " + Colour
                + "\nNumber Of Seats" + NbrOFSeats;
        }


    }


    class MotorVehicle : Vehicle
    {
        private string fuelType;
        public virtual string FuelType
        {
            get { return fuelType; }
            set { fuelType = value; }
        }

        private string typOfEngine;
        public virtual string TypOfEngine
        {
            get { return typOfEngine; }
            set { typOfEngine = value; }
        }

        private string typOfModel;
        public virtual string TypOfModel
        {
            get { return typOfModel; }
            set { typOfModel = value; }
        }

        public override string Stats()
        {
            return base.Stats()
            + "\nFuel: " + FuelType
            + "\nEngine: " + TypOfEngine
            + "\nModel: " + TypOfModel;
        }
    }


    class Car : MotorVehicle
    {
        private string brand;
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        private string wheelDrive;
        public string WheelDrive
        {
            get { return wheelDrive; }
            set { wheelDrive = value; }
        }

        public override string Stats()
        {
            return base.Stats()
            + "\nBrand: " + Brand
            + "\nDrive Wheel: " + WheelDrive;
        }
    }


    class Airplane : MotorVehicle
    {
        private int wingSpan;
        public int WingSpan
        {
            get { return wingSpan; }
            set { wingSpan = value; }
        }

        public override string Stats()
        {
            return base.Stats()
            + "\nWing Span: " + WingSpan;
        }
    }


    class Motorcyckle : MotorVehicle
    {
        private int cc;
        public int CC
        {
            get { return cc; }
            set { cc = value; }
        }

        public override string Stats()
        {
            return base.Stats()
            + "\nCC: " + CC;
        }
    }


    class Buss : MotorVehicle
    {
        private int fairPrice;
        public int FairPrice
        {
            get { return fairPrice; }
            set { fairPrice = value; }
        }

        public override string Stats()
        {
            return base.Stats()
            + "\nPrice Of A Fair";
        }
    }


    class Boat : MotorVehicle
    {
        private int length;
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public override string Stats()
        {
            return base.Stats()
            + "\nLength" + Length;
        }
    }


    class Tank
    {
        private int caliber;

        public int Caliber
        {
            get { return caliber; }
            set { caliber = value; }
        }

    }
}