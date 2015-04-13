namespace SoftwareAcademy
{
    using System;

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The town cannot be null!");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("; Town={0}", this.Town);
        }
    }
}
