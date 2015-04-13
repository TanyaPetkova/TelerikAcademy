namespace _01.School
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public class Discipline : ICommentable
    {
        public string Name { get; private set; }
        public int NumberOfLectures { get; private set; }
        public int NumberOfExercises { get; private set; }
        public List<string> Comments { get; set; }

        public Discipline(string name, int numberOfLectures, int numberOfExrecises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExrecises;
        }

        public void AddComment(string comment)
        {
            this.Comments.Add(comment);
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
