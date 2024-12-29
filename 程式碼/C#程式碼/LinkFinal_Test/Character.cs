using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkFinal_Test
{
    // 角色類別
    class Character
    {
        public string Name { get; }
        public int Attack { get; }
        public int Defense { get; }

        public Character(string name, int attack, int defense)
        {
            Name = name;
            Attack = attack;
            Defense = defense;
        }

        public override string ToString()
        {
            return $"{Name} (Attack: {Attack}, Defense: {Defense})";
        }
    }
}
