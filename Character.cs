using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASS
{
    class Character
    {
        public int itemLevel;
        public String name;
        public String role;
        public String guild;
        public String realm;

        public Character(String realm, String guild, int itemLevel, String name, String role = "")
        {
            this.realm = realm;
            this.guild = guild;
            this.itemLevel = itemLevel;
            this.name = name;
            this.role = role;
        }
    }
}
