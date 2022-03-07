using System;

namespace ConsoleApp2
{
    class Girl
    {
        //object

        public string name;
        public int age;

        //function with parameter
        public void Task(string car)
        {
            Console.WriteLine("Hello World");
            Console.WriteLine("I am driving " + car);
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            //defining class
            Girl girl = new Girl();
            Girl girl1 = new Girl();

            //setting value to object girl
            girl.name = "Nikita";
            girl.age = 28;

            //setting value to object girl1
            girl1.name = "Rojan";
            girl1.age = 30;
            
            //print object for girl
            Console.WriteLine(girl.name + girl.age);

            Console.WriteLine("I am "+girl.name+". I am "+girl.age+" years old.");
            girl.Task("Toyota");

            //print object for girl1
            Console.WriteLine(girl1.name+ girl1.age);
            girl1.Task("Bike");

            Console.ReadLine();
        }
    }
}
