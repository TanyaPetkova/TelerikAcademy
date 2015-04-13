namespace _01.School
{
    using System.Collections.Generic;
    using System.Reflection;
    using System.Text;

    public class Human : ICommentable
    {
        private List<string> comments = new List<string>();

        public string Name { get; private set; }

        public List<string> Comments
        {
            get
            {
                return this.comments;
            }
            set 
            {
                this.comments = value;
            }
        }

        public Human(string name)
        {
            this.Name = name;
        }

        public void AddComment(string comment)
        {
            this.comments.Add(comment);
        }

        public string GetComments()
        {
            StringBuilder content = new StringBuilder();
            int counter = 1;
            content.AppendLine("Comments: ");

            if (this.comments.Count != 0)
            {
                foreach (var comment in this.comments)
                {
                    content.AppendLine((counter++).ToString() + ". " + comment);
                }
            }
            else
            {
                content.AppendLine("There are no comments.");
            }

            return content.ToString();
        }
    }
}
