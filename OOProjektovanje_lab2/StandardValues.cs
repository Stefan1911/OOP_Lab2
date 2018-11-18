using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOProjektovanje_lab2
{
    class StandardValues
    {
        Range temperature;
        Range pressure;
        Range humidity;


        #region singletone
        private static StandardValues _instance = null;
        public static StandardValues Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new StandardValues();
                }
                return _instance;
            }
        }
        #endregion

        internal Range Temperature { get => temperature; set => temperature = value; }
        internal Range Pressure { get => pressure; set => pressure = value; }
        internal Range Humidity { get => humidity; set => humidity = value; }

        #region constructors
         public StandardValues()
        {
            this.temperature = new Range(0, 0);
            this.pressure = new Range(0, 0);
            this.humidity = new Range(0, 0); ;
        }
        #endregion

        #region methodes
        public bool isInRange(double value, measurementType mod)
        {
            return getMod(mod).isInRange(value);
        }
        private Range getMod(measurementType mod)
        {
            switch (mod)
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
        #endregion
    }
}
