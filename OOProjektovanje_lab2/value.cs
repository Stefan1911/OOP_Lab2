using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjektovanje_lab2
{

    public class value : IComparable
    {
        private double dataValue;
        private DateTime dateTime;

        public value(double dataValue, DateTime dateTime)
        {
            this.DataValue = dataValue;
            this.dateTime = dateTime;
        }
        public value(Range range)
        {
            Random rnd = new Random();
            dataValue = rnd.NextDouble() * (range.Max - range.Min) + range.Min;
            DateTime = DateTime.Now;
        }

        public double DataValue { get => dataValue; set => dataValue = value; }
        public DateTime DateTime { get => dateTime; set => dateTime = value; }
        [System.ComponentModel.Browsable(false)]
        public value Log10 { get => new value(Math.Log10(dataValue), dateTime); }

        public int CompareTo(object obj)
        {
            return this.dataValue.CompareTo(((value)obj).dataValue);
        }

    }
}