namespace OOProjektovanje_lab2
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.foemGeneratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.temperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pritisakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vlaznostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.brojPrikaza = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foemGeneratorToolStripMenuItem,
            this.graphMenu,
            this.statisticsToolStripMenuItem,
            this.listFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1194, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // foemGeneratorToolStripMenuItem
            // 
            this.foemGeneratorToolStripMenuItem.Name = "foemGeneratorToolStripMenuItem";
            this.foemGeneratorToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.foemGeneratorToolStripMenuItem.Text = "Form Generator";
            this.foemGeneratorToolStripMenuItem.Click += new System.EventHandler(this.foemGeneratorToolStripMenuItem_Click);
            // 
            // graphMenu
            // 
            this.graphMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.temperatureToolStripMenuItem,
            this.pritisakToolStripMenuItem,
            this.vlaznostToolStripMenuItem,
            this.toolStripSeparator2,
            this.brojPrikaza,
            this.toolStripMenuItem1});
            this.graphMenu.Name = "graphMenu";
            this.graphMenu.Size = new System.Drawing.Size(51, 20);
            this.graphMenu.Text = "Graph";
            // 
            // temperatureToolStripMenuItem
            // 
            this.temperatureToolStripMenuItem.Name = "temperatureToolStripMenuItem";
            this.temperatureToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temperatureToolStripMenuItem.Text = "Temperature";
            this.temperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // pritisakToolStripMenuItem
            // 
            this.pritisakToolStripMenuItem.Name = "pritisakToolStripMenuItem";
            this.pritisakToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pritisakToolStripMenuItem.Text = "Pritisak";
            this.pritisakToolStripMenuItem.Click += new System.EventHandler(this.pritisakToolStripMenuItem_Click);
            // 
            // vlaznostToolStripMenuItem
            // 
            this.vlaznostToolStripMenuItem.Name = "vlaznostToolStripMenuItem";
            this.vlaznostToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vlaznostToolStripMenuItem.Text = "Vlaznost";
            this.vlaznostToolStripMenuItem.Click += new System.EventHandler(this.vlaznostToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // brojPrikaza
            // 
            this.brojPrikaza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brojPrikaza.Name = "brojPrikaza";
            this.brojPrikaza.Size = new System.Drawing.Size(100, 23);
            this.brojPrikaza.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.brojPrikaza_KeyPress);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Enabled = false;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Broj Prikaza";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // listFormToolStripMenuItem
            // 
            this.listFormToolStripMenuItem.Name = "listFormToolStripMenuItem";
            this.listFormToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.listFormToolStripMenuItem.Text = "List Form";
            this.listFormToolStripMenuItem.Click += new System.EventHandler(this.listFormToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 585);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem foemGeneratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphMenu;
        private System.Windows.Forms.ToolStripMenuItem temperatureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pritisakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vlaznostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripTextBox brojPrikaza;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listFormToolStripMenuItem;
    }
}

