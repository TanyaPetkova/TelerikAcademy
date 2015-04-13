namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Fighter : Machine, IFighter
    {
        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, 200, attackPoints, defensePoints)
        {
            this.stealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }

            private set 
            {
                this.stealthMode = value;
            }
        }

        public void ToggleStealthMode()
        {
            if (this.StealthMode)
            {
                this.StealthMode = false;
            }
            else
            {
                this.StealthMode = true;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(base.ToString());
            output.Append(" *Stealth: ");

            if (this.StealthMode == true)
            {
                output.AppendLine("ON");
            }
            else
            {
                output.AppendLine("OFF");
            }

            return output.ToString().TrimEnd();
        }
    }
}
