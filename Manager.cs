namespace StudyCode
{
    public class Manager : Employee
    {
        private const decimal BounousRate = 0.05m;
        private decimal ManagerBounous; 
        public Manager (int id, string name, decimal loggedHours, decimal wage) : base( id, name, loggedHours, wage)
        { }
        public override decimal CalculateSalary()
        {
            decimal SalaryOfManager = base.CalculateSalary();
            ManagerBounous = BounousRate * SalaryOfManager;
            return SalaryOfManager + ManagerBounous ;
        }
        public override string ToString()
        {
            return base.ToString() +
                   $"\nis Manager has Allowance {BounousRate * 100}% from basic salary = {ManagerBounous} from \n" +
                   $"Net salary = {this.CalculateSalary()}";
        }
    }

}

