using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Example
{
    class Book
    {
        private int _id;
        private string _bookName;
        private int _noOfPages = 500;

        public void SetId(int Id)    //Set marhod take an argumets and set the values
        {
            if (Id < 0)   //If given value is a Invalid
                throw new Exception("The Book Id is not Valid");
            this._id = Id;   //Access of _id to Id
        }
        public int GetId()   //Get method access the value of Set method and return to main variable
        {
            return this._id;
        }
        public void SetBookName(string BookName)   //Set marhod take an argumets and set the values
        {
            if (string.IsNullOrEmpty(BookName))   //If given name is a null or invalid
                throw new Exception("The Book name is not Valid");
            this._bookName = BookName;       //Access of _bookName to BookName
        }
        public string GetBooKName()    //Get method access the value of Set method and return to main variable
        {
            return this._bookName;
        }
        public void SetNoOfPages(int NoOfPages)     //Set marhod take an argumets and set the values
        {
            if (NoOfPages < 0)       //If given value is a Invalid
                throw new Exception("The Book Id is not Valid");
            this._noOfPages = NoOfPages;      //Access of _noOfPages to NoOfPages
        }
        public int GetNoOfPages()   //Get method access the value of Set method and return to main variable
        {
            return this._noOfPages;
        }
    }
    internal class SetterAndGetter
    {
        public static void Main()
        {
            Book B = new Book();
            B.SetId(10);
            B.SetBookName("C# Tutorial");


            Console.WriteLine("Book id is {0}", B.GetId());
            Console.WriteLine("Book Name is {0}", B.GetBooKName());
            Console.WriteLine("Book Pages are {0}", B.GetNoOfPages());

            Console.ReadKey();
        }
    }
}
