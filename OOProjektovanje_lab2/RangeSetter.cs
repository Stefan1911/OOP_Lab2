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
    public enum measurementType
    {
        temperatura,
        pritisak,
        vlaznost
    }
    public partial class RangeSetter : Form
    {
        private measurementType measType;

        public Range StandardToSet    
        {
            set
            {
                switch (measType)
                {
                    case measurementType.temperatura:
                        StandardValues.Instance.Temperature = value;
                        break;
                    case measurementType.pritisak:
                        StandardValues.Instance.Pressure = value;
                        break;
                    case measurementType.vlaznost:
                        StandardValues.Instance.Humidity = value;
                        break;
                }
            }
            get
            {
                switch (measType)
                {
                    case measurementType.temperatura:
                        return StandardValues.Instance.Temperature;
                    case measurementType.pritisak:
                        return StandardValues.Instance.Pressure;
                    case measurementType.vlaznost:
                        return StandardValues.Instance.Humidity;
                    default:
                        return null;
                }
            }
        }
        #region constructors
        public RangeSetter()
        {
            InitializeComponent();
        }
        public RangeSetter(measurementType measurementTypemod)
        {
            InitializeComponent();
            this.measType = measurementTypemod;
            this.setLabel.Text += this.measType.ToString();
        }
        #endregion
        #region methodes
        private bool validation()
        {
            bool minValidation =  FormMain.checkIfDouble(minTxtBox);
            bool maxValidation = FormMain.checkIfDouble(maxTxtBox);
            return minValidation && maxValidation && checkIfMaxIsGreater();
        }
        private bool checkIfMaxIsGreater()
        {
            if(double.Parse(maxTxtBox.Text) < double.Parse(minTxtBox.Text))
            {
                errLabel.Visible = true;
                return false;
            }
            else
            {
                errLabel.Visible = false;
                return true;
            }
        }
        #endregion
        #region events
        private void setBtn_Click(object sender, EventArgs e)
        {
            if (validation())
            {
                StandardToSet = new Range(double.Parse(minTxtBox.Text), double.Parse(maxTxtBox.Text));
                this.Close();
            }
        }
        private void RangeSetter_Load(object sender, EventArgs e)
        {
            minTxtBox.Text = StandardToSet.Min.ToString();
            maxTxtBox.Text = StandardToSet.Max.ToString();
        }
        #endregion
    }
}
