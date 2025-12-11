using OOPS.Constructor;
using OOPS.Heriachaial_Inheritance;
using OOPS.Inheritance;
using OOPS.Multiple_Inheritance;
using System.Security.Cryptography.X509Certificates;

namespace OOPS
{
    internal class Program
    {
        //class Car
        //{
        //    // FIELDS
        //   public string color;
        //    public int model;
        //    public int price;

        //    public Car(string color, int model, int price)
        //    {
        //        this.color = color;
        //        this.model = model;
        //        this.price = price;
        //    }


        //    // METHODS
        //    public void drive()
        //    {
        //        Console.WriteLine("Car is driving");
        //    }
        //}
        static void Main(string[] args)
        {
            // // Creating a new obj 
            // Car thar = new Car("black",2025,180000);
            // /*
            // thar.color = "black";
            // thar.model = 2022;
            // thar.price = 1800000;
            // */

            // Console.WriteLine(thar.color);
            // Console.WriteLine(thar.price);
            // Console.WriteLine(thar.model);

            //thar.drive();

            // Console.WriteLine();

            // Phone phone = new Phone();
            // phone.price = 18000;
            // phone.color = "red";
            // phone.name = "apple";
            // phone.Msg();
            // Console.WriteLine(phone.price);
            // Console.WriteLine(phone.color);
            // Console.WriteLine(phone.name);

            /*
             * Public Constructor
            parameterized p = new parameterized(21,"Aryan","student");
            Console.WriteLine();

            p.Display();
           

            // private constructor
            parameterized p = parameterized.Create(21, "Aryan", "student");
            p.Display();
           

            CopyConstructor c1 = new CopyConstructor(10);
            CopyConstructor c2  = new CopyConstructor(c1);

            c1.display();
            c2.display();
              

           // Static Constructor only runs once

            StaticConstructor s = new StaticConstructor();
            StaticConstructor s1 = new StaticConstructor();
            StaticConstructor s2 = new StaticConstructor();
            

            Encapsulation es = new Encapsulation();
            es.setName("Aryan");
            Console.WriteLine(es.getName());
            

            Singleinheritance st = new Singleinheritance();
            st.display();
            
            Child c1 = new Child();
            c1.display(); // parent method called
            c1.displayMsg(); // child class method
           

            BaseClasscalling2 bc = new BaseClasscalling2();
             
              
            Dog d = new Dog();
            d.breathe();
            */

            Cat c1 = new Cat();
            c1.breathe();
            c1.CatBreathe();


        }
    }
}
