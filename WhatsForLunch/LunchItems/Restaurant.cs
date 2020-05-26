using System;
using System.Collections.Generic;
using System.Text;

namespace WhatsForLunch.LunchItems
{
    class Restaurant
    {
        List<string> Names = new List<string>();
        Random rnd = new Random();

        public Restaurant()
        {
            Names.Add("McDonald's");
            Names.Add("Fat Moe's");
            Names.Add("Five Guys");

            string Name = Names[rnd.Next(Names.Count)];
        }
    }
}
