using System;

namespace BasicLearning
{
   class Program
   {
     public unsafe void test(){
       int var = 20;
       int *p = &var;
     }
     
     static void Main(string[] args)
     {
       string[] student = new string[3]{"student1", "student2", "student3"};
       foreach(string s in student){
           Console.WriteLine(s);
       }

       // Clears element in an array
       Array.Clear(student, 0, 2);
       foreach(string s in student){
           Console.WriteLine(s);
       }

       // Length of an array
       Console.WriteLine(student.Length);
       // get Index of first occurrence of specified object
       Console.WriteLine(Array.IndexOf(student,"student3"));
     }
   }
}
