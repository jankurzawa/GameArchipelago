namespace GameArchipelago.Forms
{
    partial class TicTacToeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicTacToeForm));
            this.Square1 = new System.Windows.Forms.Button();
            this.Square2 = new System.Windows.Forms.Button();
            this.Square3 = new System.Windows.Forms.Button();
            this.Square6 = new System.Windows.Forms.Button();
            this.Square5 = new System.Windows.Forms.Button();
            this.Square4 = new System.Windows.Forms.Button();
            this.Square9 = new System.Windows.Forms.Button();
            this.Square8 = new System.Windows.Forms.Button();
            this.Square7 = new System.Windows.Forms.Button();
            this.lblActivePlayer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Square1
            // 
            this.Square1.BackColor = System.Drawing.Color.Silver;
            this.Square1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square1.Location = new System.Drawing.Point(12, 113);
            this.Square1.Name = "Square1";
            this.Square1.Size = new System.Drawing.Size(80, 80);
            this.Square1.TabIndex = 0;
            this.Square1.UseVisualStyleBackColor = false;
            this.Square1.Click += new System.EventHandler(this.SignButton);
            // 
            // Square2
            // 
            this.Square2.BackColor = System.Drawing.Color.Silver;
            this.Square2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square2.Location = new System.Drawing.Point(98, 113);
            this.Square2.Name = "Square2";
            this.Square2.Size = new System.Drawing.Size(80, 80);
            this.Square2.TabIndex = 1;
            this.Square2.UseVisualStyleBackColor = false;
            this.Square2.Click += new System.EventHandler(this.SignButton);
            // 
            // Square3
            // 
            this.Square3.BackColor = System.Drawing.Color.Silver;
            this.Square3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square3.Location = new System.Drawing.Point(184, 113);
            this.Square3.Name = "Square3";
            this.Square3.Size = new System.Drawing.Size(80, 80);
            this.Square3.TabIndex = 2;
            this.Square3.UseVisualStyleBackColor = false;
            this.Square3.Click += new System.EventHandler(this.SignButton);
            // 
            // Square6
            // 
            this.Square6.BackColor = System.Drawing.Color.Silver;
            this.Square6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square6.Location = new System.Drawing.Point(184, 199);
            this.Square6.Name = "Square6";
            this.Square6.Size = new System.Drawing.Size(80, 80);
            this.Square6.TabIndex = 5;
            this.Square6.UseVisualStyleBackColor = false;
            this.Square6.Click += new System.EventHandler(this.SignButton);
            // 
            // Square5
            // 
            this.Square5.BackColor = System.Drawing.Color.Silver;
            this.Square5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square5.Location = new System.Drawing.Point(98, 199);
            this.Square5.Name = "Square5";
            this.Square5.Size = new System.Drawing.Size(80, 80);
            this.Square5.TabIndex = 4;
            this.Square5.UseVisualStyleBackColor = false;
            this.Square5.Click += new System.EventHandler(this.SignButton);
            // 
            // Square4
            // 
            this.Square4.BackColor = System.Drawing.Color.Silver;
            this.Square4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square4.Location = new System.Drawing.Point(12, 199);
            this.Square4.Name = "Square4";
            this.Square4.Size = new System.Drawing.Size(80, 80);
            this.Square4.TabIndex = 3;
            this.Square4.UseVisualStyleBackColor = false;
            this.Square4.Click += new System.EventHandler(this.SignButton);
            // 
            // Square9
            // 
            this.Square9.BackColor = System.Drawing.Color.Silver;
            this.Square9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square9.Location = new System.Drawing.Point(184, 285);
            this.Square9.Name = "Square9";
            this.Square9.Size = new System.Drawing.Size(80, 80);
            this.Square9.TabIndex = 8;
            this.Square9.UseVisualStyleBackColor = false;
            this.Square9.Click += new System.EventHandler(this.SignButton);
            // 
            // Square8
            // 
            this.Square8.BackColor = System.Drawing.Color.Silver;
            this.Square8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square8.Location = new System.Drawing.Point(98, 285);
            this.Square8.Name = "Square8";
            this.Square8.Size = new System.Drawing.Size(80, 80);
            this.Square8.TabIndex = 7;
            this.Square8.UseVisualStyleBackColor = false;
            this.Square8.Click += new System.EventHandler(this.SignButton);
            // 
            // Square7
            // 
            this.Square7.BackColor = System.Drawing.Color.Silver;
            this.Square7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Square7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Square7.Location = new System.Drawing.Point(12, 285);
            this.Square7.Name = "Square7";
            this.Square7.Size = new System.Drawing.Size(80, 80);
            this.Square7.TabIndex = 6;
            this.Square7.UseVisualStyleBackColor = false;
            this.Square7.Click += new System.EventHandler(this.SignButton);
            // 
            // lblActivePlayer
            // 
            this.lblActivePlayer.BackColor = System.Drawing.Color.DimGray;
            this.lblActivePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActivePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblActivePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActivePlayer.Location = new System.Drawing.Point(0, 0);
            this.lblActivePlayer.Name = "lblActivePlayer";
            this.lblActivePlayer.Size = new System.Drawing.Size(277, 107);
            this.lblActivePlayer.TabIndex = 9;
            this.lblActivePlayer.Text = "Player X\r\nto move";
            this.lblActivePlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblActivePlayer);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(277, 107);
            this.panel1.TabIndex = 10;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(277, 374);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Square9);
            this.Controls.Add(this.Square8);
            this.Controls.Add(this.Square7);
            this.Controls.Add(this.Square6);
            this.Controls.Add(this.Square5);
            this.Controls.Add(this.Square4);
            this.Controls.Add(this.Square3);
            this.Controls.Add(this.Square2);
            this.Controls.Add(this.Square1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(295, 421);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(295, 421);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TicTacToeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tic Tac Toe!";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button Square1;
        private Button Square2;
        private Button Square3;
        private Button Square6;
        private Button Square5;
        private Button Square4;
        private Button Square9;
        private Button Square8;
        private Button Square7;
        private Label lblActivePlayer;
        private Panel panel1;
    }
}