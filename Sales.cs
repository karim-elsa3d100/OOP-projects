namespace StudyCode
{
    public class Sales : Employee
    {
        public decimal SalesVolume { get; set; }
        public decimal Commission { get; set; }

        public Sales(int id, string name, decimal loggedHours, decimal wage , decimal salesVolume , decimal comission) : base(id, name, loggedHours, wage)
        {
            this.SalesVolume = salesVolume;
            this.Commission = comission;
        }
        private decimal calculateBonous()
        {
            return SalesVolume * Commission;
        }
        public override decimal CalculateSalary()
        {
            return base.CalculateSalary() + calculateBonous();
        }
        public override string ToString()
        {
            return base.ToString() +
                    $"\nis Saler has Sales={SalesVolume}$\n" +
                    $"and Commission rate = {Commission*100}%\n" +
                    $"has bonus = {calculateBonous()} and basic salary = {base.CalculateSalary()}\n"+
                    $"Net salary = {this.CalculateSalary()}";
        }
    }

}

