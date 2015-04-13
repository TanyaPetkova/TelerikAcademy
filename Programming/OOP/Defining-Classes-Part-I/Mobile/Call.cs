namespace Mobile
{
    using System;
    using System.Reflection;
    using System.Text;

    class Call
    {
        private DateTime dateTime;
        private string dialedPhoneNumber;
        private uint? duration;

        public Call(DateTime dateTime = default(DateTime), string dialedPhoneNumber = null, uint? duration = null)
        {
            this.DateTime = dateTime;
            this.DialedPhoneNumber = dialedPhoneNumber;
            this.Duration = duration;
        }

        public DateTime DateTime
        {
            get
            {
                return this.dateTime;
            }
            set
            {
                this.dateTime = value;
            }
        }

        public string DialedPhoneNumber
        {
            get
            {
                return this.dialedPhoneNumber;
            }
            set
            {
                this.dialedPhoneNumber = value;
            }
        }

        public uint? Duration
        {
            get
            {
                return this.duration;
            }
            set
            {
                this.duration = value;
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
