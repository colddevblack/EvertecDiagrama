using System;

namespace Diagrama
{
   public class Program
    {
        static void Main(string[] args)
        {
            ExecutionClass sample = new ExecutionClass();
            ITechnology technology = sample;
            sample.GetDescription();
            Console.ReadKey();

         
            
        }
    }
}
