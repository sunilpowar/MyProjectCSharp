using System;
using System.Reflection;

namespace Reflection
{
    internal class MetadataInvestigation
    {
        static void FieldInvestigation(Type t)
        {
            Console.WriteLine("*********Fields**********");
            FieldInfo[] fld = t.GetFields();
            foreach (FieldInfo f in fld)
            {
                Console.WriteLine("-->{0}", f.Name);
            }
        }
        static void MethodInvestigation(Type t)

        {
            Console.WriteLine("*********Methods*********");
            MethodInfo[] mth = t.GetMethods();
            foreach (MethodInfo m in mth)
            {
                Console.WriteLine("-->{0}", m.Name);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the Name to Explore:");
            string typName = Console.ReadLine();
            Type t = Type.GetType(typName);
            FieldInvestigation(t);
            MethodInvestigation(t);

            Console.ReadKey();
        }
    }

}
/*Output:
Enter the Name to Explore:System.Math
********* Fields**********
-->PI
-->E
*********Methods*********
-->Ceiling
-->Floor
-->Round
-->Round
-->Round
-->Round
-->Round
-->Round
-->Round
-->Truncate
-->Truncate
-->IEEERemainder
-->Abs
-->Abs
-->Abs
-->Abs
-->Abs
-->Max
-->Max
-->Max
-->Max
-->Max
-->Max
-->Max
-->Max
-->Max
-->Max
-->Max
-->Min
-->Min
-->Min
-->Min
-->Min
-->Min
-->Min
-->Min
-->Min
-->Min
-->Min
-->Log
-->Sign
-->Sign
-->Sign
-->Sign
-->Sign
-->Sign
-->Sign
-->BigMul
-->DivRem
-->DivRem
-->Acos
-->Asin
-->Atan
-->Atan2
-->Cos
-->Cosh
-->Sin
-->Sinh
-->Tanh
-->Round
-->Sqrt
-->Log10
-->Abs
-->Abs
-->Ceiling
-->Floor
-->Tan
-->Log
-->Exp
-->Pow
-->Equals
-->GetHashCode
-->GetType
-->ToString*/






