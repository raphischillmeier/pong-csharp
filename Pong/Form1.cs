using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.KeyDown += new KeyEventHandler(keyDownEvent);
            this.KeyUp += new KeyEventHandler(keyUpEvent);

            
            timer1.Interval = 20;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Start(); 
        }

        int ballSpeedX = 5;
        int ballSpeedY = 5;
        private int playerSpeed = 10;
        private bool isMovingUp = false;
        private bool isMovingDown = false;


        private void timer1_Tick(object sender, EventArgs e)
        {
            ball.Left += ballSpeedX;
            ball.Top += ballSpeedY;

            if (ball.Bounds.IntersectsWith(playerOne.Bounds))
            {
                ballSpeedX = -ballSpeedX;
            }

            if (ball.Bounds.IntersectsWith(playerTwo.Bounds))
            {
                ballSpeedX = -ballSpeedX; 
            }

            if (ball.Left <= 0)
            {
                win.Visible = true;
                restart.Visible = true;
                timer1.Stop();
            }

            if (ball.Right >= ClientSize.Width)
            {
                lose.Visible = true;
                restart.Visible = true;
                timer1.Stop();
            }

            if (ball.Top <= 0 || ball.Bottom >= ClientSize.Height)
            {
                ballSpeedY = -ballSpeedY;
            }

            if (isMovingUp && playerOne.Top > 0)
            {
                playerOne.Top -= playerSpeed;
            }

            if (isMovingDown && playerOne.Bottom < ClientSize.Height)
            {
                playerOne.Top += playerSpeed;
            }

            playerTwo.Top = ball.Top - 20;
        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                isMovingDown = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                isMovingUp = true;
            }
        }

        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                isMovingDown = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                isMovingUp = false;
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
