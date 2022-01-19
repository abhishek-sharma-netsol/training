using System;

delegate int NumberChanger(int n);
namespace Delegates
{
  class PrintString {
    static FileStream fs;
    static StreamWriter sw;

    public delegate void printString(string s);
    public static void WriteToScreen(string str){
      Console.WriteLine("The String is: {0}", str);
    }

    public static void WritToFile(string s){
      fs = new FileStream("message.txt",FileMode.Append, FileAccess.Write);
    }
  }
  class TestDelegate {
    static int num = 10;
    public static int AddNum(int p){
      num += p;
      return num;
    }
    public static int MultNum(int q){
      num *= q;
      return num;
    }
    public static getNum(){
      return num;
    }
  }

  class Program{
    static void Main(string[] args){
      NumberChanger nc1 = new NumberChanger(AddNum);
      NumberChanger nc2 = new NumberChanger(MultNum);
      
      nc1(25);
      Console.WriteLine("Value of Num: {0}", getNum());
      nc2(5);
      Console.WriteLine("Value of Num: {0}", getNum());
      Console.ReadLine();
    }
  }
}
