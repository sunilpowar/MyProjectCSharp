using System;
using System.Reflection;


namespace Reflection
{
    internal class DynamicAssemblyLoading
    {
        static void Main(string[] args)
        {
            Console.Write("Enter External Assembly:");
            string typName = Console.ReadLine();
            try
            {
                Assembly asm = Assembly.Load(typName);
                DisplayAssembly(asm);
            }
            catch
            {
                Console.WriteLine("Can't Load Assembly");
            }
            Console.ReadKey();
        }

        static void DisplayAssembly(Assembly a)
        {
            Console.WriteLine("*******Contents in Assembly********");
            Console.WriteLine("Information:{0}", a.FullName);
            Type[] asm = a.GetTypes();
            foreach (Type tp in asm)
            {
                Console.WriteLine("Type:{0}", tp);
            }
        }
    }
}

    

   