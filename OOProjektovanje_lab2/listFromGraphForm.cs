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
    public partial class listFromGraphForm : Form
    {
        private List<value> data;

        public listFromGraphForm(List<value> data)
        {
            InitializeComponent();
            this.data = data;
            updateGride();
        }
        private void updateGride()
        {
            grid.DataSource = this.data;
        }
    }
}
