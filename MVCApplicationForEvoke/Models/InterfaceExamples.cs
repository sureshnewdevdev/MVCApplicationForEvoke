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

    public class ExWoman : IPerson
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
    #endregion

    public interface IDancingBird
    {
       void Dacing();
    }


    public interface ISingingBird
    {
        void Sing();
    }


    public class Peacock : IDancingBird
    {
        public void Dacing()
        {
             
        }
    }

    public class PenQueen : ISingingBird, IDancingBird
    {
        public void Dacing()
        {
            throw new NotImplementedException();
        }

        public void Sing()
        {
            throw new NotImplementedException();
        }
    }

    public class ManagePerson
    {

        public string ShowObjectType( IPerson person)
        {
            return  person.GetType().Name;
        }

        public string Callwe()
        {
            ExMan exMan = new ExMan();
            string result =  ShowObjectType( exMan );

            ExWoman exWoman= new ExWoman();
            result = ShowObjectType(exWoman);
            return result;
        }
    }
}


// i=PNR 
// i = period * inter