using System;
using System.Collections.Generic;
using System.Text;

namespace Diagrama
{
    public class Dual: Contrato
    {
        public int id { get; set; }
        public string Description { get; set; }

        public void GetDescription()
        {
            Console.WriteLine("GetDescription");
        }


    }
}
