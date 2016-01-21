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
            dictionary = new Dictionary<string, List<Character>>();
        }



        public void Add(String guildName, String characterName, int itemLevel, Character.Role role = Character.Role.Unknown)
        {
            if(!dictionary.ContainsKey(guildName))
                dictionary.Add(guildName, new List<Character>());

            dictionary[guildName].Add(new Character(itemLevel, characterName, role));
        }

        public int GuildCount()
        {
            return dictionary.Count;
        }

    }
}
