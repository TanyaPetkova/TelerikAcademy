namespace Student
{
    using System;
    using System.Linq;
    using System.Net.Mail;
    using System.Reflection;
    using System.Text;
    using System.Text.RegularExpressions;

    using Enums;

    public class Student : ICloneable, IComparable<Student>
    {
        private const string SsnValidationPattern = @"^(?!219-09-9999|078-05-1120)(?!666|000|9\d{2})\d{3}(?!00)\d{2}(?!0{4})\d{4}$";

        private string firstName;
        private string middleName;
        private string lastName;
        private string ssn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private string course;
        private Specialty specialty;
        private University university;
        private Faculty faculty;

        public Student()
        {

        }

        public Student(string firstName, string middleName, string lastName, string ssn, string permanentAddress, string mobilePhone, string email,
            string course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Ssn = ssn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.EMail = email;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
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

        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            set
            {
                ValidateName(value);
                this.middleName = value;
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

        public string Ssn
        {
            get
            {
                return this.ssn;
            }
            set
            {
                if (!Regex.IsMatch(value, SsnValidationPattern))
                {
                    throw new ArgumentException("The SSN is not valid!", value);
                }

                this.ssn = value;
            }
        }

        public string PermanentAddress
        {
            get
            {
                return this.permanentAddress;
            }
            set
            {
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get
            {
                return this.mobilePhone;
            }
            set
            {
                if (!value.All(x => Char.IsDigit(x)))
                {
                    throw new ArgumentException("The telephone number {0} is not in valid format.", value);
                }

                this.mobilePhone = value;
            }
        }

        public string EMail
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

        public string Course
        {
            get
            {
                return this.course;
            }
            set
            {
                this.course = value;
            }
        }

        public Specialty Specialty
        {
            get
            {
                return this.specialty;
            }
            set
            {
                this.specialty = value;
            }
        }

        public University University
        {
            get
            {
                return this.university;
            }
            set
            {
                this.university = value;
            }
        }

        public Faculty Faculty
        {
            get
            {
                return this.faculty;
            }
            set
            {
                this.faculty = value;
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

        public override bool Equals(object obj)
        {
            Student student = obj as Student;

            if (student == null)
            {
                return false;
            }

            PropertyInfo[] thisProperties = this.GetType().GetProperties();

            foreach (PropertyInfo property in thisProperties)
            {
                if (!property.GetValue(this).Equals(property.GetValue(student)))
                {
                    return false;
                }
            }

            return true;
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

        public override int GetHashCode()
        {
            PropertyInfo[] properties = this.GetType().GetProperties();

            int hashCode = properties[0].GetValue(this).GetHashCode();

            for (int i = 1; i < properties.Length; i++)
            {
                hashCode ^= properties[i].GetValue(this).GetHashCode();
            }

            return hashCode;
        }

        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }

        public object Clone()
        {
            object newObject = Activator.CreateInstance(this.GetType());
            FieldInfo[] newFields = newObject.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            FieldInfo[] oldFields = this.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            for (int i = 0; i < oldFields.Length; ++i)
            {
                newFields[i].SetValue(newObject, oldFields[i].GetValue(this));
            }

            return newObject;
        }

        public int CompareTo(Student otherStudent)
        {
            if (Student.Equals(this, otherStudent))
            {
                return 0;
            }

            Student[] students = {this, otherStudent};

            return Student.Equals(students.OrderBy(student => student.FirstName).ThenBy(student => student.Ssn).First(), this) ? -1 : 1;
        }
    }
}
