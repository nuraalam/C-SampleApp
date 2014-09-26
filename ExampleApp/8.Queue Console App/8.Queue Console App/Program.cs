using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Queue_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> aQueue=new Queue<int>();
            aQueue.Enqueue(100);
            aQueue.Enqueue(200);
            aQueue.Enqueue(300);
            aQueue.Enqueue(400);
            foreach (int aItem in aQueue)
            {
               Console.Write(" "+aItem);
               // Console.ReadLine();
            }
            Console.ReadKey();
        }
    }
}
