using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_World_Korrektur
{
    internal class NPC
    {
        private int lp = 100;
        protected string name = "Unbekannter";
        protected string[] dialog = { ". . ." };

        public int Lp { get => lp; set => lp = value; }
        public string Name { get => name;}
        public string[] Dialog { get => dialog;}

        public NPC()
        {

        }
        public NPC(int lp, string name, string[] dialog)
        {
            this.lp = lp;
            this.name = name;
            this.dialog = dialog;
        }

        public void Interact(NPC npc)
        {
            foreach (string text  in dialog)
            {
                string output = "";
                foreach(char i  in text)
                {
                    output += i;
                    Console.Clear();
                    Console.WriteLine(output);
                    Thread.Sleep(30);
                }
                Console.ReadKey();
                Console.Clear();
            }
            if (npc is NPCFriend friend)
            {
                friend.Trade();
            }
            else if (npc is NPCEnemy enemy)
            {
                enemy.Fight();
            }
        }
    }
}
