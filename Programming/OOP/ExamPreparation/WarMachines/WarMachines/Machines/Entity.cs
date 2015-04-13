namespace WarMachines.Machines
{
    using System;

    public abstract class Entity
    {
        private string name;

        public Entity(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
