namespace StudyCode
{
    public class Developer : Employee
    {
        public bool TaskCompleted { get ; set; }
        private const decimal bonusRate = 0.03m;
        
        public Developer(int id, string name, decimal loggedHours, decimal wage , bool taskCompleted) : base(id, name, loggedHours, wage)
        {
            this.TaskCompleted = taskCompleted;
        } 
        private decimal calculateBonus()
        {
            return TaskCompleted ? bonusRate*base.CalculateSalary() : 0; 
        }
        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + calculateBonus();
        }
        public override string ToString()
        {
            string tasks = TaskCompleted ? $"Completed tasks\n" : $"incomplete tasks\n";
            return base.ToString() 
                                   +$"\nis Developer\n"
                                   +tasks
                                   + $"Net salary = {CalculateSalary()}";
        }
    }
}

