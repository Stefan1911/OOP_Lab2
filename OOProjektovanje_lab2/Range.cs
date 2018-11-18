namespace OOProjektovanje_lab2
{
    public class Range
    {
        double min;
        double max;


        public Range(double min,double max)
        {
            setValues(min, max);
        }

        public double Min { get => min; set => min = value; }
        public double Max { get => max; set => max = value; }

        #region methodes
        public bool isInRange(double value)
        {
            return (value > Min && value < Max) ? true : false;
        }
        public void setValues(double min,double max)
        {
            this.Max = max;
            this.Min = min;
        }
        #endregion
    }
}