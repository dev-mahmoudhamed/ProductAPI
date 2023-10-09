namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; } = false;

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public string UserId { get; set; }
        public AppUser AppUser { get; set; }

    }
}
