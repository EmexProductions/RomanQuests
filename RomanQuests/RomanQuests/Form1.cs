using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanQuests
{
    public partial class Form1 : Form
    {

        public static bool isAdminMenuActivated = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(isAdminMenuActivated == false)
            {
                RufusChat.MainGameCourse mgc = new RufusChat.MainGameCourse();
                mgc.mainGameCourse();
            }else
            {
                AdminMenu.AdminMenu am = new AdminMenu.AdminMenu();
                am.main();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Optionen.Options o = new Optionen.Options();
            o.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            this.Hide();
            Console.WriteLine("#################################################");
            Console.WriteLine("Developed by Nico Riedmann und Jan-Philipp Friese");
            Console.WriteLine("Version: Dev 0.1");
            Console.WriteLine("#################################################");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Gebe OK ein, um ins Hauptmenü zurückzukehren");
            string eingabe = Console.ReadLine();
            if (eingabe.Contains("OK"))
            {
                Console.Clear();
                this.Show();
            }

        }
    }
}
