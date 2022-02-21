using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Annotations
{
    internal class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("Employee class Validation");
            Console.WriteLine("-----------------\n");

            Employee objEmployee = new Employee();

            objEmployee.Name = "Sourabh Powar";
            objEmployee.Age = 23;
            objEmployee.PhoneNumber = "9970965164";
            objEmployee.Email = "sunilpowarsp8468@gmail.com";


            ValidationContext context = new ValidationContext(objEmployee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(objEmployee, context, results, true);

            if (!valid)
            {
                foreach (ValidationResult Totalresult in results)
                {
                    Console.Write("Member Name : {0}", Totalresult.MemberNames.First(), Environment.NewLine);
                    Console.Write("Error Msg : {0}{1}", Totalresult.ErrorMessage, Environment.NewLine);
                }
            }
            else 
            {
                    Console.WriteLine("Name : " + objEmployee.Name + "\n" + "Age : " + objEmployee.Age + "\n" + "PhoneNumber :" + objEmployee.PhoneNumber);

            }
                Console.WriteLine("\nPress any key to Exit");
                Console.ReadKey();
        }
    }
}

