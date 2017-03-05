using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RomanQuests.GameCourse.Main.RomMove
{
    public partial class RomMove : Form
    {

        enum Position
        {
            Left, Right, Up, Down
        }

        private int _x;
        private int _y;
        private Position _objPosition;

        public RomMove()
        {
            InitializeComponent();
        }

        private void tmrMoving_Tick(object sender, EventArgs e)
        {
            if (_objPosition == Position.Right)
            {
                _x += 5;
            }
            else if (_objPosition == Position.Left)
            {
                _x -= 5;
            }
            else if (_objPosition == Position.Up)
            {
                _y -= 5;
            }
            else if (_objPosition == Position.Down)
            {
                _y += 5;
            }

            Invalidate();
        }

        private void RomMove_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 30, 30);
            //e.Graphics.DrawImage(new Bitmap("rufusrundfussoriginal.jpg"), _x, _y, 64, 64);
            
        }

        private void RomMove_KeyDown(object sender, KeyEventArgs e)
        {
            tmrMoving.Start();
            if (e.KeyCode == Keys.Left)
            {
                _objPosition = Position.Left;

            }
            else if (e.KeyCode == Keys.Right)
            {
                _objPosition = Position.Right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                _objPosition = Position.Up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                _objPosition = Position.Down;
            }
            else if (e.KeyCode == Keys.Space)
            {
                tmrMoving.Stop();
            }
        }
    }
}
