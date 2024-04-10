namespace EFCoreDemo.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int IdUser { get; set; }
        public string Name { get; set; }
        public bool State { get; set; }
        public DateTime Created { get; set; }

        public User User { get; set; }
        public List<Product> Products { get; set;} = new List<Product>();
    }
}
