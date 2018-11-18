namespace OOProjektovanje_lab2
{
    partial class FormStatisticalData
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.PressLabel = new System.Windows.Forms.Label();
            this.humLabel = new System.Windows.Forms.Label();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.pressTexBox = new System.Windows.Forms.TextBox();
            this.humidityTextBox = new System.Windows.Forms.TextBox();
            this.lastCheck = new System.Windows.Forms.CheckBox();
            this.lastTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priitisak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Vlaznost";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLabel.Location = new System.Drawing.Point(398, 31);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(90, 24);
            this.tempLabel.TabIndex = 3;
            this.tempLabel.Text = "Unknown";
            // 
            // PressLabel
            // 
            this.PressLabel.AutoSize = true;
            this.PressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressLabel.Location = new System.Drawing.Point(398, 87);
            this.PressLabel.Name = "PressLabel";
            this.PressLabel.Size = new System.Drawing.Size(90, 24);
            this.PressLabel.TabIndex = 4;
            this.PressLabel.Text = "Unknown";
            // 
            // humLabel
            // 
            this.humLabel.AutoSize = true;
            this.humLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humLabel.Location = new System.Drawing.Point(398, 149);
            this.humLabel.Name = "humLabel";
            this.humLabel.Size = new System.Drawing.Size(90, 24);
            this.humLabel.TabIndex = 5;
            this.humLabel.Text = "Unknown";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Location = new System.Drawing.Point(183, 34);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(199, 20);
            this.tempTextBox.TabIndex = 6;
            // 
            // pressTexBox
            // 
            this.pressTexBox.Location = new System.Drawing.Point(183, 92);
            this.pressTexBox.Name = "pressTexBox";
            this.pressTexBox.Size = new System.Drawing.Size(199, 20);
            this.pressTexBox.TabIndex = 7;
            // 
            // humidityTextBox
            // 
            this.humidityTextBox.Location = new System.Drawing.Point(183, 149);
            this.humidityTextBox.Name = "humidityTextBox";
            this.humidityTextBox.Size = new System.Drawing.Size(199, 20);
            this.humidityTextBox.TabIndex = 8;
            // 
            // lastCheck
            // 
            this.lastCheck.AutoSize = true;
            this.lastCheck.Location = new System.Drawing.Point(42, 219);
            this.lastCheck.Name = "lastCheck";
            this.lastCheck.Size = new System.Drawing.Size(145, 17);
            this.lastCheck.TabIndex = 9;
            this.lastCheck.Text = "Uradi statistiku za zadnjih";
            this.lastCheck.UseVisualStyleBackColor = true;
            this.lastCheck.CheckedChanged += new System.EventHandler(this.lastCheck_CheckedChanged);
            // 
            // lastTxtBox
            // 
            this.lastTxtBox.Enabled = false;
            this.lastTxtBox.Location = new System.Drawing.Point(211, 219);
            this.lastTxtBox.Name = "lastTxtBox";
            this.lastTxtBox.Size = new System.Drawing.Size(66, 20);
            this.lastTxtBox.TabIndex = 10;
            this.lastTxtBox.Text = "10";
            this.lastTxtBox.TextChanged += new System.EventHandler(this.lastTxtBox_TextChanged);
            this.lastTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lastTxtBox_KeyPress);
            // 
            // FormStatisticalData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 260);
            this.Controls.Add(this.lastTxtBox);
            this.Controls.Add(this.lastCheck);
            this.Controls.Add(this.humidityTextBox);
            this.Controls.Add(this.pressTexBox);
            this.Controls.Add(this.tempTextBox);
            this.Controls.Add(this.humLabel);
            this.Controls.Add(this.PressLabel);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStatisticalData";
            this.Text = "FormStatisticalData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label PressLabel;
        private System.Windows.Forms.Label humLabel;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.TextBox pressTexBox;
        private System.Windows.Forms.TextBox humidityTextBox;
        private System.Windows.Forms.CheckBox lastCheck;
        private System.Windows.Forms.TextBox lastTxtBox;
    }
}