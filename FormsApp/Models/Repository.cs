namespace FormsApp.Models
{
    public class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            //category
            _categories.Add(new Category
            {
                CategoryId = 1,
                CategoryName = "Telefon"
            });
            _categories.Add(new Category
            {
                CategoryId = 2,
                CategoryName = "Bilgisayar"
            });

            //product
            _products.Add(new Product
            {
                ProductId = 1,
                CategoryId = 1,
                Name = "Iphone 14",
                Price = 40000,
                IsActive = true,
                Image = "1.jpg"
            });
            _products.Add(new Product
            {
                ProductId = 2,
                CategoryId = 1,
                Name = "Iphone 15",
                Price = 50000,
                IsActive = true,
                Image = "2.jpg"
            });
            _products.Add(new Product
            {
                ProductId = 3,
                CategoryId = 1,
                Name = "Iphone 16",
                Price = 60000,
                IsActive = true,
                Image = "3.jpg"
            });
            _products.Add(new Product
            {
                ProductId = 4,
                CategoryId = 1,
                Name = "Iphone 17",
                Price = 70000,
                IsActive = true,
                Image = "4.jpg"
            });


            _products.Add(new Product
            {
                ProductId = 5,
                CategoryId = 2,
                Name = "Macbook Air",
                Price = 80000,
                IsActive = true,
                Image = "5.jpg"
            });
            _products.Add(new Product
            {
                ProductId = 6,
                CategoryId = 2,
                Name = "Macbook Pro",
                Price = 90000,
                IsActive = true,
                Image = "6.jpg"
            });

        }
        public static List<Product> Products
        {
            get
            {
                return _products;
            }
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if (entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static List<Category> Categories
        {
            get
            {
                return _categories;
            }
        }
    }
}
