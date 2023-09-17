
namespace OCP
{

    public abstract class Employee
    {
        protected double PerHour;
        public abstract double CalculateSalary();

    }

    public class Manager : Employee
    {

        public Manager(double perHour)
        {
            PerHour = perHour;
        }
        public override double CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }

    public class TeamLead : Employee
    {
        public TeamLead(double perHour)
        {
            PerHour = perHour;
        }
        public override double CalculateSalary()
        {
            throw new NotImplementedException();
        }
    }




}