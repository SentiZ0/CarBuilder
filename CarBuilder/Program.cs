using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bmw = new BMWBrand();
            var audi = new AudiBrand();
            var toyota = new ToyotaBrand();

            var factory = new CarFactory();

            var builders = new List<CarBuilder> { bmw, audi, toyota };

            foreach (var b in builders)
            {
                var c = factory.Build(b);
                Console.WriteLine($"The Car details" +
                    $"\n--------------------------------------" +
                    $"\nBrand: {c.Brand}" +
                    $"\nModelV: {c.Model}" +
                    $"\nColour: {c.Colour}" +
                    $"\nPower: {c.Power}" +
                    $"\nRegistration: {c.Registration}\n\n"
                    );
            }

        }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int Power { get; set; }
        public string Registration { get; set; }
    }

    public abstract class CarBuilder
    {
        protected readonly Car _car = new Car();

        public abstract void SetBrand();
        public abstract void SetModel();
        public abstract void SetColour();
        public abstract void SetPower();
        public abstract void SetRegistration();
        public virtual Car GetCar() => _car;

    }
    
    public class CarFactory
    {
        public Car Build(CarBuilder builder)
        {
            builder.SetBrand();
            builder.SetModel();
            builder.SetColour();
            builder.SetPower();
            builder.SetRegistration();
            return builder.GetCar();
        }
    }

    public class AudiBrand : CarBuilder
    {
        public override void SetBrand()
        {
            _car.Brand = "Audi";
        }

        public override void SetModel()
        {
            _car.Model = "RS6";
        }

        public override void SetColour()
        {
            _car.Colour = "White";
        }

        public override void SetPower()
        {
            _car.Power = 120;
        }

        public override void SetRegistration()
        {
            _car.Registration = "BI CHUJ";
        }
    }

    public class BMWBrand : CarBuilder
    {
        public override void SetBrand()
        {
            _car.Brand = "BMW";
        }

        public override void SetModel()
        {
            _car.Model = "M3";
        }

        public override void SetColour()
        {
            _car.Colour = "Black";
        }

        public override void SetPower()
        {
            _car.Power = 110;
        }

        public override void SetRegistration()
        {
            _car.Registration = "BIA CWEL";
        }
    }

    public class ToyotaBrand : CarBuilder
    {
        public override void SetBrand()
        {
            _car.Brand = "Toyota";
        }

        public override void SetModel()
        {
            _car.Model = "Corolla";
        }

        public override void SetColour()
        {
            _car.Colour = "Red";
        }

        public override void SetPower()
        {
            _car.Power = 100;
        }

        public override void SetRegistration()
        {
            _car.Registration = "BHA KURWA";
        }
        
    }
}