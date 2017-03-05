using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanQuests.GameCourse.Intro
{
    public partial class Intro1 : Form
    {
        public String name = "test";

        public Intro1()
        {
            InitializeComponent();
        }

        private void Intro1_Load(object sender, EventArgs e)
        {
            label1_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Guten Tag!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
        }
    }
}
