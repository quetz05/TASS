using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TASS
{
    class Program
    {
        static void Main(string[] args)
        {
            String quetzKey = "p8tpyrde4q9angm2zbvgqccxycaw6jsz";
            String realm = "Darkmoon Faire";
            String guild = "Redanian Inquisition";

            WoWDataParser wdp = new WoWDataParser(quetzKey);

            wdp.printMembersItemLevel(realm, guild);

            Console.ReadKey();

        }
    }
}
