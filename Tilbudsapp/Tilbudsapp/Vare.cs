﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tilbudsapp
{
    class Vare : IWebUri
    {

        public int Vare_ID { get; set; }
        public string Navn { get; set; }

        public string ResourceUri { get; }
        public string VerboseName { get; }

        public Vare(string navn) :this()
        {

            Navn = navn;

        }

        public Vare()
        {
            ResourceUri = "Vares";
            VerboseName = "Vare";
        }

    }
}
