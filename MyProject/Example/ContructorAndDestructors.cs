namespace MyProject.Example
{
    class BoxB  //Box is a class
    {
        public double l, b, h;   //Member variables
        public double volume()
        //Name of Method   //Parameters
        {
            return (this.l * this.b * this.h);   //Return value Formula
        }
        public BoxB(double la, double br, double hi)   //Constructer for initialise the values
        {
            this.l = la;
            this.b = br;
            this.h = hi;
        }
        ~BoxB()     //Distructer
        {
            Console.WriteLine("The Distructer is Called");
        }


    }
    internal class ContructorAndDestructors     //Main class
    {
        public static void Main()
        {
            BoxB box1 = new BoxB(54, 85, 64);    //box1 is a object

            Console.WriteLine("Volume of box1 is {0}", box1.volume());

            Console.ReadKey();
        }
    }
    
}
