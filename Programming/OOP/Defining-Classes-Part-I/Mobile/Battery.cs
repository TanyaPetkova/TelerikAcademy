namespace Mobile
{
    using System;
    using System.Text;
    using System.Reflection;
   
    class Battery
    {
        private string model;
        private double? hoursIdle;
        private double? hoursTalk;
        private BatteryType type;

        public Battery(string model = null, double? hoursIdle = null, double? hoursTalk = null, BatteryType type = BatteryType.LiIon)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The hours cannot be a negative number.");
                }

                this.hoursIdle = value;
            }
        }

        public double? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The hours cannot be a negative number.");
                }

                this.hoursTalk = value;
            }
        }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder();
            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (var property in properties)
            {
                if (property.GetValue(this) != null)
                {
                    content.AppendLine(property.Name + ": " + property.GetValue(this));
                }
            }

            return content.ToString().Trim();
        }
    }
}
