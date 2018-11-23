namespace OOProjektovanje_lab2
{
    partial class FormGenerator
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
            this.label1 = new System.Windows.Forms.Label();
            this.tempTxtBox = new System.Windows.Forms.TextBox();
            this.tempBtn = new System.Windows.Forms.Button();
            this.presBtn = new System.Windows.Forms.Button();
            this.presTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vlaBtn = new System.Windows.Forms.Button();
            this.vlazTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sendButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.graniceChek = new System.Windows.Forms.CheckBox();
            this.intervalCheck = new System.Windows.Forms.CheckBox();
            this.intervalBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // tempTxtBox
            // 
            this.tempTxtBox.Location = new System.Drawing.Point(114, 40);
            this.tempTxtBox.Name = "tempTxtBox";
            this.tempTxtBox.Size = new System.Drawing.Size(270, 20);
            this.tempTxtBox.TabIndex = 1;
            // 
            // tempBtn
            // 
            this.tempBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempBtn.Location = new System.Drawing.Point(408, 32);
            this.tempBtn.Name = "tempBtn";
            this.tempBtn.Size = new System.Drawing.Size(33, 28);
            this.tempBtn.TabIndex = 2;
            this.tempBtn.Text = "*";
            this.tempBtn.UseVisualStyleBackColor = true;
            this.tempBtn.Click += new System.EventHandler(this.tempBtn_Click);
            // 
            // presBtn
            // 
            this.presBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presBtn.Location = new System.Drawing.Point(408, 89);
            this.presBtn.Name = "presBtn";
            this.presBtn.Size = new System.Drawing.Size(33, 28);
            this.presBtn.TabIndex = 5;
            this.presBtn.Text = "*";
            this.presBtn.UseVisualStyleBackColor = true;
            this.presBtn.Click += new System.EventHandler(this.presBtn_Click);
            // 
            // presTxtBox
            // 
            this.presTxtBox.Location = new System.Drawing.Point(114, 97);
            this.presTxtBox.Name = "presTxtBox";
            this.presTxtBox.Size = new System.Drawing.Size(270, 20);
            this.presTxtBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Pritisak";
            // 
            // vlaBtn
            // 
            this.vlaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vlaBtn.Location = new System.Drawing.Point(408, 148);
            this.vlaBtn.Name = "vlaBtn";
            this.vlaBtn.Size = new System.Drawing.Size(33, 28);
            this.vlaBtn.TabIndex = 8;
            this.vlaBtn.Text = "*";
            this.vlaBtn.UseVisualStyleBackColor = true;
            this.vlaBtn.Click += new System.EventHandler(this.vlaBtn_Click);
            // 
            // vlazTxtBox
            // 
            this.vlazTxtBox.Location = new System.Drawing.Point(114, 156);
            this.vlazTxtBox.Name = "vlazTxtBox";
            this.vlazTxtBox.Size = new System.Drawing.Size(270, 20);
            this.vlazTxtBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Vlaznost";
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(143, 195);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(213, 39);
            this.sendButton.TabIndex = 9;
            this.sendButton.Text = "Prosledi";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(408, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 31);
            this.button2.TabIndex = 10;
            this.button2.Text = "breakPoint";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // graniceChek
            // 
            this.graniceChek.AutoSize = true;
            this.graniceChek.Location = new System.Drawing.Point(13, 249);
            this.graniceChek.Name = "graniceChek";
            this.graniceChek.Size = new System.Drawing.Size(164, 17);
            this.graniceChek.TabIndex = 11;
            this.graniceChek.Text = "Ignorisi vrednosti van granica";
            this.graniceChek.UseVisualStyleBackColor = true;
            // 
            // intervalCheck
            // 
            this.intervalCheck.AutoSize = true;
            this.intervalCheck.Location = new System.Drawing.Point(13, 285);
            this.intervalCheck.Name = "intervalCheck";
            this.intervalCheck.Size = new System.Drawing.Size(139, 17);
            this.intervalCheck.TabIndex = 12;
            this.intervalCheck.Text = "Automacko Generisanje";
            this.intervalCheck.UseVisualStyleBackColor = true;
            this.intervalCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // intervalBox
            // 
            this.intervalBox.Location = new System.Drawing.Point(187, 282);
            this.intervalBox.Name = "intervalBox";
            this.intervalBox.Size = new System.Drawing.Size(31, 20);
            this.intervalBox.TabIndex = 13;
            this.intervalBox.Text = "1";
            this.intervalBox.TextChanged += new System.EventHandler(this.intervalBox_TextChanged);
            this.intervalBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 31);
            this.button1.TabIndex = 14;
            this.button1.Text = "Read from";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.intervalBox);
            this.Controls.Add(this.intervalCheck);
            this.Controls.Add(this.graniceChek);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.vlaBtn);
            this.Controls.Add(this.vlazTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.presBtn);
            this.Controls.Add(this.presTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tempBtn);
            this.Controls.Add(this.tempTxtBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormGenerator";
            this.Text = "FormGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tempTxtBox;
        private System.Windows.Forms.Button tempBtn;
        private System.Windows.Forms.Button presBtn;
        private System.Windows.Forms.TextBox presTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vlaBtn;
        private System.Windows.Forms.TextBox vlazTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox graniceChek;
        private System.Windows.Forms.CheckBox intervalCheck;
        private System.Windows.Forms.TextBox intervalBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button button1;
    }
}