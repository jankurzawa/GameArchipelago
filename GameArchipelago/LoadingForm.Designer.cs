namespace GameArchipelago
{
    partial class LoadingForm
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
            this.progBarLoading = new System.Windows.Forms.ProgressBar();
            this.picBPalGif = new System.Windows.Forms.PictureBox();
            this.barTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBPalGif)).BeginInit();
            this.SuspendLayout();
            // 
            // progBarLoading
            // 
            this.progBarLoading.Location = new System.Drawing.Point(34, 130);
            this.progBarLoading.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progBarLoading.Name = "progBarLoading";
            this.progBarLoading.Size = new System.Drawing.Size(332, 22);
            this.progBarLoading.TabIndex = 0;
            // 
            // picBPalGif
            // 
            this.picBPalGif.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.picBPalGif.Image = global::GameArchipelago.Properties.Resources.Loading;
            this.picBPalGif.Location = new System.Drawing.Point(119, 9);
            this.picBPalGif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBPalGif.Name = "picBPalGif";
            this.picBPalGif.Size = new System.Drawing.Size(158, 104);
            this.picBPalGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBPalGif.TabIndex = 1;
            this.picBPalGif.TabStop = false;
            // 
            // barTimer
            // 
            this.barTimer.Tick += new System.EventHandler(this.TickTimer);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(396, 160);
            this.ControlBox = false;
            this.Controls.Add(this.picBPalGif);
            this.Controls.Add(this.progBarLoading);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.picBPalGif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ProgressBar progBarLoading;
        private PictureBox picBPalGif;
        private System.Windows.Forms.Timer barTimer;
    }
}