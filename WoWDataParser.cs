using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;

namespace TASS
{
    class WoWDataParser
    {
        private WoWDataDownloader wdd;

        /// <summary>
        /// Konstruktor parsera.
        /// </summary>
        /// <param name="apiKey">Klucz użytkownika do API Battle.NET potrzebny dla WoWDataDownloadera</param>
        public WoWDataParser(String apiKey)
        {
            wdd = new WoWDataDownloader(apiKey);
        }

        /// <summary>
        /// Metoda parsująca dane.
        /// </summary>
        /// <param name="data">JSon w postaci Stringa</param>
        /// <returns>JSon w postaci JTokena</returns>
        public JToken parseData(String data)
        {
            return JToken.Parse(data);
        }

        public String[] getMembersItemLevel(String realm, String guildName)
        {
            JToken token = parseData(wdd.getGuildInfo("members", realm, guildName));
            List<String> result = new List<String>();
            foreach(var x in token["members"])
            {
                String charName = (String)x["character"]["name"];
                String charInfo = wdd.getCharacterInfo("items", realm, charName);

                if (charInfo != null)
                {
                    JToken xData = parseData(charInfo);
                    result.Add(charName + " - " + (String)xData["items"]["averageItemLevel"]);
                }
            }

            return result.ToArray();
        }
        




    }
}
