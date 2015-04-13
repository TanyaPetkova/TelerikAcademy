namespace _01.School
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public class SchoolClass : ICommentable
    {
        public string ID { get; private set; }
        public List<Student> Students { get; private set; }
        public List<Teacher> Teachers { get; private set; }
        public List<string> Comments { get; set; }

        public SchoolClass(string id)
        {
            this.ID = id;
            this.Students = new List<Student>();
            this.Teachers = new List<Teacher>();
            this.Comments = new List<string>();
        }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.Students.Remove(student);
        }

        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
        }

        public string GetTeachers()
        {
            StringBuilder listOfTeachers = new StringBuilder();

            foreach (Teacher teacher in this.Teachers)
            {
                listOfTeachers.AppendLine(teacher.ToString());
            }

            if (this.Teachers.Count != 0)
            {
                return listOfTeachers.ToString().Trim();
            }
            else
            {
                return "There is no teachers in this class.";
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
                    if (!property.PropertyType.IsGenericType)
                    {
                        content.AppendLine(property.Name + ": " + property.GetValue(this));
                    }
                }
            }

            return content.ToString().Trim();
        }
    }
}
