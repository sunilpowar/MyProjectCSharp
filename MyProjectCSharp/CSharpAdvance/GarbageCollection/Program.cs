using System;


namespace GarbageCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long mem1 = GC.GetTotalMemory(false);
            {
                //Allocate an Array and make it unreachable.
                int[] values = new int[50000];
                values = null; 
            }
            long mem2 = GC.GetTotalMemory(false);
            {
                GC.Collect();
            }
            long mem3 = GC.GetTotalMemory(false);
            {
                Console.WriteLine(mem1); //"Memory consume 1 is : "
                Console.WriteLine(mem2);
                Console.WriteLine(mem3);
            }

            Console.WriteLine("-------------");

            long bytes1 = GC.GetTotalMemory(false); //Get memory in bytes

            byte[] memory = new byte[1000 * 100 * 10];  //Ten Million Bytes
            memory[0] = 1; //Set memory (prevent allocation from being optimized out)
                           
            long bytes2 = GC.GetTotalMemory(false);  //Get memory
            long bytes3 = GC.GetTotalMemory(true);   //get memory

            Console.WriteLine(bytes1);
            Console.WriteLine(bytes2);
            Console.WriteLine(bytes2 - bytes1);  //Write difference
            Console.WriteLine(bytes3);
            Console.WriteLine(bytes3 - bytes2);  //Write difference
            Console.ReadLine();
        }
    }
}

//Output :
//30028
//230060
//22012
//------------
//38396       Total memory of Program using
//1038428     My Current memory allocation
//1000032     Remaining Memory
//1029492     Garbage Collection
//- 8936      Difference
