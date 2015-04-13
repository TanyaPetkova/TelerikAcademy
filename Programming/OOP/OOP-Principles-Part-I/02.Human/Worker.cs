namespace _02.Human
{
    public class Worker : Human
    {
        private const int workDaysPerWeek = 5;

        public int WeekSalary { get; private set; }
        public int WorkHoursPerDay { get; private set; }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public double MoneyPerHour()
        {
            return (double)this.WeekSalary / (this.WorkHoursPerDay * workDaysPerWeek);
        }
    }
}
