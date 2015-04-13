namespace Mobile
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    class GSM
    {
        private static readonly GSM iPhone4S = new GSM("Iphone4S", "Apple", 300, "Misho", new Battery("616-0580", 200, 14, BatteryType.LiIon), new Display(3.5, 16000000));

        private string model;
        private string manufacturer;
        private double? price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacturer, double? price = null, string owner = null, Battery battery = null, Display display = null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public static GSM IPhone4S
        {
            get
            {
                return iPhone4S;
            }
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

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public double? Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The price cannot be a non-positive number.");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public string GetCallHistory()
        {
            StringBuilder listOfCalls = new StringBuilder();

            foreach (Call Call in this.callHistory)
            {
                listOfCalls.AppendLine(Call.ToString());
            }

            if (this.callHistory.Count != 0)
            {
                return listOfCalls.ToString().Trim();
            }
            else
            {
                return "There is no call history.";
            }
                       
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder();
            PropertyInfo[] properties = this.GetType().GetProperties();

            content.AppendLine("GSM characteristics:");

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(this) != null && !property.GetGetMethod().IsStatic)
                {
                    if (property.PropertyType.Module.ScopeName == "CommonLanguageRuntimeLibrary" && (property.PropertyType.GetInterface(typeof(IEnumerable<>).FullName) == null || !property.PropertyType.IsGenericType))
                    {
                        content.AppendLine(property.Name + ": " + property.GetValue(this));
                    }
                    else
                    {
                        if (property.PropertyType.GetInterface(typeof(IEnumerable<>).FullName) == null && !property.PropertyType.IsGenericType)
                        {
                            content.AppendLine(property.Name + ": ");
                            content.AppendLine(property.GetValue(this).ToString());
                        }
                    }
                }
            }

            return content.ToString().Trim();
        }

        public void AddCall(Call call)
        {
            this.callHistory.Add(call);
        }

        public void RemoveCall(Call call)
        {
            this.callHistory.Remove(call);
        }

        public void ClearCallHistory()
        {
            this.callHistory.Clear();
        }

        public double CalculatePrice(double pricePerMinute)
        {
            double totalPrice = 0;
            double pricePerSecond = pricePerMinute / 60;

            foreach (Call Call in this.callHistory)
            {
                totalPrice += (double)Call.Duration * pricePerSecond;
            }

            return totalPrice;
        }

    }
}
