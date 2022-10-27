namespace GameArchipelago.Forms.PixelRace
{
    partial class PixelRace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftBorder = new System.Windows.Forms.PictureBox();
            this.pictureBoxRightBorder = new System.Windows.Forms.PictureBox();
            this.labelScoreValue = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerEnemy = new System.Windows.Forms.Timer(this.components);
            this.labelExit = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.timerGameDiff = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPlayer
            // 
            this.pictureBoxPlayer.Image = global::GameArchipelago.Properties.Resources.Player;
            this.pictureBoxPlayer.Location = new System.Drawing.Point(378, 553);
            this.pictureBoxPlayer.Name = "pictureBoxPlayer";
            this.pictureBoxPlayer.Size = new System.Drawing.Size(67, 60);
            this.pictureBoxPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPlayer.TabIndex = 0;
            this.pictureBoxPlayer.TabStop = false;
            // 
            // pictureBoxLeftBorder
            // 
            this.pictureBoxLeftBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxLeftBorder.Location = new System.Drawing.Point(227, -1);
            this.pictureBoxLeftBorder.Name = "pictureBoxLeftBorder";
            this.pictureBoxLeftBorder.Size = new System.Drawing.Size(18, 631);
            this.pictureBoxLeftBorder.TabIndex = 1;
            this.pictureBoxLeftBorder.TabStop = false;
            // 
            // pictureBoxRightBorder
            // 
            this.pictureBoxRightBorder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBoxRightBorder.Location = new System.Drawing.Point(591, -1);
            this.pictureBoxRightBorder.Name = "pictureBoxRightBorder";
            this.pictureBoxRightBorder.Size = new System.Drawing.Size(18, 631);
            this.pictureBoxRightBorder.TabIndex = 2;
            this.pictureBoxRightBorder.TabStop = false;
            // 
            // labelScoreValue
            // 
            this.labelScoreValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelScoreValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelScoreValue.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelScoreValue.Location = new System.Drawing.Point(0, 0);
            this.labelScoreValue.Name = "labelScoreValue";
            this.labelScoreValue.Size = new System.Drawing.Size(209, 57);
            this.labelScoreValue.TabIndex = 3;
            this.labelScoreValue.Text = "Score: 0";
            this.labelScoreValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox5.Location = new System.Drawing.Point(-8, -1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(241, 625);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "PixelRace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.GameEvents);
            // 
            // timerEnemy
            // 
            this.timerEnemy.Interval = 1500;
            this.timerEnemy.Tick += new System.EventHandler(this.spawnEnemyEvent);
            // 
            // labelExit
            // 
            this.labelExit.BackColor = System.Drawing.Color.RosyBrown;
            this.labelExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExit.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelExit.Location = new System.Drawing.Point(0, 0);
            this.labelExit.Name = "labelExit";
            this.labelExit.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.labelExit.Size = new System.Drawing.Size(104, 57);
            this.labelExit.TabIndex = 13;
            this.labelExit.Text = "Exit";
            this.labelExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExit.Click += new System.EventHandler(this.labelExit_Click);
            // 
            // labelStart
            // 
            this.labelStart.BackColor = System.Drawing.Color.YellowGreen;
            this.labelStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStart.Location = new System.Drawing.Point(0, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.labelStart.Size = new System.Drawing.Size(209, 57);
            this.labelStart.TabIndex = 14;
            this.labelStart.Text = "Start Game";
            this.labelStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStart.Click += new System.EventHandler(this.labelStart_Click);
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelGameOver.Location = new System.Drawing.Point(315, 224);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Padding = new System.Windows.Forms.Padding(21, 20, 21, 20);
            this.labelGameOver.Size = new System.Drawing.Size(195, 71);
            this.labelGameOver.TabIndex = 16;
            this.labelGameOver.Text = "GAME OVER!";
            this.labelGameOver.Visible = false;
            // 
            // timerGameDiff
            // 
            this.timerGameDiff.Interval = 5000;
            this.timerGameDiff.Tick += new System.EventHandler(this.gameDiffEvent);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 57);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(12, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 57);
            this.panel2.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 57);
            this.label4.TabIndex = 11;
            this.label4.Text = "The definitive edition";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelScoreValue);
            this.panel3.Location = new System.Drawing.Point(12, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 57);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.labelStart);
            this.panel4.Location = new System.Drawing.Point(12, 277);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 57);
            this.panel4.TabIndex = 20;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelExit);
            this.panel5.Location = new System.Drawing.Point(60, 340);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(104, 57);
            this.panel5.TabIndex = 21;
            // 
            // lblLeft
            // 
            this.lblLeft.BackColor = System.Drawing.Color.Azure;
            this.lblLeft.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLeft.Location = new System.Drawing.Point(49, 452);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(60, 60);
            this.lblLeft.TabIndex = 22;
            this.lblLeft.Text = "<<";
            this.lblLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRight
            // 
            this.lblRight.BackColor = System.Drawing.Color.Azure;
            this.lblRight.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRight.Location = new System.Drawing.Point(115, 452);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(60, 60);
            this.lblRight.TabIndex = 23;
            this.lblRight.Text = ">>";
            this.lblRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PixelRace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 615);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBoxRightBorder);
            this.Controls.Add(this.pictureBoxLeftBorder);
            this.Controls.Add(this.pictureBoxPlayer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(627, 662);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(627, 662);
            this.Name = "PixelRace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PixelRace";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxPlayer;
        private PictureBox pictureBoxLeftBorder;
        private PictureBox pictureBoxRightBorder;
        private Label labelScoreValue;
        private PictureBox pictureBox5;
        private Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Timer timerEnemy;
        private Label labelExit;
        private Label labelStart;
        private Label labelGameOver;
        private System.Windows.Forms.Timer timerGameDiff;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Label lblLeft;
        private Label lblRight;
    }
}