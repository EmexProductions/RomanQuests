using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanQuests.AdminMenu
{
    class AdminMenu
    {
        public List<string> passwords = new List<string>();

        public void main()
        {
            passwords.Add("GameDev123");
            passwords.Add("DevSystem123");
            passwords.Add("Test123");
            passwords.Add("TestDev123");
            Console.WriteLine("##########");
            Console.WriteLine("###LOGIN##");
            Console.WriteLine("##########");
            Console.ReadLine();
            Console.WriteLine("Username: GameDev");
            Console.WriteLine("Password:");
            string eingabe = Console.ReadLine();
            if (passwords.Contains(eingabe))
            {
                Console.WriteLine("Erfolgreich eingeloggt");
                
            }else
            {
                Console.WriteLine("Passwort war falsch");
                main();
            }


            Console.WriteLine("(1) Add Quest");
            Console.WriteLine("(2) Remove Quest");
            Console.WriteLine("(3) Print Quests");
            Console.WriteLine("Choose 1, 2, 3");
            eingabe = Console.ReadLine();
            if (eingabe.Equals("1"))
            {
                Console.WriteLine("Gebe hier die Frage ein");
                string quest = Console.ReadLine();
                RufusChat.ChatBaseComponents.addQuest(eingabe);
            }else if (eingabe.Equals("2"))
            {
                Console.WriteLine("Gebe hier die Frage ein");
                string quest = Console.ReadLine();
                if (RufusChat.ChatBaseComponents.quests.Contains(quest))
                {
                    RufusChat.ChatBaseComponents.removeQuest(quest);
                }
                else
                {
                    Console.WriteLine("Diese Frage gibt es nicht!");
                }
            }else if (eingabe.Equals("3"))
            {
                for(int i = 0; i < RufusChat.ChatBaseComponents.quests.Count; i++)
                {
                    Console.WriteLine(RufusChat.ChatBaseComponents.quests[i]);
                }
            }
        }

    }
}
