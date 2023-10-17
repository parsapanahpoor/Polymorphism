namespace Polymorphism;

internal class Program
{
    static void Main(string[] args)
    {
        //Correct
        Animal cat = new Cat();
        cat.Sound();//Print "General Sound"

        //Correct
        Dog dog = new Dog();
        dog.Sound();//Print "General Sound" , "Hop Hop"

        //Incorrect
        //Cat cat = new Animal();
        //Dog dog = new Animal();

        Console.ReadKey();
    }
}

public class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("General Sound");
    }
}

public class Cat : Animal
{
    public void Sound()
    {
        Console.WriteLine("Mio Mio");
    }
}

public class Dog : Animal
{
    public override void Sound()
    {
        base.Sound();
        Console.WriteLine("Hop Hop");
    }
}