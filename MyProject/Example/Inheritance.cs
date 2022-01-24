using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    class Polygon    //Base class 
    {
        public int width, height;    //Member variables of base class
        public void setVlues(int a, int b)
        //Parameters
        {
            this.width = a;     //this is use for implimentation of parameters
            this.height = b;
        }
    }
    class Rectangle : Polygon  //Derived Class is inheriting values from base class
    {
        public int area()
        {                               //Method
            return width * height;     //Retutn Formula
        }
    }
    class Triangle : Polygon  //Derived Class
    {
        public int area()
        {                               //Method
            return width * height / 2;     //Retutn Formula
        }
    }
    internal class Inheritance    //Main class
    {
        public static void Main()
        {
            Rectangle rect = new Rectangle();    //Access the classes to define
            Triangle trgl = new Triangle();

            rect.setVlues(15, 20);     //Inheriting the values from polygon class
            trgl.setVlues(10, 12);

            Console.WriteLine("Rectangle Area = {0}", rect.area());
            Console.WriteLine("Triangle Area = {0}", trgl.area());

            Console.ReadKey();
        }
    }
    
   
}
