namespace GameArchipelago.Forms
{
    partial class StonePaperScissors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StonePaperScissors));
            this.btnRock = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.pbOpponentsChoose = new System.Windows.Forms.PictureBox();
            this.lblOpponentsTurn = new System.Windows.Forms.Label();
            this.lblYourMove = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResultOfMove = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponentsChoose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRock.Image = ((System.Drawing.Image)(resources.GetObject("btnRock.Image")));
            this.btnRock.Location = new System.Drawing.Point(12, 297);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(249, 143);
            this.btnRock.TabIndex = 0;
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaper.Image = ((System.Drawing.Image)(resources.GetObject("btnPaper.Image")));
            this.btnPaper.Location = new System.Drawing.Point(267, 297);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(266, 143);
            this.btnPaper.TabIndex = 1;
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnScissors.Image = ((System.Drawing.Image)(resources.GetObject("btnScissors.Image")));
            this.btnScissors.Location = new System.Drawing.Point(539, 297);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(249, 143);
            this.btnScissors.TabIndex = 2;
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // pbOpponentsChoose
            // 
            this.pbOpponentsChoose.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbOpponentsChoose.Location = new System.Drawing.Point(330, 77);
            this.pbOpponentsChoose.Name = "pbOpponentsChoose";
            this.pbOpponentsChoose.Size = new System.Drawing.Size(143, 143);
            this.pbOpponentsChoose.TabIndex = 3;
            this.pbOpponentsChoose.TabStop = false;
            this.pbOpponentsChoose.Visible = false;
            // 
            // lblOpponentsTurn
            // 
            this.lblOpponentsTurn.AutoSize = true;
            this.lblOpponentsTurn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOpponentsTurn.Location = new System.Drawing.Point(316, 35);
            this.lblOpponentsTurn.Name = "lblOpponentsTurn";
            this.lblOpponentsTurn.Size = new System.Drawing.Size(174, 28);
            this.lblOpponentsTurn.TabIndex = 5;
            this.lblOpponentsTurn.Text = "Opponents Move";
            // 
            // lblYourMove
            // 
            this.lblYourMove.AutoSize = true;
            this.lblYourMove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYourMove.Location = new System.Drawing.Point(344, 257);
            this.lblYourMove.Name = "lblYourMove";
            this.lblYourMove.Size = new System.Drawing.Size(113, 28);
            this.lblYourMove.TabIndex = 6;
            this.lblYourMove.Text = "Your Move";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(629, 35);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(76, 28);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result:";
            // 
            // lblResultOfMove
            // 
            this.lblResultOfMove.AutoSize = true;
            this.lblResultOfMove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultOfMove.Location = new System.Drawing.Point(584, 92);
            this.lblResultOfMove.Name = "lblResultOfMove";
            this.lblResultOfMove.Size = new System.Drawing.Size(164, 28);
            this.lblResultOfMove.TabIndex = 10;
            this.lblResultOfMove.Text = "___________________";
            this.lblResultOfMove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StonePaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultOfMove);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblYourMove);
            this.Controls.Add(this.lblOpponentsTurn);
            this.Controls.Add(this.pbOpponentsChoose);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnRock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "StonePaperScissors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stone-Paper-Scissors";
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponentsChoose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRock;
        private Button btnPaper;
        private Button btnScissors;
        private PictureBox pbOpponentsChoose;
        private Label lblOpponentsTurn;
        private Label lblYourMove;
        private Label lblResult;
        private Label lblResultOfMove;
    }
}