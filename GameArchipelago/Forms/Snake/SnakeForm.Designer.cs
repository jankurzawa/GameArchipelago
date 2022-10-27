namespace GameArchipelago.Forms.Snake
{
    partial class SnakeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnakeForm));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblResultHeader = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.pbBoard = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(21, 25);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 52);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblResultHeader
            // 
            this.lblResultHeader.AutoSize = true;
            this.lblResultHeader.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResultHeader.Location = new System.Drawing.Point(38, 342);
            this.lblResultHeader.Name = "lblResultHeader";
            this.lblResultHeader.Size = new System.Drawing.Size(80, 31);
            this.lblResultHeader.TabIndex = 2;
            this.lblResultHeader.Text = "Result";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblresult.Location = new System.Drawing.Point(57, 397);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(44, 31);
            this.lblresult.TabIndex = 3;
            this.lblresult.Text = "___";
            this.lblresult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBoard
            // 
            this.pbBoard.BackColor = System.Drawing.Color.GreenYellow;
            this.pbBoard.Location = new System.Drawing.Point(155, 25);
            this.pbBoard.Name = "pbBoard";
            this.pbBoard.Size = new System.Drawing.Size(405, 403);
            this.pbBoard.TabIndex = 4;
            this.pbBoard.TabStop = false;
            this.pbBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdateBoard);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.GreenYellow;
            this.lblGameOver.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGameOver.Location = new System.Drawing.Point(274, 197);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(173, 41);
            this.lblGameOver.TabIndex = 5;
            this.lblGameOver.Text = "Game Over";
            this.lblGameOver.Visible = false;
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.pbBoard);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.lblResultHeader);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 497);
            this.Name = "SnakeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Snake";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnStart;
        private Label lblResultHeader;
        private Label lblresult;
        private PictureBox pbBoard;
        private System.Windows.Forms.Timer timer;
        private Label lblGameOver;
    }
}