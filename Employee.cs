namespace StudyCode
{
    public abstract class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal LoggedHours { get; set; }
        public decimal Wage { get; set; }
        public const int MinimumLoggedHours = 176;
        public Employee (int id , string name , decimal loggedHours , decimal wage)
        {
            ID = id;    
            Name = name;
            LoggedHours = loggedHours;
            Wage = wage;
        } 
        public virtual decimal CalculateSalary()
        {
            // return the basic salary and the salary of additional hours
            if (LoggedHours < MinimumLoggedHours)
                return 0;
            return Wage * MinimumLoggedHours + OverTimeSalary();
        }
        private decimal OverTimeSalary()
        {
            // return additional dollars of the Overtime 
            decimal additonalHours = LoggedHours - MinimumLoggedHours;
            return (decimal)1.25 * additonalHours * Wage;
        }
        public override string ToString()
        {
            return $"\nEmployee with ID :{ID} \nName {Name}\nhas LoggedHours = {LoggedHours}Hrs \nWage = {Wage}$/Hr" ;
        }
    }
}

