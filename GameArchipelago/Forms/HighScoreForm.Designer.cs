namespace GameArchipelago.Forms
{
    partial class HighScoreForm
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
            this.buttonSaveHighScore = new System.Windows.Forms.Button();
            this.textBoxNick = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelSaveResultTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelScore = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveHighScore
            // 
            this.buttonSaveHighScore.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSaveHighScore.Location = new System.Drawing.Point(127, 289);
            this.buttonSaveHighScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonSaveHighScore.Name = "buttonSaveHighScore";
            this.buttonSaveHighScore.Size = new System.Drawing.Size(219, 61);
            this.buttonSaveHighScore.TabIndex = 0;
            this.buttonSaveHighScore.Text = "Save";
            this.buttonSaveHighScore.UseVisualStyleBackColor = false;
            this.buttonSaveHighScore.Click += new System.EventHandler(this.buttonSaveHighScore_Click);
            // 
            // textBoxNick
            // 
            this.textBoxNick.Location = new System.Drawing.Point(127, 224);
            this.textBoxNick.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxNick.Name = "textBoxNick";
            this.textBoxNick.Size = new System.Drawing.Size(220, 27);
            this.textBoxNick.TabIndex = 5;
            this.textBoxNick.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelSaveResultTitle);
            this.panel2.Location = new System.Drawing.Point(11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(455, 92);
            this.panel2.TabIndex = 6;
            // 
            // labelSaveResultTitle
            // 
            this.labelSaveResultTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSaveResultTitle.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSaveResultTitle.Location = new System.Drawing.Point(0, 0);
            this.labelSaveResultTitle.Name = "labelSaveResultTitle";
            this.labelSaveResultTitle.Size = new System.Drawing.Size(455, 92);
            this.labelSaveResultTitle.TabIndex = 2;
            this.labelSaveResultTitle.Text = "Save your result!";
            this.labelSaveResultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelScore);
            this.panel3.Location = new System.Drawing.Point(11, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(455, 61);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 65);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(455, 52);
            this.panel4.TabIndex = 8;
            // 
            // labelScore
            // 
            this.labelScore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelScore.Font = new System.Drawing.Font("Verdana", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelScore.Location = new System.Drawing.Point(0, 0);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(455, 61);
            this.labelScore.TabIndex = 3;
            this.labelScore.Text = "1100";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(11, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(453, 49);
            this.panel5.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(455, 36);
            this.panel6.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 49);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your nickname:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxNick);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.buttonSaveHighScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(479, 372);
            this.panel1.TabIndex = 3;
            // 
            // HighScoreForm
            // 
            this.AcceptButton = this.buttonSaveHighScore;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(479, 372);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 419);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(497, 419);
            this.Name = "HighScoreForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Save highscore!";
            this.Load += new System.EventHandler(this.HighScoreForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button buttonSaveHighScore;
        private TextBox textBoxNick;
        private Panel panel2;
        private Label labelSaveResultTitle;
        private Panel panel3;
        private Panel panel4;
        private Label labelScore;
        private Panel panel5;
        private Panel panel6;
        private Label label2;
        private Panel panel1;
    }
}