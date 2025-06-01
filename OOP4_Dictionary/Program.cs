using OOP4_Dictionary;

Category category = new Category();
category.AddProduct(new Product
{
    Id = 1,
    Name = "Test",
    Price = 122.2f,
    Quantity = 10
});

category.AddProduct(new Product
{
    Id = 2,
    Name = "Test3",
    Price = 444.2f,
    Quantity = 10
});

category.AddProduct(new Product
{
    Id = 3,
    Name = "Test3",
    Price = 444.2f,
    Quantity = 14
});

category.AddProduct(new Product
{
    Id = 4,
    Name = "Test2",
    Price = 3.2f,
    Quantity = 11
});

category.AddProduct(new Product
{
    Id = 5,
    Name = "Test3",
    Price = 444.2f,
    Quantity = 12
});


Product product = new Product()
{
    Id = 1,
    Name = "Updated",
    Price = 100000.1f,
    Quantity = 9999
};

Console.WriteLine(category.GetProduct(product.Id));
category.EditProduct(product);
Console.WriteLine(category.GetProduct(product.Id));

if (category.RemoveProduct(product.Id))
{
    Console.WriteLine("Removed successfully!");
}
else
{
    Console.WriteLine("Can not remove product!");
};

