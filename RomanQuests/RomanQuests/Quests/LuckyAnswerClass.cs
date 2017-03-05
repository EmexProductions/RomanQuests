using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanQuests.Quests
{
    class LuckyAnswerClass
    {

        public void main()
        {
            Console.WriteLine("");
        }



        public static string chooseRandomNumber()
        {
            string randomzahl = "";

            int zahl;
            Random rdm = new Random();
            zahl = rdm.Next(9);
            if(zahl == 1)
            {
                randomzahl = "unus";
            }else if(zahl == 2)
            {
                randomzahl = "duo";
            }else if(zahl == 3)
            {
                randomzahl = "tres";
            }else if(zahl == 4)
            {
                randomzahl = "quattuor";
            }else if(zahl == 5)
            {
                randomzahl = "quinque";
            }
            else if(zahl == 6)
            {
                randomzahl = "sex";
            }
            else if(zahl == 7)
            {
                randomzahl = "septem";
            }
            else if(zahl == 8)
            {
                randomzahl = "octo";
            }
            else if(zahl == 9)
            {
                randomzahl = "novem";
            }
            else if(zahl == 10)
            {
                randomzahl = "decem";
            }
            
            return randomzahl;
        }

    }
}
