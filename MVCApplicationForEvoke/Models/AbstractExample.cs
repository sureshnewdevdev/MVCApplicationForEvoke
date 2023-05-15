namespace MVCApplicationForEvoke.Models
{
    public class ParentClass : IParentClass
    {
        public int ParentProp1 { get; set; }
        public int ParentProp2 { get; set; }
        public int ParentProp3 { get; set; }
        public string ParentProp4 { get; set; }

        public string ParentMethod(int p1, int p2)
        {
            return (p1 + p2).ToString();
        }
    }

    public class ChildClass : ParentClass
    {

    }

    public class ExcuteClass
    {
        public void DraftMethod()
        {
            ChildClass childClass = new ChildClass();
        }

    }
}
