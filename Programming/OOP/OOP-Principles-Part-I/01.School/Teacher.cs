namespace _01.School
{
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Human
    {
        public List<Discipline> Disciplines { get; private set; }

        public Teacher(string name)
            : base(name)
        {
            this.Disciplines = new List<Discipline>();
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.Disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.Disciplines.Remove(discipline);
        }

        public string GetDiscipline()
        {
            StringBuilder listOfDiscipline = new StringBuilder();

            foreach (Discipline discipline in this.Disciplines)
            {
                listOfDiscipline.AppendLine(discipline.ToString());
            }

            if (this.Disciplines.Count != 0)
            {
                return listOfDiscipline.ToString().Trim();
            }
            else
            {
                return "There is no discipline.";
            }
        }

        public override string ToString()
        {
            StringBuilder content = new StringBuilder();

            content.AppendLine(this.Name);
            content.AppendLine(GetDiscipline());
            content.AppendLine(GetComments());

            return content.ToString().Trim();
        }
    }
}
