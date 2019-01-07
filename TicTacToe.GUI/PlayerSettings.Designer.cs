namespace TicTacToe.GUI
{
    partial class PlayerSettings
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
            this.btnStart = new System.Windows.Forms.Button();
            this.txtPlayer1 = new System.Windows.Forms.TextBox();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.txtPlayer2 = new System.Windows.Forms.TextBox();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1Start = new System.Windows.Forms.Label();
            this.chkBoxSpieler1Start = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(94, 167);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Spiel Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtPlayer1
            // 
            this.txtPlayer1.Location = new System.Drawing.Point(116, 48);
            this.txtPlayer1.Name = "txtPlayer1";
            this.txtPlayer1.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer1.TabIndex = 1;
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Location = new System.Drawing.Point(9, 55);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(51, 13);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Spieler 1:";
            // 
            // txtPlayer2
            // 
            this.txtPlayer2.Location = new System.Drawing.Point(116, 93);
            this.txtPlayer2.Name = "txtPlayer2";
            this.txtPlayer2.Size = new System.Drawing.Size(100, 20);
            this.txtPlayer2.TabIndex = 3;
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Location = new System.Drawing.Point(12, 99);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(51, 13);
            this.lblPlayer2.TabIndex = 4;
            this.lblPlayer2.Text = "Spieler 2:";
            // 
            // lblPlayer1Start
            // 
            this.lblPlayer1Start.AutoSize = true;
            this.lblPlayer1Start.Location = new System.Drawing.Point(9, 141);
            this.lblPlayer1Start.Name = "lblPlayer1Start";
            this.lblPlayer1Start.Size = new System.Drawing.Size(92, 13);
            this.lblPlayer1Start.TabIndex = 5;
            this.lblPlayer1Start.Text = "Spieler 1 beginnt?";
            // 
            // chkBoxSpieler1Start
            // 
            this.chkBoxSpieler1Start.AutoSize = true;
            this.chkBoxSpieler1Start.Location = new System.Drawing.Point(116, 137);
            this.chkBoxSpieler1Start.Name = "chkBoxSpieler1Start";
            this.chkBoxSpieler1Start.Size = new System.Drawing.Size(37, 17);
            this.chkBoxSpieler1Start.TabIndex = 6;
            this.chkBoxSpieler1Start.Text = "Ja";
            this.chkBoxSpieler1Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkBoxSpieler1Start.UseVisualStyleBackColor = true;
            // 
            // PlayerSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 202);
            this.Controls.Add(this.chkBoxSpieler1Start);
            this.Controls.Add(this.lblPlayer1Start);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.txtPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.txtPlayer1);
            this.Controls.Add(this.btnStart);
            this.Name = "PlayerSettings";
            this.Text = "PlayerSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.TextBox txtPlayer1;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.TextBox txtPlayer2;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1Start;
        private System.Windows.Forms.CheckBox chkBoxSpieler1Start;
    }
}