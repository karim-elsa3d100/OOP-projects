namespace StudyCode
{
    public class Maintenance : Employee
    {
        private const decimal _hardship = 100;
        public Maintenance(int id, string name, decimal loggedHours, decimal wage) : base(id, name, loggedHours, wage)
        { }
        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + _hardship;
        }
        public override string ToString()
        {
            return base.ToString() +
                    $"\nis Maintenance has Hardship={_hardship}$\n" + 
                    $"Net salary = {this.CalculateSalary()}";
        }
    }

}

