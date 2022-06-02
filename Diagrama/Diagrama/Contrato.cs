using System;
using System.Collections.Generic;
using System.Text;

namespace Diagrama
{
    public class Contrato
    {
       
        public long ContractNumber { get; set; }

        public DateTime SignatureDate { get; set; }

        public bool Process { get; set; }
    }
}
