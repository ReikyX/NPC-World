using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_World_Korrektur
{
    internal class NPCFriend : NPC
    {
        public NPCFriend(int lp, string name, string[] dialog)
        {
            Lp = lp;
            this.name = name;
            this.dialog = dialog;
        }

        public void Trade()
        {
            Console.WriteLine($"{Name} handelt mit dir.");
            Console.ReadKey();
        }
    }
}
