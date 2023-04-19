namespace market.item.Data
{
    public static class ItemDataService
    {
        public static List<Models.Item> items = new List<Models.Item>()
        {
            new Models.Item
            {
                Id = 1,
                Name = "T-shirt",
                Price = 1000.00,
                Description = "A comfortable cotton t-shirt."
            },
            new Models.Item
            {
                Id = 2,
                Name = "Jeans",
                Price = 3000.00,
                Description = "Classic denim jeans with a relaxed fit."
            },
            new Models.Item
            {
                Id = 3,
                Name = "Sneakers",
                Price = 3999.00,
                Description = "Stylish and comfortable sneakers for everyday wear."
            },
            new Models.Item
            {
                Id = 4,
                Name = "Dress",
                Price = 1999.00,
                Description = "A beautiful floral dress for special occasions."

            },
            new Models.Item
            {
                Id = 5,
                Name = "Leather Jacket",
                Price = 5800.00,
                Description = "A classic leather jacket for a stylish look."
            },
            new Models.Item
            {
                Id = 6,
                Name = "Running Shoes",
                Price = 4000.00,
                Description = "High-performance running shoes with cushioning and support."
            },
        };
    }
}
