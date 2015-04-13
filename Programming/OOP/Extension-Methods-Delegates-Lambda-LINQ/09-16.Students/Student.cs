namespace _09_16_18_19.Students
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.Reflection;
    using System.Text;
    using System.Linq;

    class Student
    {
        private string firstName;
        private string lastName;
        private string facultyNumber;
        private string telephoneNumber;
        private string email;
        private List<int> marks;
        private ushort? groupNumber;
        private Group group;
       
        public Student(string firstName, string lastName, string facultyNumber, string telephoneNumber, string email, List<int> marks = null, ushort? groupNumber = null, Group group = null)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FacultyNumber = facultyNumber;
            this.TelephoneNumber = telephoneNumber;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
            this.Group = group;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                ValidateName(value);
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
                ValidateName(value);
                this.lastName = value;
            }
        }

        public string FacultyNumber
        {
            get
            {
                return this.facultyNumber;
            }
            set
            {
                this.facultyNumber = value;
            }
        }

        public string TelephoneNumber
        {
            get
            {
                return this.telephoneNumber;
            }
            set
            {
                if (!value.All(x => Char.IsDigit(x) || x == '/'))
                {
                    throw new ArgumentException(string.Format("The telephone number {0} is not in valid format.", value));
                }

                this.telephoneNumber = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                try
                {
                    MailAddress mailAddress = new MailAddress(value);
                }
                catch (FormatException)
                {
                    Console.WriteLine("The e-mail address {0} is not in valid format.", value);
                }

                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return this.marks;
            }
            set
            {
                this.marks = value;
            }
        }

        public ushort? GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public Group Group 
        {
            get
            {
                return this.group;
            }
            set
            {
                this.group = value;
            }
        }

        private void ValidateName(string value)
        {
            if (String.IsNullOrEmpty(value))
			{
				throw new ArgumentException("The name cannot be empty!");
			}

			if (value.Length < 2)
			{
				throw new ArgumentException("The name is too short. It should be at least 2 letters.");
			}

			if (value.Length >= 50)
			{
				throw new ArgumentException("The name is too long. It should be less than 50 letters.");
			}

			foreach (char ch in value)
			{
                if (!(Char.IsLetter(ch) || ch == '-'))
				{
					throw new ArgumentException("Invalid name! Use only letters and hyphen");
				}
			}
        }

        public string GetMarks()
        {
            return string.Join(", ", this.marks);
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder();
            PropertyInfo[] properties = this.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(this) != null)
                {
                    if (!typeof(IEnumerable<int>).IsAssignableFrom(property.PropertyType))
                    {
                        content.AppendLine(property.Name + ": " + property.GetValue(this));
                    }
                    else 
                    {
                        content.AppendLine(property.Name + ": " + string.Join(", ", this.marks));
                    }                   
                }
            }

            return content.ToString().Trim();
        }
    }
}
