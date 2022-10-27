namespace GameArchipelago.Forms
{
    partial class GuessTheNumberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuessTheNumberForm));
            this.InputNumberBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TimesLabel = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputNumberBox
            // 
            this.InputNumberBox.Location = new System.Drawing.Point(232, 75);
            this.InputNumberBox.Name = "InputNumberBox";
            this.InputNumberBox.Size = new System.Drawing.Size(273, 27);
            this.InputNumberBox.TabIndex = 0;
            this.InputNumberBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "I am thinking about a number between 0 and 100";
            // 
            // TimesLabel
            // 
            this.TimesLabel.AutoSize = true;
            this.TimesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimesLabel.Location = new System.Drawing.Point(11, 171);
            this.TimesLabel.Name = "TimesLabel";
            this.TimesLabel.Size = new System.Drawing.Size(279, 28);
            this.TimesLabel.TabIndex = 2;
            this.TimesLabel.Text = "You have guessed in 0 times";
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CheckButton.Location = new System.Drawing.Point(321, 121);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(94, 29);
            this.CheckButton.TabIndex = 3;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // GuessTheNumberForm
            // 
            this.AcceptButton = this.CheckButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(729, 215);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.TimesLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputNumberBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(747, 262);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(747, 262);
            this.Name = "GuessTheNumberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Guess The Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox InputNumberBox;
        private Label label1;
        private Label TimesLabel;
        private Button CheckButton;
    }
}