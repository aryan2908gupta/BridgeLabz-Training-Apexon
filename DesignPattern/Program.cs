namespace Abstract.NetOptimized;

using DesignPattern.Adapter;
using DesignPattern.BuilderDesign;
using DesignPattern.Factory_Pattern;
using DesignPattern.Prototype;
using DesignPattern.Proxy;
using DesignPattern.Singleton;
using System.Net;
using static System.Console;

/// <summary>
/// Abstract Factory Design Pattern.
/// </summary>
public class Program
{
    public static void Main()
    {
        //        // Create and run the African animal world
        //        var africa = new AnimalWorld<Africa>();
        //        africa.RunFoodChain();

        //        // Create and run the American animal world
        //        var america = new AnimalWorld<America>();
        //        america.RunFoodChain();

        //        // Wait for user input
        //        ReadKey();
        //    }
        //}

        ///// <summary>
        ///// The 'AbstractFactory' interface. 
        ///// </summary>
        //public interface IContinentFactory
        //{
        //    IHerbivore CreateHerbivore();
        //    ICarnivore CreateCarnivore();
        //}

        ///// <summary>
        ///// The 'ConcreteFactory1' class.
        ///// </summary>
        //public class Africa : IContinentFactory
        //{
        //    public IHerbivore CreateHerbivore() => new Wildebeest();

        //    public ICarnivore CreateCarnivore() => new Lion();
        //}

        ///// <summary>
        ///// The 'ConcreteFactory2' class.
        ///// </summary>
        //public class America : IContinentFactory
        //{
        //    public IHerbivore CreateHerbivore() => new Bison();

        //    public ICarnivore CreateCarnivore() => new Wolf();
        //}

        ///// <summary>
        ///// The 'AbstractProductA' interface
        ///// </summary>
        //public interface IHerbivore
        //{
        //}

        ///// <summary>
        ///// The 'AbstractProductB' interface
        ///// </summary>
        //public interface ICarnivore
        //{
        //    void Eat(IHerbivore h);
        //}

        ///// <summary>
        ///// The 'ProductA1' class
        ///// </summary>
        //public class Wildebeest : IHerbivore
        //{
        //}

        ///// <summary>
        ///// The 'ProductB1' class
        ///// </summary>
        //public class Lion : ICarnivore
        //{
        //    // Eat Wildebeest
        //    public void Eat(IHerbivore h) =>
        //        WriteLine($"{GetType().Name} eats {h.GetType().Name}");
        //}

        ///// <summary>
        ///// The 'ProductA2' class
        ///// </summary>
        //public class Bison : IHerbivore
        //{
        //}

        ///// <summary>
        ///// The 'ProductB2' class
        ///// </summary>
        //public class Wolf : ICarnivore
        //{
        //    // Eat Bison
        //    public void Eat(IHerbivore h) =>
        //        WriteLine($"{GetType().Name} eats {h.GetType().Name}");
        //}

        ///// <summary>
        ///// The 'Client' interface
        ///// </summary>
        //public interface IAnimalWorld
        //{
        //    void RunFoodChain();
        //}

        ///// <summary>
        ///// The 'Client' class
        ///// </summary>
        //public class AnimalWorld<T> : IAnimalWorld where T : IContinentFactory, new()
        //{
        //    private readonly IHerbivore herbivore;
        //    private readonly ICarnivore carnivore;

        //    public AnimalWorld()
        //    {
        //        // Create new continent factory
        //        var factory = new T();

        //        // Factory creates carnivores and herbivores
        //        carnivore = factory.CreateCarnivore();
        //        herbivore = factory.CreateHerbivore();
        //    }

        //    /// <summary>
        //    /// Runs the foodchain: carnivores are eating herbivores.
        //    /// </summary>
        //    public void RunFoodChain()
        //    {
        //        carnivore.Eat(herbivore);
        //    }

        /*
        IHouseBuilder builder = new HouseBuilder();

        builder.AddRooms(3);
        builder.AddKitchen();
        builder.AddBathroom();

        House house = builder.Build();
        */

        /*
        IVechiles vehicle = VechileFactory.GetVehicle("Bike");
        vehicle.Drive(); // Calls Bike's Drive()
        */

        /*
         Employee emp1 = new Employee
        {
            Name = "Aryan",
            Address = new Address { City = "Delhi" }
        };

        Employee emp2 = (Employee)emp1.Clone();

        emp2.Name = "Rahul";
        emp2.Address.City = "Mumbai";
        */
        /*
        Singleton obj1 = Singleton.GetInstance();
        Singleton obj2 = Singleton.GetInstance();

        obj1.ShowMessage();

        Console.WriteLine(obj1 == obj2); // True
        */

        /*
        IDevice tv = new TV();
        RemoteControl remote = new BasicRemote(tv);

        remote.On();
        remote.Off();

        IDevice radio = new Radio();
        remote = new BasicRemote(radio);

        remote.On();
        remote.Off();
        */

        /*
        Adaptee adaptee = new Adaptee();
        ITarget target = new Adapter(adaptee);

        target.Request();
        */

        IImage image = new ProxyImage("photo.jpg");

        Console.WriteLine("Image will load now:");
        image.Display();

        Console.WriteLine("\nImage already loaded:");
        image.Display();
    }
}

