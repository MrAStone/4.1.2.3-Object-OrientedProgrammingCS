using System.Security;

namespace _4._1._2._3_Object_OrientedProgrammingCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            regularPolygon hexagon = new regularPolygon(6, 12);
            Console.WriteLine(hexagon.Area());
            Circle circle = new Circle(10);
            Console.WriteLine(circle.Area());
            Triangle triangle = new Triangle(10, 5);
            Console.WriteLine(triangle.Area());

            // instantiate the derived classes
            Dog dog = new Dog();
            dog.Name = "Buddy";
            Cat cat = new Cat();
            cat.Name = "Whiskers";
            Console.WriteLine($"Dog's name: {dog.Name}");
            dog.Fetch();
            dog.animalSound();


            Person owner = new Person("Bob","Smith","bob@home.com","01234 576984","1 Testerly Street");
            owner.AddPet(dog);
            owner.AddPet(cat);
            owner.MakeAllSounds(); // Polymorphism - same method call with different implementations

        }
    }
}
abstract class Shape
{

    public abstract double Area();
}
class regularPolygon : Shape
{
    private int numSides;
    private int sideLength;
    public regularPolygon(int numSides, int sideLength)
    {
        this.numSides = numSides;
        this.sideLength = sideLength;
    }
    public override double Area()
    {
        return (numSides * sideLength * sideLength) / (4 * Math.Tan(Math.PI / numSides));
    }
}
class Circle : Shape
{
    private int radius;
    public Circle(int radius)
    {
        this.radius = radius;
    }
    public override double Area()
    {
        return Math.PI * radius * radius;
    }
}
class Triangle : Shape
{
    private int baseLength;
    private int height;
    public Triangle(int baseLength, int height)
    {
        this.baseLength = baseLength;
        this.height = height;
    }
    public override double Area()
    {
        return 0.5 * baseLength * height;
    }
}
public class Animal // base class (parent) 
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public virtual void animalSound() // virtual method for polymorphism
    {
        Console.WriteLine("The animal makes a sound");
    }
    
}
public class Dog : Animal // derived class (child)
{
    public void Fetch()
    {
        Console.WriteLine("Fetching is fun.");
    }
    public override void animalSound() // override method for polymorphism
    {
        Console.WriteLine("Woof!");
    }
}
public class Cat : Animal // derived class (child)
{
    public void Scratch()
    {
        Console.WriteLine("I am a cat, I scratch.");
    }
    public override void animalSound() // override method for polymorphism
    {
        Console.WriteLine("Meow!");
    }
}
public class Person // Class (parent)
{
    private string name;
    private string surname;
    private string email;
    private string phoneNumber;
    private string address;

    private List<Animal> pets = new List<Animal>(); // composition - Person has a list of pets

    public void AddPet(Animal pet) //aggregation - add external object to the list
    {
        pets.Add(pet);
    }
    public void MakeAllSounds()
    {
        foreach (Animal pet in pets)
        {
            pet.animalSound();
        }
    }

    public Person(string name, string surname, string email, string phoneNumber, string address)
    {
        this.name = name;
        this.surname = surname;
        this.email = email;
        this.phoneNumber = phoneNumber;
        this.address = address;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public string Surname
    {
        get { return surname; }
        set { surname = value; }
    }
    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    public string PhoneNumber
    {
        get { return phoneNumber; }
        set { phoneNumber = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
    public string FullName()
    {
        return Name + " " + Surname;
    }
}