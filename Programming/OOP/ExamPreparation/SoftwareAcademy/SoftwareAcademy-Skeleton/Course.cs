namespace SoftwareAcademy
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private IList<string> topics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Topics = new List<string>();
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
                    throw new ArgumentNullException("The name cannot be null or empty!");
                }

                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }

            set
            {
                this.teacher = value;
            }
        }

        public IList<string> Topics
        {
            get
            {
                return this.topics;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The list of topics cannot be null!");
                }

                this.topics = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.Topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendFormat("{0}: Name={1}",this.GetType().Name, this.Name);
            
            if (this.Teacher != null)
	        {
		        output.AppendFormat("; Teacher={0}", this.Teacher.Name);
	        }

            if (this.topics.Count != 0)
            {
                output.AppendFormat("; Topics=[{0}]", string.Join(", ", this.Topics));
            }
           
            return output.ToString();
        }
    }
}
