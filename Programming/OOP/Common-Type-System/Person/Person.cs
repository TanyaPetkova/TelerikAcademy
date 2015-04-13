namespace Person
{
    using System;
    using System.Reflection;
    using System.Text;

    public class Person
    {
        private string name;
        private byte? age;

        public Person(string name, byte? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                ValidateName(value);
                this.name = value;
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
                ValidateAge(value);
                this.age = value;
            }
        }

        private void ValidateName(string name)
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentException("The name cannot be empty!");
            }

            if (name.Length < 2)
            {
                throw new ArgumentException("The name is too short. It should be at least 2 letters.");
            }

            if (name.Length >= 50)
            {
                throw new ArgumentException("The name is too long. It should be less than 50 letters.");
            }

            foreach (char ch in name)
            {
                if (!(Char.IsLetter(ch) || ch == '-'))
                {
                    throw new ArgumentException("Invalid name! Use only letters and hyphen");
                }
            }
        }

        private void ValidateAge(byte? age)
        {
            if (age < 0)
            {
                throw new ArgumentException("The age cannot be negative number.");
            }

            if (age >= 120)
            {
                throw new ArgumentException("The age cannot be greater than 120 years.");
            }

            foreach (char ch in age.ToString())
            {
                if (!Char.IsDigit(ch))
                {
                    throw new ArgumentException("Invalid age! Use only digits");
                }
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
                else
                {
                    content.AppendLine(property.Name + string.Format(": The {0} is not specified", property.Name.ToLower()));
                }
            }

            return content.ToString().Trim();
        }
    }
}
