namespace OOPS.Abstraction
{
    public abstract class Animalcs
    {
        public abstract void makeSound();

        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
    }

    class Dog : Animalcs
    {
        public override void makeSound()
        {
            Console.WriteLine("Dog is barking");
        }
    }
}
