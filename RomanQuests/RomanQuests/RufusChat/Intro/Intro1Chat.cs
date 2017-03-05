using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanQuests.RufusChat.Intro
{
    class Intro1Chat
    {
        
        public static string name = "DevUser1";
        static GameCourse.Intro.Intro1 i1 = new GameCourse.Intro.Intro1();
        
        public static void chatTranslation()
        {
            i1.Show();
            Console.Title = "RomanQuests - Dev-Version 0.1";
            string tempprefix = ChatBaseComponents.rufusprefix;
            Console.WriteLine(ChatBaseComponents.prefix + " Dev-Version 0.1");
            Console.WriteLine(tempprefix + "Salve, mein Name ist Rufus Rundfuss");
            Console.ReadLine();
            Console.WriteLine(tempprefix + "Un du musst " + name + " sein, oder?");
            Console.WriteLine(tempprefix + "Falls nicht, dann gebe jetzt nein ein");
            String eingabe = Console.ReadLine();
            if (eingabe != null)
            {
                if (eingabe.Equals("ja"))
                {
                    chatGoOn(name);
                }
                else if (eingabe.Equals("nein"))
                {
                    Console.WriteLine(tempprefix + "Gebe jetzt dein neuen Namen ein:");
                    name = Console.ReadLine();
                    chatTranslation();
                }else
                {
                    chatGoOn(name);
                }
            }
        }

        public static void chatGoOn(String username)
        {
            username = name;
            string tempprefix = ChatBaseComponents.rufusprefix;
            string temprq = ChatBaseComponents.prefix;
            Console.WriteLine(tempprefix + username + " ! Dich habe ich gesucht!");
            Console.ReadLine();
            Console.WriteLine(tempprefix + "Denn ich komme hier in der Zeit mit ein paar Rätseln nicht weiter!");
            Console.WriteLine(tempprefix + "Könntest du mir helfen, sie zu lösen?");
            String eingabe = Console.ReadLine();
            if(eingabe != null)
            {
                Console.WriteLine(tempprefix + "Dankesehr, das wird mir sehr helfen!");
            }
            Console.WriteLine(tempprefix + "Nun wollen wir mal sehen, ob du für die Reise bereit bist");
            Console.ReadLine();
            Console.WriteLine(tempprefix + "Machen wir doch einen kleinen Test. Ich stelle dir eine Frage /n und du beantwortest sie");
            Console.WriteLine(temprq + " Gebe ok ein");
            eingabe = Console.ReadLine();
            if(eingabe != null)
            {
                if (eingabe.Equals(tempprefix + "ok"))
                {
                    Console.WriteLine(tempprefix + "Gut, lass uns beginnen");
                }
            }

            Console.WriteLine(tempprefix + "Gut hier ist die Frage");
            startQuest();
        }

        public static void startQuest()
        {
            string frage = "Wie heißt die Hauptstadt von Italien?";
            Console.WriteLine(frage);
            Console.WriteLine(ChatBaseComponents.prefix + "Gebe hier die Antwort ein: (Groß- und Kleinschreibung beachten");
            string antwort = "Rom";
            string eingabe = Console.ReadLine();
            if (eingabe == antwort)
            {
                Console.WriteLine(ChatBaseComponents.rufusprefix + "Richtig, du bist echt gut!");
            }else
            {
                Console.WriteLine(ChatBaseComponents.rufusprefix + "Versuchs nochmal");
                startQuest();
            }
            Console.WriteLine(ChatBaseComponents.rufusprefix + "Also gut...");
            i1.Close();
        }

    }
}
