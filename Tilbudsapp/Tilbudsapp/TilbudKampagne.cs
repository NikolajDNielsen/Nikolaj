using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tilbudsapp
{
    class TilbudKampagne : IWebUri
    {

        public int Fk_kampagne_ID { get; set; }

        public int Fk_tilbud { get; set; }


        public TilbudKampagne(int fkKampagneId, int fkTilbud)
        {
            Fk_kampagne_ID = fkKampagneId;
            Fk_tilbud = fkTilbud;
        }

    
        public TilbudKampagne()
        {
            ResourceUri = "TilbudKampagnes";
            VerboseName = "TilbudKampagne";

        }

        public string ResourceUri { get; }
        public string VerboseName { get; }
    }
}



