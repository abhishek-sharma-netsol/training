using System;
using System.IO;


namespace BasicLearning
{

    class Program
    {
        static void Main(string[] args)
        {
            try {
                File.OpenRead("Invalidfile");
            } catch (FileNotFoundException ex) {
                Console.WriteLine(ex.ToString());
            } catch (Exception e){
                Console.WriteLine(e.ToString());
            }
            finally {
                Console.WriteLine("Finally block executed");
            }
            Console.ReadLine();
        }
    }
}