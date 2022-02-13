namespace BasicLearning {
  class Student {
    public int StudentId { get; set; }
    public String StudentName { get; set; }
    public int Age { get; set; }
  } 

  public class Program {
    public static void Main(string[] args){
      string[] names = { "Bill", "Steve", "James", "Mohan" };

      var myLinqQuery = from name in names
                        where name.Contains('a')
                        select name;

      foreach(var name in myLinqQuery)
        Console.Write(name + " ");
    }
  }
}
