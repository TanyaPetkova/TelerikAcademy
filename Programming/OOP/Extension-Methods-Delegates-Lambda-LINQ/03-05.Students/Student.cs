namespace _03_05.Students
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Text;

    class Student
    {
        private string firstName;
        private string lastName;
        private byte? age;

        public Student(string firstName, string lastName, byte? age = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }

        public byte? Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value <= 0 || value > 120)
                {
                    throw new ArgumentOutOfRangeException("The age cannot be a negative number or more than 120.");
                }

                this.age = value;
            }
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
