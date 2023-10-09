namespace Domain.Entities
{

    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
        public bool IsDeleted { get; set; } = false;

        public List<Product> Products { get; set; }
    }
}
