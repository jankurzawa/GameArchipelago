namespace GameArchipelago.Forms.Dino
{
    partial class DinoGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DinoGame));
            this.floor = new System.Windows.Forms.PictureBox();
            this.trex = new System.Windows.Forms.PictureBox();
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelStartGame = new System.Windows.Forms.Label();
            this.endGameLabel = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelEdition = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            this.SuspendLayout();
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.Color.Black;
            this.floor.Location = new System.Drawing.Point(-10, 339);
            this.floor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(547, 38);
            this.floor.TabIndex = 0;
            this.floor.TabStop = false;
            // 
            // trex
            // 
            this.trex.Image = global::GameArchipelago.Properties.Resources.running;
            this.trex.Location = new System.Drawing.Point(90, 293);
            this.trex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trex.Name = "trex";
            this.trex.Size = new System.Drawing.Size(38, 45);
            this.trex.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trex.TabIndex = 1;
            this.trex.TabStop = false;
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::GameArchipelago.Properties.Resources.obstacle_1;
            this.obstacle1.Location = new System.Drawing.Point(325, 304);
            this.obstacle1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 2;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::GameArchipelago.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(467, 300);
            this.obstacle2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(44, 38);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle2.TabIndex = 3;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.scoreText.Location = new System.Drawing.Point(11, 10);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(86, 25);
            this.scoreText.TabIndex = 4;
            this.scoreText.Text = "Score- 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameEvent);
            // 
            // labelStartGame
            // 
            this.labelStartGame.AutoSize = true;
            this.labelStartGame.BackColor = System.Drawing.Color.PaleGreen;
            this.labelStartGame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelStartGame.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStartGame.Location = new System.Drawing.Point(102, 151);
            this.labelStartGame.Name = "labelStartGame";
            this.labelStartGame.Padding = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.labelStartGame.Size = new System.Drawing.Size(140, 49);
            this.labelStartGame.TabIndex = 5;
            this.labelStartGame.Text = "Start Game";
            this.labelStartGame.Click += new System.EventHandler(this.label1_Click);
            // 
            // endGameLabel
            // 
            this.endGameLabel.AutoSize = true;
            this.endGameLabel.BackColor = System.Drawing.Color.LightCoral;
            this.endGameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endGameLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.endGameLabel.Location = new System.Drawing.Point(309, 151);
            this.endGameLabel.Name = "endGameLabel";
            this.endGameLabel.Padding = new System.Windows.Forms.Padding(13, 11, 13, 11);
            this.endGameLabel.Size = new System.Drawing.Size(129, 49);
            this.endGameLabel.TabIndex = 6;
            this.endGameLabel.Text = "Exit Game";
            this.endGameLabel.Click += new System.EventHandler(this.endGameLabel_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(231, 61);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(55, 25);
            this.labelTitle.TabIndex = 7;
            this.labelTitle.Text = "Dino";
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.labelEdition.Location = new System.Drawing.Point(146, 94);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(230, 25);
            this.labelEdition.TabIndex = 8;
            this.labelEdition.Text = "Game of the year edition";
            // 
            // DinoGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(541, 379);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.endGameLabel);
            this.Controls.Add(this.labelStartGame);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.trex);
            this.Controls.Add(this.floor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(557, 418);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(557, 418);
            this.Name = "DinoGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DinoGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox floor;
        private PictureBox trex;
        private PictureBox obstacle1;
        private PictureBox obstacle2;
        private Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private Label labelStartGame;
        private Label endGameLabel;
        private Label labelTitle;
        private Label labelEdition;
    }
}