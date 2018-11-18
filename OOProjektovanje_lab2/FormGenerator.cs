using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOProjektovanje_lab2
{
    public partial class FormGenerator : Form
    {
        private FormMain paren;
        public FormGenerator()
        {
            InitializeComponent();
            this.paren = (FormMain)this.MdiParent;
        }

        #region methodes
        private void makeRangeSetter(measurementType measurementType)
        {
            RangeSetter setter = new RangeSetter(measurementType);
            setter.MdiParent = this.MdiParent;
            setter.Show();
        }
        private void send(TextBox textBox,measurementType measurementType)
        {
            if(textBox.Text != null && FormMain.checkIfDouble(textBox) && checkIfInRange(textBox,measurementType))
            {
                value value = new value(double.Parse(textBox.Text), DateTime.Now);
                //this.paren.updateChildren(value, measurementType);
                ((FormMain)this.MdiParent).updateChildren(value, measurementType);
            }
        }
        private void autoSend()
        {
            ((FormMain)this.MdiParent).updateChildren(new value(StandardValues.Instance.Temperature),measurementType.temperatura);
            ((FormMain)this.MdiParent).updateChildren(new value(StandardValues.Instance.Pressure), measurementType.pritisak);
            ((FormMain)this.MdiParent).updateChildren(new value(StandardValues.Instance.Humidity), measurementType.vlaznost);
        }
        private bool checkIfInRange(TextBox textBox,measurementType measurementType)
        {
            if(graniceChek.Checked == false)
            {
                return true;
            }
            if (StandardValues.Instance.isInRange(double.Parse(textBox.Text), measurementType))
            {
                return true;
            }
            else
            {
                textBox.Text = null;
                return false;
            }
        }
        #endregion

        #region events
        private void tempBtn_Click(object sender, EventArgs e)
        {
            makeRangeSetter(measurementType.temperatura);
        }

        private void presBtn_Click(object sender, EventArgs e)
        {
            makeRangeSetter(measurementType.pritisak);
        }

        private void vlaBtn_Click(object sender, EventArgs e)
        {
            makeRangeSetter(measurementType.vlaznost);
        }
        private void button1_Click(object sender, EventArgs e)
        {

            send(tempTxtBox, measurementType.temperatura);
            send(presTxtBox, measurementType.pritisak);
            send(vlazTxtBox, measurementType.vlaznost);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BreakPoint");
        }
        #endregion

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == '0') ;
            if (intervalBox.Text.Length >= 1)
                intervalBox.Text = "";
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            intervalBox.Enabled = intervalCheck.Checked;
            sendButton.Enabled = !intervalCheck.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(intervalCheck.Checked == true)
            {
                autoSend();
            }
        }

        private void intervalBox_TextChanged(object sender, EventArgs e)
        {
            int temp;
            if(Int32.TryParse(intervalBox.Text,out temp) && temp!= 0)
            {
                timer.Interval = temp * 1000;
            }
            else
            {
                timer.Interval = 1000;
            }
        }
    }
}
