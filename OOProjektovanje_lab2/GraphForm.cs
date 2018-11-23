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
    public partial class GraphForm : Form,Updatable
    {
        private measurementType measurementType;
        private List<value> data;
        int numOfValues; //used for regulateing the amount of values in the List, 0 means no limit
        private List<value> LogData
        {
            get
            {
                List<value> logData = new List<value>(data.Count);
                foreach (value value in data)
                {
                    logData.Add(value.Log10);
                }
                return logData;
            }
        }

        public GraphForm(measurementType measurementType,int numOfValues)
        {
            InitializeComponent();
            this.numOfValues = numOfValues;
            this.data = new List<value>();
            this.measurementType = measurementType;
            graphChart.DataSource = data;
            graphChart.Series[0].Name = measurementType.ToString();
            graphChart.Series[0].YValueMembers = "dataValue";
            graphChart.DataBind();
        }
       
        #region methodes
        public void update(value temp,value pres,value hum)
        {
            if (measurementType == measurementType.temperatura)
                addData(temp);
            if (measurementType == measurementType.pritisak)
                addData(pres);
            if (measurementType == measurementType.vlaznost)
                addData(hum);

            updateChart();
        }
        private void addData(value value)
        {
            if (this.numOfValues != 0 && this.data.Count >= this.numOfValues)
            {
                this.data.RemoveAt(0);
            }
            this.data.Add(value);
        }
        private void updateChart()
        {
            graphChart.DataSource = (logCheck.Checked == true) ? LogData : data;
            graphChart.DataBind();
        }
        #endregion

        private void logCheck_CheckedChanged(object sender, EventArgs e)
        {
            updateChart();
        }
        private void graphChart_DoubleClick(object sender, EventArgs e)
        {
            listFromGraphForm listForm = new listFromGraphForm(this.data);
            listForm.Show();
        }
    }
}
