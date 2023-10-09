namespace Application.DTOs
{
    public class ProductDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public bool IsDeleted { get; set; } = false;

        public string CategoryName { get; set; }

        public string UserId { get; set; }

    }
}
