using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanQuests.RufusChat
{
    class ChatBaseComponents
    {
        public static string prefix = "RomanQuests";
        public static string rufusprefix = "Rufus Rundfuss: ";
        public static List<string> quests = new List<string>();


        public static void addQuest(string quest)
        {
            quests.Add(quest);
        }

        public static void removeQuest(string quest)
        {
            quests.Remove(quest);
        }

       

    }
}
