namespace MVCApplicationForEvoke.Models
{
    public interface IParentClass
    {
        int ParentProp1 { get; set; }
        int ParentProp2 { get; set; }
        int ParentProp3 { get; set; }
        string ParentProp4 { get; set; }

        string ParentMethod(int p1, int p2);
    }
}