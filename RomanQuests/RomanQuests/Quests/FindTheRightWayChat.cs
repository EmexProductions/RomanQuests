using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RomanQuests.Quests
{
    class FindTheRightWayChat
    {

        public static string temprufus = RufusChat.ChatBaseComponents.rufusprefix;
        public static string tempgame = RufusChat.ChatBaseComponents.prefix;


        public static void main()
        {
            Console.WriteLine(temprufus + " Hilfe, ich habe ein Problem :/");
            Console.WriteLine(temprufus + "Kannst du mir das übersetzen? - [Hier Latein einfügen]");
            string eingabe = Console.ReadLine();
            if (eingabe.Contains("Der Ort ist falsch"))
            {
                Console.WriteLine(temprufus + " Ja das ist es! Kannst du mir jetzt noch helfen, nach Rom zu kommen?");
                FindTheRightWay ftrw = new FindTheRightWay();
                ftrw.Show();

            }else
            {
                Console.WriteLine(temprufus + " Das ist nicht ganz richtig, schaue nochmal deine Übersetzung an!");
                checkInput("Der Ort ist falsch");
            }
        }

            public static bool checkInput(String checkString)
        {
            string eingabe = Console.ReadLine();
            if (eingabe.Contains(checkString))
            {
                return true;
            }

                return false;
        }

        public void goOn()
        {
            Console.WriteLine(temprufus + " Danke! Jetzt können wir uns auf den Weg machen!");
            Console.ReadLine();
            RufusChat.Main.MainChat1.start();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            RufusChat.Main.MainChat1.startStory();
            

        }



        }

}
