namespace MVCApplicationForEvoke.Models
{
    /// <summary>
    /// This defiition for employee
    /// </summary>
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string JobDescription { get; set; }
        public string Gender { get; set; }
    }

    /// <summary>
    /// HR
    /// </summary>
    public class HR : Employee
    {
        public string PeoppleManagementRights { get; set; }

    }

    /// <summary>
    /// Special role for ERP 
    /// </summary>
    public class ErpArchitect : Employee
    {
        public string ErpLicense { get; set; }
    }
}
