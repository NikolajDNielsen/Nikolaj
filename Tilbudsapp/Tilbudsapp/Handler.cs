﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Tilbudsapp
{
    class Handler
    {

        public static void søgetilbud()

        {


            try
            {
                var tildbud = facade.GetListAsync(new Tilbud()).Result;
                var kæde = facade.GetListAsync(new Kaede()).Result;
                var Vare = facade.GetListAsync(new Vare()).Result;


               
                Console.WriteLine("Skriv hele eller dele af varenavnet");
                string søgeord = Console.ReadLine();

                if (søgeord == null)
                {
                    søgeord = "";
                }



                var søgtevare = from v in Vare where (v.Navn.ToLower().Contains(søgeord)) select v;



                var tilbudsliste = from s in søgtevare
                                   join t in tildbud on s.Vare_ID equals t.Fk_Vare_ID
                                   select new { s.Vare_ID, varenavn = s.Navn, t.Fk_Vare_ID, t.Fk_Kaede_ID, t.Pris, t.Slut_Dato, t.Start_Dato };

                // Console.WriteLine(tilbudsliste.First());
                var tilbudslistemedkæde = from t in tilbudsliste
                                          join k in kæde on t.Fk_Kaede_ID equals k.Kaede_ID
                                          where t.Start_Dato < DateTime.Now && t.Slut_Dato > DateTime.Now
                                          select new { t.Pris, t.varenavn, k.Navn, t.Slut_Dato, t.Start_Dato };

                foreach (var tilbud in tilbudslistemedkæde)
                {
                    Console.WriteLine("Varenavn: " + tilbud.varenavn + "\n" + "Pris: " + tilbud.Pris + "\n" + "Butik: " + tilbud.Navn + "\n" + "Fra og Med: " + tilbud.Start_Dato + "\n" + "Til og med: " + tilbud.Slut_Dato + "\n");
                }





            }
            catch (Exception e)
            {
                Console.WriteLine(e + e.Message);
            }

        }

        public static void søgekampagne()
        {
            var tildbud = facade.GetListAsync(new Tilbud()).Result;
            var kæde = facade.GetListAsync(new Kaede()).Result;
            var Vare = facade.GetListAsync(new Vare()).Result;
            var Tilbudkampagne = facade.GetListAsync(new TilbudKampagne()).Result;
            var kampagne = facade.GetListAsync(new Kampagne()).Result;


            Console.WriteLine("Skriv hele eller dele af varenavnet");
            string søgeord = Console.ReadLine();


            if (søgeord == null)
            {
                søgeord = "";
            }

            var søgtevare = from k in kampagne where (k.Navn.ToLower().Contains(søgeord)) select k;

            var tilbudsliste = from k in søgtevare
                               join t in kæde on k.Fk_kaede_ID equals t.Kaede_ID
                               select new { k, t.Kaede_ID,  };









        }
    }
}

