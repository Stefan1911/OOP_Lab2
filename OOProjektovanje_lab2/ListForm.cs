using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOProjektovanje_lab2.Properties;

namespace OOProjektovanje_lab2
{
    

    public partial class ListForm : Form,Updatable
    {
        List<valueColetion> data;
        int timer;
        int odbaceno;

        public ListForm()
        {
            InitializeComponent();
            data = new List<valueColetion>();
            timer = 0;
            odbaceno = 0;
            grid.DataSource = data;
        }

        public void update(value temp, value press, value hum)
        {
            valueColetion coletion = new valueColetion(temp, press, hum);
            if (timer == Int32.Parse(intervalBox.Text))
            {
                if(data.Count == 10)
                {
                    data.RemoveAt(0);
                }
                data.Add(coletion);
                grid.DataSource = data.ToList();
                timer = 0;
            }
            else
            {
                odbaceno++;
                odbacenoBox.Text = odbaceno.ToString();
            }
        }

        private void ListTimer_Tick(object sender, EventArgs e)
        {
            if(timer < Int32.Parse(intervalBox.Text))
            {
                timer++;
            }
        }

        private void intervalBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
