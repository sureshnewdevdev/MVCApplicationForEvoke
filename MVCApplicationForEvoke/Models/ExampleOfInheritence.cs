namespace MVCApplicationForEvoke.Models
{
    #region draft1
    //public class Student //base
    //{
    //    public int stu_id { get; set; }
    //    public string stu_name { get; set; }
    //    public int marks { get; set; }
    //}
    //public class PGStudent : Student // drived or child class
    //{
    //    public int semister { get; set; }
    //    public string qualification { get; set; }
    //}
    #endregion

    /// <summary>
    /// This implementation is for person also can use as base class
    /// </summary>
    public class Person
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// This defination is for man
    /// </summary>
    public class Man :Person
    {
        public string PlayingGames { get; set; }
    }

    /// <summary>
    /// This definiation is dor woman
    /// </summary>
    public class Woman : Person
    {
        public string Dancing { get; set; }
    }
}
