using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    public class drawing    //Base class 
    {
        public virtual void Draw()
        //virtual is using for redefine draw in Derived classes
        {
            Console.WriteLine("This is just a generic drawing class.");
        }
    }
    public class line : drawing    //Derived class inheriting from base class
    {
        public new void Draw()
        //new keyword using for hiding derived class 
        //overriding keyword override on base class and give output from Derived class  
        {
            Console.WriteLine("This is Line.");
        }
    }
    internal class DiffOveerringAndHidingMethods
    {
        public static void Main()
        {
            drawing obj = new line();
            obj.Draw();

            Console.ReadKey();
        }
    }

}
