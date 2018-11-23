namespace OOProjektovanje_lab2
{
    partial class ListForm
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
            this.grid = new System.Windows.Forms.DataGridView();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.odbacenoBox = new System.Windows.Forms.TextBox();
            this.ListTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(1, 43);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(728, 270);
            this.grid.TabIndex = 0;
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(604, 12);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(57, 20);
            this.intervalBox.TabIndex = 1;
            this.intervalBox.Text = "2";
            this.intervalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.intervalBox_KeyPress);
            // 
            // odbacenoBox
            // 
            this.odbacenoBox.Location = new System.Drawing.Point(604, 319);
            this.odbacenoBox.Name = "odbacenoBox";
            this.odbacenoBox.Size = new System.Drawing.Size(57, 20);
            this.odbacenoBox.TabIndex = 2;
            // 
            // ListTimer
            // 
            this.ListTimer.Enabled = true;
            this.ListTimer.Interval = 1000;
            this.ListTimer.Tick += new System.EventHandler(this.ListTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Timer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.odbacenoBox);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.grid);
            this.Name = "ListForm";
            this.Text = "ListForm";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.TextBox odbacenoBox;
        private System.Windows.Forms.Timer ListTimer;
        private System.Windows.Forms.Button button1;
    }
}