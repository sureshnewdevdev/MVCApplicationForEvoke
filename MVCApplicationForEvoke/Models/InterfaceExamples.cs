namespace MVCApplicationForEvoke.Models
{

    #region Draft
    public interface IPerson
    {
        string DisplayDetails(string name, decimal salary);
        int AddTwoNumbers(int a, int b);
    }
    public class ExMan : IPerson
    {
        public int AddTwoNumbers(int a, int b)
        {
            return a + b;
        }

        public string DisplayDetails(string name, decimal salary)
        {
            return "Welcome " + name + " Salary " + salary;
        }
    }
    #endregion


    public interface ITestResult
    {
        decimal GetReturnResult();
    }

    public class TopWing : ITestResult
    {
        public decimal GetReturnResult()
        {
            return (decimal)100;
        }
    }

    public class BackWheelTest : ITestResult
    {
        public decimal GetReturnResult()
        {
            return (decimal)10;
        }
    }

}
