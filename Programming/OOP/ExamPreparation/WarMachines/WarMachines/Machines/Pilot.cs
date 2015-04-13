namespace WarMachines.Machines
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using WarMachines.Interfaces;

    public class Pilot : Entity, IPilot
    {
        private IList<IMachine> machines;

        public Pilot(string name)
            : base(name)
        {
            this.machines = new List<IMachine>();
        }

        public void AddMachine(IMachine machine)
        {
            this.machines.Add(machine);
        }

        public string Report()
        {
            StringBuilder report = new StringBuilder(base.ToString());

            report.Append(" - ");

            if (machines.Count == 0)
            {
                report.AppendLine("no machines");
            }
            else if (machines.Count == 1)
            {
                report.AppendLine("1 machine");
            }
            else
            {
                report.AppendLine(string.Format("{0} machines", machines.Count));
            }

            var sortedMachines = this.machines.OrderBy(x => x.HealthPoints).ThenBy(x => x.Name);

            foreach (var machine in sortedMachines)
            {
                report.AppendLine(machine.ToString());
            }

            return report.ToString().TrimEnd();
        }
    }
}
