using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Car
    {
        // attributes
        private string _make;
        private string _model;
        private int _currentSpeed;
        private double _engineSize;




        public Car()
        {
        }


        public Car(string m, string f, int c, double n)
        {
            this._make = m;
            this._model = f;
            this._currentSpeed = c;
            this._engineSize = n;

        }


        public string Make
        {
            get
            {
                return _make;
            }
            set
            {
                _make = value;
            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                _model = value;
            }
        }
        public int Speed
        {
            get
            {
                return _currentSpeed;
            }
            set
            {
                _currentSpeed = value;
            }
        }
        public double Size
        {
            get
            {
                return _engineSize;
            }
            set
            {
                _engineSize = value;
            }
        }

        public override string ToString()
        {
            return "This car is a " + Make + " " + Model + " With a " + Size + "l engine going " + Speed + "km/h";
        }
        public string Accelerate()
        {
            Speed = Speed + 10;
            return "Acceleration speed is: "+ Speed;
        }
        public string DisplayInfo()
        {
            return "Make:  " + Make + " Model: " + Model + " Speed: " + Speed + " Size:  " + Size;

        }

    }
}
