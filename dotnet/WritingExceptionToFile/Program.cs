using System;
using System.IO;

namespace Uexceptions
{
  class DivByZero : Exception {
    public DivByZero() {
      Console.Write("Exception has occurred define by user : ");
    }
  }

  class Program {
    public double DivisionOperation(double numerator,double denominator) {
      if (denominator == 0)
        throw new DivByZero();
      return numerator / denominator;
    }
    static void Main(string[] args) {
      Program obj = new Program();
      double num = 9, den = 0, quotient;
      try {
        quotient = obj.DivisionOperation(num, den);
        Console.WriteLine("Quotient = {0}", quotient);
      }
      catch (Exception e) {
        string writeText = e.Message;
        File.WriteAllText("errorlog.txt",writeText);
        string readText = File.ReadAllText("errorlog.txt");
        System.Console.WriteLine((readText));
      }
    }
  }
}
