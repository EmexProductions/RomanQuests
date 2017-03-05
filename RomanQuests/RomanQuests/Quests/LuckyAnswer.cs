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
    public partial class LuckyAnswer : Form
    {
        public LuckyAnswer()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = LuckyAnswerClass.chooseRandomNumber();
        }
    }
}
