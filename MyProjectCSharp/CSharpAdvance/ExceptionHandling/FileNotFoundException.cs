using System;
using System.IO;


namespace ExceptionHandling
{
    internal class TryCatch
    {

        static void Main(string[] args)
        {
            StreamReader strmRdr = null;
            
                try
                {
                    strmRdr = new StreamReader(@"C:\Users\Shree\source\repos\MyProjectCSharp\MyProjectCSharp\ExceptionHandling1\text1.txt");
                    Console.WriteLine(strmRdr.ReadToEnd()); //Read the file to the end \
                    strmRdr.Close(); //After reading close the file
                    Console.ReadKey();
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Please Check your file Name");
                    Console.ReadKey();
                }
                catch (DirectoryNotFoundException)
                {
                    Console.WriteLine("Please give a path where file exactly locate");
                    Console.ReadKey();
                }
                finally       //The Finally block will execute every time
                {
                    DateTime c = Convert.ToDateTime("jik");

                }
            
        }

    } 

}

//Output:

//Please Check your file Name
      //(for wrong File name)

//Please give a path where file exactly locate
    //(for wrong path)


