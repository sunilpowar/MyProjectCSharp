//using System;
//using System.Reflection;

//namespace Reflection
//{
//    internal class Student
//    {
//        public int StudentID { get; set; }
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public Student ()
//        {
//            this.StudentID = 0;
//            this.Name = String.Empty;
//            this .Age = 0;
//        }
//        public Student(int id, string name, int age)
//        {
//            this.StudentID = id;
//            this.Name = name;
//            this.Age = age;
//        }
//        class Program
//        {
//            static void Main()
//            {
//                Type _type = typeof(Student);
//                System.Reflection.MethodInfo[] methodInfo = _type.GetMethods();
//                System.Reflection.MemberInfo[] memberInfo = _type.GetMembers();
//                System.Reflection.PropertyInfo[] propertyInfo = _type.GetProperties();


//                Console.WriteLine("---------Methods----------");

//                foreach (MethodInfo mi in methodInfo)
//                {
//                    Console.WriteLine(mi.Name);
//                }

//                Console.WriteLine("---------Members----------");

//                foreach (MemberInfo mi in memberInfo)
//                {
//                    Console.WriteLine(mi.Name);
//                }
//                foreach (PropertyInfo pi in propertyInfo)
//                {
//                    Console.WriteLine(pi.Name);
//                }
//                Console.ReadKey();
//            }
//        }
//    }
//}


