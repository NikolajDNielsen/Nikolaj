using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tilbudsapp
{
    class Kaede : IWebUri
    {

        public int Kaede_ID { get; set; }
        public string Navn { get; set; }
        public string ResourceUri { get; }
        public string VerboseName { get; }

        public Kaede()
        {
            ResourceUri = "Keade";
            VerboseName = "Keade";
        }

        public Kaede(string navn)
        {
            
            Navn = navn;

        }

       
    }
}
