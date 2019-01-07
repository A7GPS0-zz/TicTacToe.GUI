namespace TicTacToe.GUI
{
    partial class FormTicTacToe
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Field1 = new System.Windows.Forms.Button();
            this.btn_Field2 = new System.Windows.Forms.Button();
            this.btn_Field3 = new System.Windows.Forms.Button();
            this.btn_Field4 = new System.Windows.Forms.Button();
            this.btn_Field5 = new System.Windows.Forms.Button();
            this.btn_Field6 = new System.Windows.Forms.Button();
            this.btn_Field7 = new System.Windows.Forms.Button();
            this.btn_Field8 = new System.Windows.Forms.Button();
            this.btn_Field9 = new System.Windows.Forms.Button();
            this.ssPlayerInfo = new System.Windows.Forms.StatusStrip();
            this.tsslPlayerInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslAktuellerSpieler = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslPunkte = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.ssPlayerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Field9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Field8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Field7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_Field6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Field5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Field4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Field3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Field2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Field1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 236);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_Field1
            // 
            this.btn_Field1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field1.Location = new System.Drawing.Point(3, 3);
            this.btn_Field1.Name = "btn_Field1";
            this.btn_Field1.Size = new System.Drawing.Size(88, 72);
            this.btn_Field1.TabIndex = 0;
            this.btn_Field1.UseVisualStyleBackColor = true;
            this.btn_Field1.Click += new System.EventHandler(this.btn_Field1_Click);
            // 
            // btn_Field2
            // 
            this.btn_Field2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field2.Location = new System.Drawing.Point(97, 3);
            this.btn_Field2.Name = "btn_Field2";
            this.btn_Field2.Size = new System.Drawing.Size(88, 72);
            this.btn_Field2.TabIndex = 1;
            this.btn_Field2.UseVisualStyleBackColor = true;
            this.btn_Field2.Click += new System.EventHandler(this.btn_Field2_Click);
            // 
            // btn_Field3
            // 
            this.btn_Field3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field3.Location = new System.Drawing.Point(191, 3);
            this.btn_Field3.Name = "btn_Field3";
            this.btn_Field3.Size = new System.Drawing.Size(90, 72);
            this.btn_Field3.TabIndex = 2;
            this.btn_Field3.UseVisualStyleBackColor = true;
            this.btn_Field3.Click += new System.EventHandler(this.btn_Field3_Click);
            // 
            // btn_Field4
            // 
            this.btn_Field4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field4.Location = new System.Drawing.Point(3, 81);
            this.btn_Field4.Name = "btn_Field4";
            this.btn_Field4.Size = new System.Drawing.Size(88, 72);
            this.btn_Field4.TabIndex = 3;
            this.btn_Field4.UseVisualStyleBackColor = true;
            this.btn_Field4.Click += new System.EventHandler(this.btn_Field4_Click);
            // 
            // btn_Field5
            // 
            this.btn_Field5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field5.Location = new System.Drawing.Point(97, 81);
            this.btn_Field5.Name = "btn_Field5";
            this.btn_Field5.Size = new System.Drawing.Size(88, 72);
            this.btn_Field5.TabIndex = 4;
            this.btn_Field5.UseVisualStyleBackColor = true;
            this.btn_Field5.Click += new System.EventHandler(this.btn_Field5_Click);
            // 
            // btn_Field6
            // 
            this.btn_Field6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field6.Location = new System.Drawing.Point(191, 81);
            this.btn_Field6.Name = "btn_Field6";
            this.btn_Field6.Size = new System.Drawing.Size(90, 72);
            this.btn_Field6.TabIndex = 5;
            this.btn_Field6.UseVisualStyleBackColor = true;
            this.btn_Field6.Click += new System.EventHandler(this.btn_Field6_Click);
            // 
            // btn_Field7
            // 
            this.btn_Field7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field7.Location = new System.Drawing.Point(3, 159);
            this.btn_Field7.Name = "btn_Field7";
            this.btn_Field7.Size = new System.Drawing.Size(88, 74);
            this.btn_Field7.TabIndex = 6;
            this.btn_Field7.UseVisualStyleBackColor = true;
            this.btn_Field7.Click += new System.EventHandler(this.btn_Field7_Click);
            // 
            // btn_Field8
            // 
            this.btn_Field8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field8.Location = new System.Drawing.Point(97, 159);
            this.btn_Field8.Name = "btn_Field8";
            this.btn_Field8.Size = new System.Drawing.Size(88, 74);
            this.btn_Field8.TabIndex = 7;
            this.btn_Field8.UseVisualStyleBackColor = true;
            this.btn_Field8.Click += new System.EventHandler(this.btn_Field8_Click);
            // 
            // btn_Field9
            // 
            this.btn_Field9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Field9.Location = new System.Drawing.Point(191, 159);
            this.btn_Field9.Name = "btn_Field9";
            this.btn_Field9.Size = new System.Drawing.Size(90, 74);
            this.btn_Field9.TabIndex = 8;
            this.btn_Field9.UseVisualStyleBackColor = true;
            this.btn_Field9.Click += new System.EventHandler(this.btn_Field9_Click);
            // 
            // ssPlayerInfo
            // 
            this.ssPlayerInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslPlayerInfo,
            this.tsslAktuellerSpieler,
            this.tsslPunkte});
            this.ssPlayerInfo.Location = new System.Drawing.Point(0, 239);
            this.ssPlayerInfo.Name = "ssPlayerInfo";
            this.ssPlayerInfo.Size = new System.Drawing.Size(284, 22);
            this.ssPlayerInfo.TabIndex = 1;
            // 
            // tsslPlayerInfo
            // 
            this.tsslPlayerInfo.Name = "tsslPlayerInfo";
            this.tsslPlayerInfo.Size = new System.Drawing.Size(95, 17);
            this.tsslPlayerInfo.Text = "Aktueller Spieler:";
            // 
            // tsslAktuellerSpieler
            // 
            this.tsslAktuellerSpieler.Name = "tsslAktuellerSpieler";
            this.tsslAktuellerSpieler.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslPunkte
            // 
            this.tsslPunkte.Name = "tsslPunkte";
            this.tsslPunkte.Size = new System.Drawing.Size(22, 17);
            this.tsslPunkte.Text = "0:0";
            // 
            // FormTicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ssPlayerInfo);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTicTacToe";
            this.Text = "TicTacToe";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ssPlayerInfo.ResumeLayout(false);
            this.ssPlayerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_Field1;
        private System.Windows.Forms.Button btn_Field9;
        private System.Windows.Forms.Button btn_Field8;
        private System.Windows.Forms.Button btn_Field7;
        private System.Windows.Forms.Button btn_Field6;
        private System.Windows.Forms.Button btn_Field5;
        private System.Windows.Forms.Button btn_Field4;
        private System.Windows.Forms.Button btn_Field3;
        private System.Windows.Forms.Button btn_Field2;
        private System.Windows.Forms.StatusStrip ssPlayerInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslPlayerInfo;
        private System.Windows.Forms.ToolStripStatusLabel tsslAktuellerSpieler;
        private System.Windows.Forms.ToolStripStatusLabel tsslPunkte;
    }
}

