using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildInterface
{
    //an app for transportation machines
    //build an interface & create classes that will implement an interface
    interface IAutomobile
    {
        string LicensePlate { get; }
        double Speed { get; }
        int Wheels { get; }
        void Honk();
    }
    abstract class Vehicle
    {
        public string LicensePlate
        { get; private set;}

        public double Speed
        { get; protected set;}

        public int Wheels
        { get; protected set;}

        public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = "QDMSZZ4P";
        }
        //SpeedUp() is the base class (superclass) (virtual)method that can be inherited and can be modified in an inherited method.
        public virtual void SpeedUp()
        {
            Speed += 5;
        }

        public virtual void SlowDown()
        {
            Speed -= 5;
        }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
        /*Describe() method is designed only to be a base method for other methods.
    The method will be modified by a derived class since it has a missing or incomplete implementation.*/
        public abstract string Describe();
    }
    class Sedan : Vehicle, IAutomobile
    {
        //The constructor Sedan is called whenever an instance of a class is created.
        //A special syntax 'base' calls the superclass constructor 
        public Sedan(double speed) : base(speed)
        {
            Wheels = 4;
        }
        public override string Describe()
        {
            return $"\nThis Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";

        }
    }

    class Truck : Vehicle, IAutomobile
    {
        public double Weight
        { get;}

        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }
        public override string Describe()
        {
            return $"\nThis Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";
        }

    }

    class Bicycle : Vehicle
    {

        public Bicycle(double speed) : base(speed)
        {
            Wheels = 2;
        }
        //SpeedUp() is the base class (superclass)(override) method that was inherited and modified in an inherited method.
        public override void SpeedUp()
        {
            Speed += 5;

            if (Speed > 15)
            {
                Speed = 15;
            }
        }

        public override void SlowDown()
        {
            Speed -= 5;

            if (Speed < 0)
            {
                Speed = 0;
            }
        }
        // This overridden method is a complete implementation of an abstract method from (base) the Vehicle class.
        public override string Describe()
        {
            return $"\nThis bicycle is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}.";

        }
    }
    class BuildInterface
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan(60);
            Console.WriteLine(s.Describe());
            Truck t = new Truck(45, 500);
            Console.WriteLine(t.Describe());
            Bicycle b = new Bicycle(10);
            Console.WriteLine(b.Describe());
            Console.ReadLine();
        }
    }
}
