namespace WarMachines.Machines
{
    using System.Text;
    using WarMachines.Interfaces;

    public class Tank : Machine, ITank
    {
        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints)
            : base(name, 100, attackPoints, defensePoints)
        {
            ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }

            private set 
            {
                this.defenseMode = value;
            }
        }

        public void ToggleDefenseMode()
        {
            if (this.defenseMode)
            {
                this.DefenseMode = false;
                this.DefensePoints -= 30;
                this.AttackPoints += 40;               
            }
            else
            {
                this.DefenseMode = true;
                this.DefensePoints += 30;
                this.AttackPoints -= 40;                       
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine(base.ToString());
            output.Append(" *Defense: ");

            if (this.DefenseMode == true)
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
