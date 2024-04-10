namespace EFCoreDemo.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public DateTime Created { get; set; }

        public List<User> Users { get; set;} = new List<User>();
    }
}
