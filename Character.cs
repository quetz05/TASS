using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASS
{
    class Character
    {
        public enum Role
        {
            Tank,
            Healer,
            DPS,
            Unknown
        };

        public int itemLevel;
        public String name;
        public Role role;

        public Character(int itemLevel, String name, Role role = Role.Unknown)
        {
            this.itemLevel = itemLevel;
            this.name = name;
            this.role = role;
        }

        static public Character.Role RoleFromString(String role)
        {
            switch(role)
            {
                case "DPS": return Role.DPS;
                case "TANK": return Role.Tank;
                case "HEALING": return Role.Healer;
                default: return Role.Unknown;
            }

        }
    }
}
