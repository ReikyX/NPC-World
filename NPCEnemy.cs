using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_World_Korrektur
{
    internal class NPCEnemy : NPC
    {
        public NPCEnemy(int lp, string name, string[] dialoge) 
        {
            Lp = lp;
            this.name = name;
            this.dialog = dialoge;
        }

        public void Fight()
        {
            Console.WriteLine($"{Name} greift dich an.");
            Console.ReadKey();
        }
    }
}
