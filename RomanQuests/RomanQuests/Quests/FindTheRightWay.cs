using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanQuests.Quests
{
    public partial class FindTheRightWay : Form
    {
        public FindTheRightWay()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
                    }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine(RufusChat.ChatBaseComponents.prefix + " Herzlichen Glückwunsch, das war richtig!");
            Close();
            FindTheRightWayChat fc = new FindTheRightWayChat();
            fc.goOn();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(RufusChat.ChatBaseComponents.prefix + " Das war nicht ganz richtig, versuchs nochmal!");
        }

        public void button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine(RufusChat.ChatBaseComponents.prefix + " Das war nicht ganz richtig, versuchs nochmal!");
        }

        public void button4_Click(object sender, EventArgs e)
        {
            Console.WriteLine(RufusChat.ChatBaseComponents.prefix + " Das war nicht ganz richtig, versuchs nochmal!");
        }

        private void FindTheRightWay_Load(object sender, EventArgs e)
        {

        }
    }
}
