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
    public partial class FormStatisticalData : Form,Updatable
    {
        private List<value> temperature;
        private List<value> pressure;
        private List<value> humidity;

        private List<value> Temperature
        {
            get
            {
                if (lastCheck.Checked == true && lastTxtBox.Text != "")
                {
                    return Enumerable.Reverse(temperature).Take(Int32.Parse(lastTxtBox.Text)).Reverse().ToList();
                }
                else
                {
                    return temperature;
                }
            }
        }
        public List<value> Pressure
        {
            get
            {
                if (lastCheck.Checked == true && lastTxtBox.Text != "")
                {
                    return Enumerable.Reverse(pressure).Take(Int32.Parse(lastTxtBox.Text)).Reverse().ToList();
                }
                else
                {
                    return pressure;
                }
            }
        }
        public List<value> Humidity
        {
            get
            {
                if (lastCheck.Checked == true && lastTxtBox.Text != "")
                {
                    return Enumerable.Reverse(humidity).Take(Int32.Parse(lastTxtBox.Text)).Reverse().ToList();
                }
                else
                {
                    return humidity;
                }
            }
        }

        public FormStatisticalData()
        {
            InitializeComponent();
            temperature = new List<value>();
            pressure = new List<value>();
            humidity= new List<value>();
            temperature.Min();
        }
        public void update(value temp,value press,value hum)
        {
            /*if(StandardValues.Instance.isInRange(value.DataValue,measurementType))
                getMeasurment(measurementType).Add(value);*/
            if (temp != null)
                temperature.Add(temp);
            if (press != null)
                pressure.Add(press);
            if (hum != null)
                humidity.Add(hum);
            updateTexBoxes();
            updateLabels();
        }
        private double average(List<value> list)
        {
            double sum = 0;
            foreach(value value in list)
            {
                sum += value.DataValue;
            }
            return sum / list.Count;
        }
        private List<value> getMeasurment(measurementType type)
        {
            switch (type)
            {
                case measurementType.temperatura:
                    return this.temperature;
                case measurementType.pritisak:
                    return this.pressure;
                case measurementType.vlaznost:
                    return this.humidity;
                default:
                    return null;
            }
        }
        private void updateTexBoxes()
        {
            tempTextBox.Text = (temperature.Count == 0)? "":temperature.Last().DataValue.ToString();
            pressTexBox.Text = (pressure.Count == 0) ? "" : pressure.Last().DataValue.ToString();
            humidityTextBox.Text = (humidity.Count == 0) ? "" : humidity.Last().DataValue.ToString();
        }
        private void updateLabels()
        {
            if (temperature.Count != 0)
                tempLabel.Text = "avg : "+ average(Temperature) + ", min :" + Temperature.Min().DataValue + ",max :" + Temperature.Max().DataValue;
            else
                tempLabel.Text = "Unknown";
            if (pressure.Count != 0)
                PressLabel.Text = "avg : " + average(Pressure) + ", min :" + Pressure.Min().DataValue + ",max :" + Pressure.Max().DataValue;
            else
                PressLabel.Text = "Unknown";
            if (humidity.Count != 0)
                humLabel.Text = "avg : " + average(Humidity) + ", min :" + Humidity.Min().DataValue + ",max :" + Humidity.Max().DataValue;
            else
                humLabel.Text = "Unknown";
        }

        private void lastTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (lastTxtBox.Text == "" || Int32.Parse(lastTxtBox.Text) == 0)
            {
                lastTxtBox.Text = "10";
            }
            this.updateLabels();
        }

        private void lastTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void lastCheck_CheckedChanged(object sender, EventArgs e)
        {
            lastTxtBox.Enabled = lastCheck.Checked;
        }
    }
}
