namespace GameArchipelago.Forms
{
    partial class Wordle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wordle));
            this.btnA = new System.Windows.Forms.Button();
            this.plKeyboard = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnZ = new System.Windows.Forms.Button();
            this.btnR = new System.Windows.Forms.Button();
            this.btnQ = new System.Windows.Forms.Button();
            this.btnI = new System.Windows.Forms.Button();
            this.btnH = new System.Windows.Forms.Button();
            this.btnY = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            this.btnP = new System.Windows.Forms.Button();
            this.btnW = new System.Windows.Forms.Button();
            this.btnG = new System.Windows.Forms.Button();
            this.btnO = new System.Windows.Forms.Button();
            this.btnV = new System.Windows.Forms.Button();
            this.btnF = new System.Windows.Forms.Button();
            this.btnN = new System.Windows.Forms.Button();
            this.btnM = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnU = new System.Windows.Forms.Button();
            this.btnL = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnT = new System.Windows.Forms.Button();
            this.btnK = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnS = new System.Windows.Forms.Button();
            this.btnJ = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.plWord = new System.Windows.Forms.Panel();
            this.lblWord1 = new System.Windows.Forms.Label();
            this.lblWord2 = new System.Windows.Forms.Label();
            this.lblWord3 = new System.Windows.Forms.Label();
            this.lblWord4 = new System.Windows.Forms.Label();
            this.lblWord5 = new System.Windows.Forms.Label();
            this.plInput = new System.Windows.Forms.Panel();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblInput2 = new System.Windows.Forms.Label();
            this.lblInput3 = new System.Windows.Forms.Label();
            this.lblInput4 = new System.Windows.Forms.Label();
            this.lblInput5 = new System.Windows.Forms.Label();
            this.lbTurnsAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plKeyboard.SuspendLayout();
            this.plWord.SuspendLayout();
            this.plInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(3, 2);
            this.btnA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(44, 38);
            this.btnA.TabIndex = 0;
            this.btnA.Tag = "A";
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // plKeyboard
            // 
            this.plKeyboard.Controls.Add(this.btnBack);
            this.plKeyboard.Controls.Add(this.btnZ);
            this.plKeyboard.Controls.Add(this.btnR);
            this.plKeyboard.Controls.Add(this.btnQ);
            this.plKeyboard.Controls.Add(this.btnI);
            this.plKeyboard.Controls.Add(this.btnH);
            this.plKeyboard.Controls.Add(this.btnY);
            this.plKeyboard.Controls.Add(this.btnX);
            this.plKeyboard.Controls.Add(this.btnP);
            this.plKeyboard.Controls.Add(this.btnW);
            this.plKeyboard.Controls.Add(this.btnG);
            this.plKeyboard.Controls.Add(this.btnO);
            this.plKeyboard.Controls.Add(this.btnV);
            this.plKeyboard.Controls.Add(this.btnF);
            this.plKeyboard.Controls.Add(this.btnN);
            this.plKeyboard.Controls.Add(this.btnM);
            this.plKeyboard.Controls.Add(this.btnE);
            this.plKeyboard.Controls.Add(this.btnD);
            this.plKeyboard.Controls.Add(this.btnU);
            this.plKeyboard.Controls.Add(this.btnL);
            this.plKeyboard.Controls.Add(this.btnC);
            this.plKeyboard.Controls.Add(this.btnT);
            this.plKeyboard.Controls.Add(this.btnK);
            this.plKeyboard.Controls.Add(this.btnB);
            this.plKeyboard.Controls.Add(this.btnS);
            this.plKeyboard.Controls.Add(this.btnJ);
            this.plKeyboard.Controls.Add(this.btnA);
            this.plKeyboard.Location = new System.Drawing.Point(10, 205);
            this.plKeyboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plKeyboard.Name = "plKeyboard";
            this.plKeyboard.Size = new System.Drawing.Size(443, 124);
            this.plKeyboard.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(395, 84);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 38);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBackspace_Click);
            // 
            // btnZ
            // 
            this.btnZ.Location = new System.Drawing.Point(346, 84);
            this.btnZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnZ.Name = "btnZ";
            this.btnZ.Size = new System.Drawing.Size(44, 38);
            this.btnZ.TabIndex = 14;
            this.btnZ.Tag = "Z";
            this.btnZ.Text = "Z";
            this.btnZ.UseVisualStyleBackColor = true;
            this.btnZ.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnR
            // 
            this.btnR.Location = new System.Drawing.Point(395, 44);
            this.btnR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnR.Name = "btnR";
            this.btnR.Size = new System.Drawing.Size(44, 38);
            this.btnR.TabIndex = 4;
            this.btnR.Tag = "R";
            this.btnR.Text = "R";
            this.btnR.UseVisualStyleBackColor = true;
            this.btnR.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnQ
            // 
            this.btnQ.Location = new System.Drawing.Point(346, 44);
            this.btnQ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQ.Name = "btnQ";
            this.btnQ.Size = new System.Drawing.Size(44, 38);
            this.btnQ.TabIndex = 13;
            this.btnQ.Tag = "Q";
            this.btnQ.Text = "Q";
            this.btnQ.UseVisualStyleBackColor = true;
            this.btnQ.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnI
            // 
            this.btnI.Location = new System.Drawing.Point(395, 2);
            this.btnI.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(44, 38);
            this.btnI.TabIndex = 3;
            this.btnI.Tag = "I";
            this.btnI.Text = "I";
            this.btnI.UseVisualStyleBackColor = true;
            this.btnI.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnH
            // 
            this.btnH.Location = new System.Drawing.Point(346, 2);
            this.btnH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(44, 38);
            this.btnH.TabIndex = 12;
            this.btnH.Tag = "H";
            this.btnH.Text = "H";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnY
            // 
            this.btnY.Location = new System.Drawing.Point(297, 84);
            this.btnY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnY.Name = "btnY";
            this.btnY.Size = new System.Drawing.Size(44, 38);
            this.btnY.TabIndex = 5;
            this.btnY.Tag = "Y";
            this.btnY.Text = "Y";
            this.btnY.UseVisualStyleBackColor = true;
            this.btnY.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnX
            // 
            this.btnX.Location = new System.Drawing.Point(248, 84);
            this.btnX.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(44, 38);
            this.btnX.TabIndex = 5;
            this.btnX.Tag = "X";
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnP
            // 
            this.btnP.Location = new System.Drawing.Point(297, 44);
            this.btnP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnP.Name = "btnP";
            this.btnP.Size = new System.Drawing.Size(44, 38);
            this.btnP.TabIndex = 4;
            this.btnP.Tag = "P";
            this.btnP.Text = "P";
            this.btnP.UseVisualStyleBackColor = true;
            this.btnP.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnW
            // 
            this.btnW.Location = new System.Drawing.Point(199, 84);
            this.btnW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnW.Name = "btnW";
            this.btnW.Size = new System.Drawing.Size(44, 38);
            this.btnW.TabIndex = 5;
            this.btnW.Tag = "W";
            this.btnW.Text = "W";
            this.btnW.UseVisualStyleBackColor = true;
            this.btnW.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnG
            // 
            this.btnG.Location = new System.Drawing.Point(297, 2);
            this.btnG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnG.Name = "btnG";
            this.btnG.Size = new System.Drawing.Size(44, 38);
            this.btnG.TabIndex = 3;
            this.btnG.Tag = "G";
            this.btnG.Text = "G";
            this.btnG.UseVisualStyleBackColor = true;
            this.btnG.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnO
            // 
            this.btnO.Location = new System.Drawing.Point(248, 44);
            this.btnO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnO.Name = "btnO";
            this.btnO.Size = new System.Drawing.Size(44, 38);
            this.btnO.TabIndex = 4;
            this.btnO.Tag = "O";
            this.btnO.Text = "O";
            this.btnO.UseVisualStyleBackColor = true;
            this.btnO.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnV
            // 
            this.btnV.Location = new System.Drawing.Point(150, 84);
            this.btnV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnV.Name = "btnV";
            this.btnV.Size = new System.Drawing.Size(44, 38);
            this.btnV.TabIndex = 11;
            this.btnV.Tag = "V";
            this.btnV.Text = "V";
            this.btnV.UseVisualStyleBackColor = true;
            this.btnV.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnF
            // 
            this.btnF.Location = new System.Drawing.Point(248, 2);
            this.btnF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnF.Name = "btnF";
            this.btnF.Size = new System.Drawing.Size(44, 38);
            this.btnF.TabIndex = 3;
            this.btnF.Tag = "F";
            this.btnF.Text = "F";
            this.btnF.UseVisualStyleBackColor = true;
            this.btnF.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnN
            // 
            this.btnN.Location = new System.Drawing.Point(199, 44);
            this.btnN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnN.Name = "btnN";
            this.btnN.Size = new System.Drawing.Size(44, 38);
            this.btnN.TabIndex = 4;
            this.btnN.Tag = "N";
            this.btnN.Text = "N";
            this.btnN.UseVisualStyleBackColor = true;
            this.btnN.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnM
            // 
            this.btnM.Location = new System.Drawing.Point(150, 44);
            this.btnM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnM.Name = "btnM";
            this.btnM.Size = new System.Drawing.Size(44, 38);
            this.btnM.TabIndex = 10;
            this.btnM.Tag = "M";
            this.btnM.Text = "M";
            this.btnM.UseVisualStyleBackColor = true;
            this.btnM.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnE
            // 
            this.btnE.Location = new System.Drawing.Point(199, 2);
            this.btnE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(44, 38);
            this.btnE.TabIndex = 3;
            this.btnE.Tag = "E";
            this.btnE.Text = "E";
            this.btnE.UseVisualStyleBackColor = true;
            this.btnE.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(150, 2);
            this.btnD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(44, 38);
            this.btnD.TabIndex = 9;
            this.btnD.Tag = "D";
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnU
            // 
            this.btnU.Location = new System.Drawing.Point(101, 84);
            this.btnU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnU.Name = "btnU";
            this.btnU.Size = new System.Drawing.Size(44, 38);
            this.btnU.TabIndex = 8;
            this.btnU.Tag = "U";
            this.btnU.Text = "U";
            this.btnU.UseVisualStyleBackColor = true;
            this.btnU.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnL
            // 
            this.btnL.Location = new System.Drawing.Point(101, 44);
            this.btnL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnL.Name = "btnL";
            this.btnL.Size = new System.Drawing.Size(44, 38);
            this.btnL.TabIndex = 7;
            this.btnL.Tag = "L";
            this.btnL.Text = "L";
            this.btnL.UseVisualStyleBackColor = true;
            this.btnL.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(101, 2);
            this.btnC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(44, 38);
            this.btnC.TabIndex = 6;
            this.btnC.Tag = "C";
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnT
            // 
            this.btnT.Location = new System.Drawing.Point(52, 84);
            this.btnT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnT.Name = "btnT";
            this.btnT.Size = new System.Drawing.Size(44, 38);
            this.btnT.TabIndex = 5;
            this.btnT.Tag = "T";
            this.btnT.Text = "T";
            this.btnT.UseVisualStyleBackColor = true;
            this.btnT.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnK
            // 
            this.btnK.Location = new System.Drawing.Point(52, 44);
            this.btnK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnK.Name = "btnK";
            this.btnK.Size = new System.Drawing.Size(44, 38);
            this.btnK.TabIndex = 4;
            this.btnK.Tag = "K";
            this.btnK.Text = "K";
            this.btnK.UseVisualStyleBackColor = true;
            this.btnK.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(52, 2);
            this.btnB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(44, 38);
            this.btnB.TabIndex = 3;
            this.btnB.Tag = "B";
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(3, 84);
            this.btnS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(44, 38);
            this.btnS.TabIndex = 2;
            this.btnS.Tag = "S";
            this.btnS.Text = "S";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnJ
            // 
            this.btnJ.Location = new System.Drawing.Point(3, 44);
            this.btnJ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnJ.Name = "btnJ";
            this.btnJ.Size = new System.Drawing.Size(44, 38);
            this.btnJ.TabIndex = 1;
            this.btnJ.Tag = "J";
            this.btnJ.Text = "J";
            this.btnJ.UseVisualStyleBackColor = true;
            this.btnJ.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Enabled = false;
            this.btnReturn.Location = new System.Drawing.Point(13, 167);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(436, 33);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Check";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plWord
            // 
            this.plWord.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.plWord.Controls.Add(this.lblWord1);
            this.plWord.Controls.Add(this.lblWord2);
            this.plWord.Controls.Add(this.lblWord3);
            this.plWord.Controls.Add(this.lblWord4);
            this.plWord.Controls.Add(this.lblWord5);
            this.plWord.Location = new System.Drawing.Point(118, 9);
            this.plWord.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plWord.Name = "plWord";
            this.plWord.Size = new System.Drawing.Size(282, 70);
            this.plWord.TabIndex = 14;
            // 
            // lblWord1
            // 
            this.lblWord1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWord1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWord1.Location = new System.Drawing.Point(0, 13);
            this.lblWord1.Name = "lblWord1";
            this.lblWord1.Size = new System.Drawing.Size(53, 46);
            this.lblWord1.TabIndex = 8;
            this.lblWord1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord2
            // 
            this.lblWord2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWord2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWord2.Location = new System.Drawing.Point(58, 13);
            this.lblWord2.Name = "lblWord2";
            this.lblWord2.Size = new System.Drawing.Size(53, 46);
            this.lblWord2.TabIndex = 9;
            this.lblWord2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord3
            // 
            this.lblWord3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWord3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWord3.Location = new System.Drawing.Point(116, 13);
            this.lblWord3.Name = "lblWord3";
            this.lblWord3.Size = new System.Drawing.Size(53, 46);
            this.lblWord3.TabIndex = 10;
            this.lblWord3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord4
            // 
            this.lblWord4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWord4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWord4.Location = new System.Drawing.Point(173, 13);
            this.lblWord4.Name = "lblWord4";
            this.lblWord4.Size = new System.Drawing.Size(53, 46);
            this.lblWord4.TabIndex = 11;
            this.lblWord4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWord5
            // 
            this.lblWord5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblWord5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWord5.Location = new System.Drawing.Point(229, 13);
            this.lblWord5.Name = "lblWord5";
            this.lblWord5.Size = new System.Drawing.Size(53, 46);
            this.lblWord5.TabIndex = 12;
            this.lblWord5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plInput
            // 
            this.plInput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.plInput.Controls.Add(this.lblInput1);
            this.plInput.Controls.Add(this.lblInput2);
            this.plInput.Controls.Add(this.lblInput3);
            this.plInput.Controls.Add(this.lblInput4);
            this.plInput.Controls.Add(this.lblInput5);
            this.plInput.Location = new System.Drawing.Point(118, 83);
            this.plInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plInput.Name = "plInput";
            this.plInput.Size = new System.Drawing.Size(282, 70);
            this.plInput.TabIndex = 15;
            // 
            // lblInput1
            // 
            this.lblInput1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInput1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput1.Location = new System.Drawing.Point(0, 14);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(53, 46);
            this.lblInput1.TabIndex = 9;
            this.lblInput1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput2
            // 
            this.lblInput2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInput2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput2.Location = new System.Drawing.Point(58, 14);
            this.lblInput2.Name = "lblInput2";
            this.lblInput2.Size = new System.Drawing.Size(53, 46);
            this.lblInput2.TabIndex = 10;
            this.lblInput2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput3
            // 
            this.lblInput3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInput3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput3.Location = new System.Drawing.Point(116, 14);
            this.lblInput3.Name = "lblInput3";
            this.lblInput3.Size = new System.Drawing.Size(53, 46);
            this.lblInput3.TabIndex = 11;
            this.lblInput3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput4
            // 
            this.lblInput4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInput4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput4.Location = new System.Drawing.Point(173, 14);
            this.lblInput4.Name = "lblInput4";
            this.lblInput4.Size = new System.Drawing.Size(53, 46);
            this.lblInput4.TabIndex = 12;
            this.lblInput4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInput5
            // 
            this.lblInput5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblInput5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblInput5.Location = new System.Drawing.Point(229, 14);
            this.lblInput5.Name = "lblInput5";
            this.lblInput5.Size = new System.Drawing.Size(53, 46);
            this.lblInput5.TabIndex = 13;
            this.lblInput5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTurnsAmount
            // 
            this.lbTurnsAmount.AutoSize = true;
            this.lbTurnsAmount.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbTurnsAmount.Location = new System.Drawing.Point(33, 68);
            this.lbTurnsAmount.Name = "lbTurnsAmount";
            this.lbTurnsAmount.Size = new System.Drawing.Size(56, 65);
            this.lbTurnsAmount.TabIndex = 17;
            this.lbTurnsAmount.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 42);
            this.label1.TabIndex = 18;
            this.label1.Text = "Turns\r\nremaining";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Wordle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(458, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTurnsAmount);
            this.Controls.Add(this.plInput);
            this.Controls.Add(this.plWord);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.plKeyboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(474, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(474, 375);
            this.Name = "Wordle";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Wordle";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Wordle_KeyUp);
            this.plKeyboard.ResumeLayout(false);
            this.plWord.ResumeLayout(false);
            this.plInput.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnReturn;
        private Button btnA;
        private Panel plKeyboard;
        private Button btnBack;
        private Button btnZ;
        private Button btnR;
        private Button btnQ;
        private Button btnI;
        private Button btnH;
        private Button btnY;
        private Button btnX;
        private Button btnP;
        private Button btnW;
        private Button btnG;
        private Button btnO;
        private Button btnV;
        private Button btnF;
        private Button btnN;
        private Button btnM;
        private Button btnE;
        private Button btnD;
        private Button btnU;
        private Button btnL;
        private Button btnC;
        private Button btnT;
        private Button btnK;
        private Button btnB;
        private Button btnS;
        private Button btnJ;
        private Panel plWord;
        private Label lblWord1;
        private Label lblWord2;
        private Label lblWord3;
        private Label lblWord4;
        private Label lblWord5;
        private Panel plInput;
        private Label lblInput1;
        private Label lblInput2;
        private Label lblInput3;
        private Label lblInput4;
        private Label lblInput5;
        private Label lbTurnsAmount;
        private Label label1;
    }
}