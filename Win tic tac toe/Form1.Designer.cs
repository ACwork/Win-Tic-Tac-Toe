using System;

namespace Win_tic_tac_toe
{
    partial class Form1
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
            this.A1 = new System.Windows.Forms.Button();
            this.P1 = new System.Windows.Forms.TextBox();
            this.P2 = new System.Windows.Forms.TextBox();
            this.cntP1 = new System.Windows.Forms.Label();
            this.cntD = new System.Windows.Forms.Label();
            this.cntP2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RESTARTGAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PLAYCOMPUTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RESETWINCOUNTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GET3INAROWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ABOUTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.lblDraws = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.Location = new System.Drawing.Point(12, 27);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(86, 86);
            this.A1.TabIndex = 0;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.Click += new System.EventHandler(this.Button_click);
            this.A1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // P1
            // 
            this.P1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1.Location = new System.Drawing.Point(12, 308);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(86, 24);
            this.P1.TabIndex = 18;
            this.P1.Text = "Player";
            this.P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // P2
            // 
            this.P2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2.Location = new System.Drawing.Point(195, 308);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(86, 24);
            this.P2.TabIndex = 2;
            this.P2.Text = "Computer";
            this.P2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.P2.TextChanged += new System.EventHandler(this.P2_TextChanged);
            // 
            // cntP1
            // 
            this.cntP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntP1.Location = new System.Drawing.Point(27, 336);
            this.cntP1.MaximumSize = new System.Drawing.Size(50, 25);
            this.cntP1.MinimumSize = new System.Drawing.Size(50, 25);
            this.cntP1.Name = "cntP1";
            this.cntP1.Size = new System.Drawing.Size(50, 25);
            this.cntP1.TabIndex = 3;
            this.cntP1.Text = "0";
            this.cntP1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntD
            // 
            this.cntD.AutoSize = true;
            this.cntD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntD.Location = new System.Drawing.Point(119, 336);
            this.cntD.MaximumSize = new System.Drawing.Size(50, 25);
            this.cntD.MinimumSize = new System.Drawing.Size(50, 25);
            this.cntD.Name = "cntD";
            this.cntD.Size = new System.Drawing.Size(50, 25);
            this.cntD.TabIndex = 4;
            this.cntD.Text = "0";
            this.cntD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cntP2
            // 
            this.cntP2.AutoSize = true;
            this.cntP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntP2.Location = new System.Drawing.Point(211, 336);
            this.cntP2.MaximumSize = new System.Drawing.Size(50, 25);
            this.cntP2.MinimumSize = new System.Drawing.Size(50, 25);
            this.cntP2.Name = "cntP2";
            this.cntP2.Size = new System.Drawing.Size(50, 25);
            this.cntP2.TabIndex = 5;
            this.cntP2.Text = "0";
            this.cntP2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FILEToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(291, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FILEToolStripMenuItem
            // 
            this.FILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RESTARTGAMEToolStripMenuItem,
            this.PLAYCOMPUTERToolStripMenuItem,
            this.RESETWINCOUNTToolStripMenuItem,
            this.EXITToolStripMenuItem});
            this.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem";
            this.FILEToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.FILEToolStripMenuItem.Text = "FILE";
            this.FILEToolStripMenuItem.Click += new System.EventHandler(this.fILEToolStripMenuItem_Click);
            // 
            // RESTARTGAMEToolStripMenuItem
            // 
            this.RESTARTGAMEToolStripMenuItem.Name = "RESTARTGAMEToolStripMenuItem";
            this.RESTARTGAMEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RESTARTGAMEToolStripMenuItem.Text = "RESTART GAME";
            this.RESTARTGAMEToolStripMenuItem.Click += new System.EventHandler(this.RESTARTGAMEToolStripMenuItem_Click);
            // 
            // PLAYCOMPUTERToolStripMenuItem
            // 
            this.PLAYCOMPUTERToolStripMenuItem.Name = "PLAYCOMPUTERToolStripMenuItem";
            this.PLAYCOMPUTERToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.PLAYCOMPUTERToolStripMenuItem.Text = "PLAY  COMPUTER";
            this.PLAYCOMPUTERToolStripMenuItem.Click += new System.EventHandler(this.PLAYCOMPUTERToolStripMenuItem_Click);
            // 
            // RESETWINCOUNTToolStripMenuItem
            // 
            this.RESETWINCOUNTToolStripMenuItem.Name = "RESETWINCOUNTToolStripMenuItem";
            this.RESETWINCOUNTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.RESETWINCOUNTToolStripMenuItem.Text = "RESET WIN COUNT";
            this.RESETWINCOUNTToolStripMenuItem.Click += new System.EventHandler(this.RESETWINCOUNTToolStripMenuItem_Click);
            // 
            // EXITToolStripMenuItem
            // 
            this.EXITToolStripMenuItem.Name = "EXITToolStripMenuItem";
            this.EXITToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EXITToolStripMenuItem.Text = "EXIT";
            this.EXITToolStripMenuItem.Click += new System.EventHandler(this.EXITToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GET3INAROWToolStripMenuItem,
            this.ABOUTToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.helpToolStripMenuItem.Text = "HELP";
            // 
            // GET3INAROWToolStripMenuItem
            // 
            this.GET3INAROWToolStripMenuItem.Name = "GET3INAROWToolStripMenuItem";
            this.GET3INAROWToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GET3INAROWToolStripMenuItem.Text = "HOW TO PLAY";
            this.GET3INAROWToolStripMenuItem.Click += new System.EventHandler(this.GET3INAROWToolStripMenuItem_Click);
            // 
            // ABOUTToolStripMenuItem
            // 
            this.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem";
            this.ABOUTToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ABOUTToolStripMenuItem.Text = "ABOUT";
            this.ABOUTToolStripMenuItem.Click += new System.EventHandler(this.ABOUTToolStripMenuItem_Click);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A2.Location = new System.Drawing.Point(104, 27);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(86, 86);
            this.A2.TabIndex = 8;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.Button_click);
            this.A2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A3.Location = new System.Drawing.Point(196, 27);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(86, 86);
            this.A3.TabIndex = 9;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.Button_click);
            this.A3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.A3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(12, 119);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(86, 86);
            this.B1.TabIndex = 10;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Button_click);
            this.B1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B2.Location = new System.Drawing.Point(104, 119);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(86, 86);
            this.B2.TabIndex = 11;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Button_click);
            this.B2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B3.Location = new System.Drawing.Point(196, 119);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(86, 86);
            this.B3.TabIndex = 12;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Button_click);
            this.B3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.B3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C1.Location = new System.Drawing.Point(12, 211);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(86, 86);
            this.C1.TabIndex = 13;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.Button_click);
            this.C1.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C1.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C2.Location = new System.Drawing.Point(104, 211);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(86, 86);
            this.C2.TabIndex = 14;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.Button_click);
            this.C2.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C2.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C3.Location = new System.Drawing.Point(196, 211);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(86, 86);
            this.C3.TabIndex = 15;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.Button_click);
            this.C3.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.C3.MouseLeave += new System.EventHandler(this.Button_Leave);
            // 
            // lblDraws
            // 
            this.lblDraws.AutoSize = true;
            this.lblDraws.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraws.Location = new System.Drawing.Point(117, 310);
            this.lblDraws.MaximumSize = new System.Drawing.Size(60, 20);
            this.lblDraws.MinimumSize = new System.Drawing.Size(60, 20);
            this.lblDraws.Name = "lblDraws";
            this.lblDraws.Size = new System.Drawing.Size(60, 20);
            this.lblDraws.TabIndex = 17;
            this.lblDraws.Text = "Draws";
            this.lblDraws.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 366);
            this.Controls.Add(this.lblDraws);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.cntP1);
            this.Controls.Add(this.cntD);
            this.Controls.Add(this.cntP2);
            this.Controls.Add(this.P1);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(307, 405);
            this.MinimumSize = new System.Drawing.Size(307, 405);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WIN TIC TAC TOE";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void button_enter(object sender, EventArgs e)
        {
            
        }
        
        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.TextBox P1;
        private System.Windows.Forms.TextBox P2;
        private System.Windows.Forms.Label cntP1;
        private System.Windows.Forms.Label cntD;
        private System.Windows.Forms.Label cntP2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RESTARTGAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PLAYCOMPUTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EXITToolStripMenuItem;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GET3INAROWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ABOUTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RESETWINCOUNTToolStripMenuItem;
        private System.Windows.Forms.Label lblDraws;
    }
}

