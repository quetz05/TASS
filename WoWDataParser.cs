﻿using System;
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
        public GuildDictionary dictionary;
        protected class RaidCounter
        {
            public int DPS;
            public int Healer;
            public int Tank;

            public RaidCounter()
            {
                this.DPS = 0;
                this.Healer = 0;
                this.Tank = 0;
            }

            public bool isEnough()
            {
                if (DPS >= 19 && Healer >= 4 && Tank >= 2)
                    return true;
                else
                    return false;
            }

            public void AddCharacterRole(String role)
            {
                switch(role)
                {
                    case "DPS": DPS++; break;
                    case "TANK": Tank++; break;
                    case "HEALING": Healer++; break;
                    default: break;
                }
            }

            public int Count()
            {
                return DPS + Healer + Tank;
            }
        }

        /// <summary>
        /// Konstruktor parsera.
        /// </summary>
        /// <param name="apiKey">Klucz użytkownika do API Battle.NET potrzebny dla WoWDataDownloadera</param>
        public WoWDataParser()
        {
            wdd = new WoWDataDownloader();
            dictionary = new GuildDictionary();
        }

        public void SetKey(String key)
        {
            wdd.SetKey(key);
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
            dictionary.Clear();

            JToken token = parseData(wdd.getGuildInfo("members", realm, guildName));
            List<String> result = new List<String>();
            foreach(var x in token["members"])
            {

                String charName = (String)x["character"]["name"];
                String role = "SS"; //(String)x["character"]["spec"]["role"];
                String charInfo = wdd.getCharacterInfo("items", realm, charName);

                if (charInfo != null)
                {
                    JToken xData = parseData(charInfo);
                    if (xData.First == null)
                        continue;
                    String il = (String)xData["items"]["averageItemLevel"];
                    int itemLevel = int.Parse(il);
                    dictionary.Add(realm, guildName, charName, itemLevel, role);
                }
            }

            // TODO - Zapis informacji w bazie
            // AddToBase(dictionary)

            return result.ToArray();
        }

        public String[] ComputeGuildsItemLevel(String guildName)
        {
            GuildDictionary dataFromBase = new GuildDictionary();
            List<String> list = new List<String>();
            
            // TODO - pobranie informacji z bazy
            // Branych jest pod uwagę przynajmniej 2 tanków, 4 healerów i 19 dpsów
            

            int result = 0;
            foreach(var guild in dataFromBase.Get())
            {
                RaidCounter rc = new RaidCounter();

                foreach(var character in guild.Value)
                {
                    result += character.itemLevel;
                    rc.AddCharacterRole(character.role);
                    if (rc.isEnough())
                        break;
                }

                result /= rc.Count();

                list.Add(guild.Key + " - " + result.ToString());
            }

            return list.ToArray();
        }
        

    }
}
