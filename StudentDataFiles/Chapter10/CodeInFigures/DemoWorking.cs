using static System.Console;
class DemoWorking
{
   static void Main()
   {
      Employee bob = new Employee("Bob");
      Dog spot = new Dog("Spot");
      Cat puff = new Cat("Puff");
      WriteLine(bob.Name + " says " + bob.Work());
      WriteLine(spot.Name + " says " + spot.Work());
      WriteLine(puff.Name + " says " + puff.Work());
   }
}
public interface IWorkable
{
   string Work();
}
class Employee : IWorkable
{
   public Employee(string name)
   {
       Name = name;
   }
   public string Name {get; set;}
   public string Work()
   {
      return "I do my job";
   }
}
abstract class Animal : IWorkable
{
   public Animal(string name)
   {
      Name = name;
   }
   public string Name {get; set;}
   public abstract string Work();
}
class Dog : Animal
{
   public Dog(string name) : base(name)
   {
   }
   public override string Work()
   {
      return "I watch the house";
   }
}
class Cat : Animal
{
   public Cat(string name) : base(name)
   {
   }
   public override string Work()
   {
      return "I catch mice";
   }
}
