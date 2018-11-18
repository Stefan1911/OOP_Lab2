namespace OOProjektovanje_lab2
{
    partial class RangeSetter
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
            this.minTxtBox = new System.Windows.Forms.TextBox();
            this.maxTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.setLabel = new System.Windows.Forms.Label();
            this.setBtn = new System.Windows.Forms.Button();
            this.errLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // minTxtBox
            // 
            this.minTxtBox.Location = new System.Drawing.Point(12, 72);
            this.minTxtBox.Name = "minTxtBox";
            this.minTxtBox.Size = new System.Drawing.Size(168, 20);
            this.minTxtBox.TabIndex = 0;
            // 
            // maxTxtBox
            // 
            this.maxTxtBox.Location = new System.Drawing.Point(230, 72);
            this.maxTxtBox.Name = "maxTxtBox";
            this.maxTxtBox.Size = new System.Drawing.Size(168, 20);
            this.maxTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "MIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "MAX";
            // 
            // setLabel
            // 
            this.setLabel.AutoSize = true;
            this.setLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setLabel.Location = new System.Drawing.Point(64, 20);
            this.setLabel.Name = "setLabel";
            this.setLabel.Size = new System.Drawing.Size(116, 29);
            this.setLabel.TabIndex = 4;
            this.setLabel.Text = "Set The : ";
            // 
            // setBtn
            // 
            this.setBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setBtn.Location = new System.Drawing.Point(128, 126);
            this.setBtn.Name = "setBtn";
            this.setBtn.Size = new System.Drawing.Size(130, 49);
            this.setBtn.TabIndex = 5;
            this.setBtn.Text = "SET";
            this.setBtn.UseVisualStyleBackColor = true;
            this.setBtn.Click += new System.EventHandler(this.setBtn_Click);
            // 
            // errLabel
            // 
            this.errLabel.AutoSize = true;
            this.errLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errLabel.ForeColor = System.Drawing.Color.Crimson;
            this.errLabel.Location = new System.Drawing.Point(186, 63);
            this.errLabel.Name = "errLabel";
            this.errLabel.Size = new System.Drawing.Size(38, 39);
            this.errLabel.TabIndex = 6;
            this.errLabel.Text = ">";
            this.errLabel.Visible = false;
            // 
            // RangeSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 188);
            this.Controls.Add(this.errLabel);
            this.Controls.Add(this.setBtn);
            this.Controls.Add(this.setLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maxTxtBox);
            this.Controls.Add(this.minTxtBox);
            this.Name = "RangeSetter";
            this.Text = "RangeSetter";
            this.Load += new System.EventHandler(this.RangeSetter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox minTxtBox;
        private System.Windows.Forms.TextBox maxTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label setLabel;
        private System.Windows.Forms.Button setBtn;
        private System.Windows.Forms.Label errLabel;
    }
}