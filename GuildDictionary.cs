using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASS
{
    class GuildDictionary
    {


        private Dictionary<String, List<Character>> dictionary;

        public GuildDictionary()
        {
            dictionary = new Dictionary<String, List<Character>>();
        }

        public Dictionary<String, List<Character>> Get()
        {
            return dictionary;
        }

        public void Add(String realm, String guildName, String characterName, int itemLevel, String role = "")
        {
            if(!dictionary.ContainsKey(guildName))
                dictionary.Add(guildName, new List<Character>());

            dictionary[guildName].Add(new Character(realm, guildName, itemLevel, characterName, role));
        }

        public int GuildCount()
        {
            return dictionary.Count;
        }

        public void Clear()
        {
            dictionary.Clear();
        }

    }
}
