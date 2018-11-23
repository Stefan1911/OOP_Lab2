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
    public partial class FormMain : Form
    {

        private List<Updatable> updatablesChildren;

        public FormMain()
        {
            InitializeComponent();
            updatablesChildren = new List<Updatable>();
        }


 
        #region methodes
        public static bool checkIfDouble(TextBox textBox)
        {
            double min;
            if (double.TryParse(textBox.Text, out min))
            {
                textBox.BackColor = Color.White;
                return true;
            }
            else
            {
                textBox.BackColor = Color.LightPink;
                return false;
            }
        }
        private void makeFormGenerator()
        {
            FormGenerator formGenerator = new FormGenerator();
            formGenerator.MdiParent = this;
            formGenerator.Show();
        }
        private void makeGraphForm(measurementType measurementType)
        {
            int numOfValues = (brojPrikaza.Text == "") ? 0 : numOfValues = Int32.Parse(brojPrikaza.Text);
            GraphForm graphForm = new GraphForm(measurementType, numOfValues);
            graphForm.MdiParent = this;
            this.updatablesChildren.Add(graphForm);
            graphForm.Show();
        }
        private void makeStatForm()
        {
            FormStatisticalData statForm = new FormStatisticalData();
            statForm.MdiParent = this;
            this.updatablesChildren.Add(statForm);
            statForm.Show();
        }
        public void updateChildren(value temp,value press,value hum)
        {
            foreach(Updatable child in this.updatablesChildren)
            {
                    child.update(temp,press,hum);
            }
        }
        #endregion

        #region events
        private void foemGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.makeFormGenerator();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeGraphForm(measurementType.temperatura);
        }
        private void pritisakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeGraphForm(measurementType.pritisak);
        }
        private void vlaznostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeGraphForm(measurementType.vlaznost);
        }
        #endregion

        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makeStatForm();
        }

        private void brojPrikaza_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar);  
        }

        private void listFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListForm listForm = new ListForm();
            this.updatablesChildren.Add(listForm);
            listForm.MdiParent = this;
            listForm.Show();
        }
    }
}
