using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
         //Polymorphism allows us to invoke derive class methods through
        //a base class reference during runtime
{
    public class Drawing    //Base class 

    {
        public virtual void Draw()
        //virtual is using for redefine draw in Derived classes
        {
            Console.WriteLine("This is just a generic drawing object.");
        }
    }
    public class Line : Drawing    //Derived class inheriting from base class
    {
        public override void Draw()
        //overriding base class method 
        {
            Console.WriteLine("This is Line.");
        }
    }
    public class Circle : Drawing    //Derived class inheriting from base class
    {
        public override void Draw()
        //overriding base class method
        {
            Console.WriteLine("This is Circle.");
        }
    }
    public class Square : Drawing    //Derived class inheriting from base class
    {
        public override void Draw()
        //overriding base class method
        {
            Console.WriteLine("This is Square.");
        }
    }
    internal class Polymorphism
    {
        public static void Main()
        {
            Drawing[] dObj = new Drawing[4];    //Access the classes to define   
            dObj[0] = new Line();
            dObj[1] = new Circle();
            dObj[2] = new Square();
            dObj[3] = new Drawing();

            foreach (Drawing draw in dObj)   //foreach (Value of collection)
            {
                draw.Draw();
            }
            Console.ReadKey();
        }
    }
    
    
}
