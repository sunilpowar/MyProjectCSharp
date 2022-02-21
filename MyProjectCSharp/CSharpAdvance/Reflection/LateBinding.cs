using System;
using System.Reflection;

namespace Reflection
{
    internal class LateBinding
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("********Assembly Late Binding**********");

                Type t = Type.GetType("TestLib.Utility,TestLib");
                object obj = Activator.CreateInstance(t);
                Console.WriteLine("Create a {0} using late binding", obj);

                MethodInfo mth = t.GetMethod("Test");
                mth.Invoke(obj, null);
                Console.WriteLine("Method Invoked");
            }
            catch
            {
                Console.WriteLine("Can't Create Assembly Instance");
            }
            Console.ReadKey();
        }
    }
}
