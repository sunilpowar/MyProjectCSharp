using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    public class BookB
    {
        private int _id;
        private string _bookName;


        public int Id     //Id is a property
        {
            set
            {
                if (value < 0)   //If given value is a Invalid
                    throw new Exception("The Book Id is not Valid");
                this._id = value;   //Access of _id to value
            }

            get   //Get method access the value of Set method and return to main variable
            {
                return this._id;
            }
        }
        public string BookName   //Set marhod take an argumets and set the values
        {
            set
            {
                if (string.IsNullOrEmpty(value))  //If given value is a Invalid
                    throw new Exception("The Book Name is not null or empty");
                this._bookName = value;   //Access of _id to Id
            }

            get   //Get method access the value of Set method and return to main variable
            {
                return this._bookName;
            }
        }

        internal class SetterAndGetter
        {
            public static void Main()
            {
                BookB B1 = new BookB();
                B1.Id = 10;
                B1.BookName = "C# Tutorial";

                Console.WriteLine("Book id is {0}", B1.Id);
                Console.WriteLine("Book Name is {0}", B1.BookName);


                Console.ReadKey();
            }
        }
    }
}
