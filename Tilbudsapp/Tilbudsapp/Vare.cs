using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilbudsapp
{
    class Vare
    {

        public int Vare_ID { get; set; }
        public string Navn { get; set; }


        public Vare(string navn)
        {
            
            Navn = navn;
        }
    }

    
}
