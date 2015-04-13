namespace Mobile
{
    using System;
    using System.Text;
    using System.Reflection;

    class Display
    {
        private double? size;
        private uint? numberOfColors;

        public Display(double? size = null, uint? numberOfColors = null)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public double? Size
        {
            get 
            { 
                return this.size; 
            }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The size cannot be a non-positive number.");
                }

                this.size = value; 
            }
        }

        public uint? NumberOfColors
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The number of colors cannot be a non-positive number.");
                }

                this.numberOfColors = value;
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
