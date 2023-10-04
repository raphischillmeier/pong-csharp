namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playerOne = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playerTwo = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.win = new System.Windows.Forms.Label();
            this.lose = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // playerOne
            // 
            this.playerOne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerOne.Location = new System.Drawing.Point(784, 162);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(19, 125);
            this.playerOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerOne.TabIndex = 0;
            this.playerOne.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // playerTwo
            // 
            this.playerTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playerTwo.Location = new System.Drawing.Point(-4, 162);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(19, 125);
            this.playerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.playerTwo.TabIndex = 1;
            this.playerTwo.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ball.Location = new System.Drawing.Point(384, 207);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(38, 38);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // win
            // 
            this.win.AutoSize = true;
            this.win.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.win.Location = new System.Drawing.Point(341, 81);
            this.win.Name = "win";
            this.win.Size = new System.Drawing.Size(120, 16);
            this.win.TabIndex = 3;
            this.win.Text = "Du hast gewonnen ";
            this.win.Visible = false;
            // 
            // lose
            // 
            this.lose.AutoSize = true;
            this.lose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lose.Location = new System.Drawing.Point(341, 97);
            this.lose.Name = "lose";
            this.lose.Size = new System.Drawing.Size(104, 16);
            this.lose.TabIndex = 4;
            this.lose.Text = "Du hast verloren";
            this.lose.Visible = false;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(370, 303);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(75, 23);
            this.restart.TabIndex = 5;
            this.restart.TabStop = false;
            this.restart.Text = "Neustart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.lose);
            this.Controls.Add(this.win);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDownEvent);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUpEvent);
            ((System.ComponentModel.ISupportInitialize)(this.playerOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox playerOne;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox playerTwo;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Label win;
        private System.Windows.Forms.Label lose;
        private System.Windows.Forms.Button restart;
    }
}

