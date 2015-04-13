namespace _02.Human
{
    using System.Reflection;
    using System.Text;

    public class Student : Human
    {
        public int Grade { get; private set; }

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder();
            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
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
