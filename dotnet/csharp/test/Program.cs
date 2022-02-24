namespace Program {

  abstract class Animal 
  { 
    abstract public void animalSound()
    {
      Console.WriteLine("The animal makes sound");
    }
    
    virtual public void sleep(){
      Console.WriteLine("Zzz");
    }
  }

  class Pig : Animal
  {
    public void animalSound()
    {
      Console.WriteLine("The pig says: wee wee");
    }

    public override void animalSound()
    {
        throw new NotImplementedException();
    }
  
  }

  class Program
  {
    public static void Main(string[] args)
    {
      Animal pig = new Animal();
      Animal ppig = new Pig();
      pig.animalSound();
      ppig.animalSound();
    }
  }
}
