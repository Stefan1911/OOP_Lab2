using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjektovanje_lab2
{
    public class valueColetion
    {
        value temp;
        value press;
        value humidity;
        DateTime dateTimeRecieved;

        public valueColetion(value temp, value press, value humm)
        {
            this.temp = temp;
            this.press = press;
            this.humidity = humm;
            dateTimeRecieved = DateTime.Now;
        }

        public string toString()
        {
            return temp.DataValue.ToString() + " " + press.DataValue.ToString() + " " + humidity.DataValue.ToString();
        }

        public string Temp { get => temp.toString(3); }
        public string Press { get => press.toString(3); }
        public string Humidity { get => humidity.toString(3); }
        public DateTime Date { get => dateTimeRecieved; }
    }
}
