namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using WarMachines.Interfaces;

    public abstract class Machine : Entity, IMachine
    {  
        private IPilot pilot;
        private double healthPoints;
        private double attackPoints;
        private double defensePoints;
        private IList<string> targets;

        public Machine(string name, double healthPoints, double attackPoints, double defensePoints) : base(name)
        {
            this.healthPoints = healthPoints;
            this.attackPoints = attackPoints;
            this.defensePoints = defensePoints;
            this.targets = new List<string>();
        }

        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The pilot cannot be null!");
                }

                this.pilot = value;
            }
        }

        public double HealthPoints
        {
            get
            {
                return this.healthPoints;
            }

            set
            {
                this.healthPoints = value;
            }
        }

        public double AttackPoints
        {
            get 
            { 
                return this.attackPoints; 
            }

            protected set 
            {
                this.attackPoints = value;
            }
        }

        public double DefensePoints
        {
            get 
            {
                return this.defensePoints;
            }

            protected set 
            {
                this.defensePoints = value;
            }
        }

        public IList<string> Targets
        {
            get 
            {
                return new List<string>(this.targets);
            }
        }

        public void Attack(string target)
        {
            this.targets.Add(target);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.Append("- ");
            output.AppendLine(base.ToString());
            output.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            output.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            output.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            output.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));

            if (this.Targets.Count == 0)
            {
                output.AppendLine(" *Targets: None");
            }
            else
            {
                output.AppendLine(string.Format(" *Targets: {0}", string.Join(", ", this.targets)));
            }

            return output.ToString().TrimEnd();
        }
    }
}
