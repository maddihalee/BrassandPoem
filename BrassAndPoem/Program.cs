
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

using System.Xml;
using System.Linq;

List<Product> products = new List<Product>()
{
    new Product()
    {
        Name = "Trumpet",
        Price = 30.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Bugle",
        Price = 25.00M,
        ProductTypeId = 1
    },
    new Product()
    {
        Name = "Milk and Honey",
        Price = 7.83M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "Where the Sidewalk Ends",
        Price = 13.89M,
        ProductTypeId = 2
    },
    new Product()
    {
        Name = "The Sun and Her Flowers",
        Price = 9.99M,
        ProductTypeId = 2
    }
};

//create a "productTypes" variable here with a List of ProductTypes, and add "Brass" and "Poem" types to the List. 

List<ProductType> productTypes = new List<ProductType>()
{
    new ProductType()
    {
        Title = "Brass",
        Id = 1,
    },
    new ProductType()
    {
        Title = "Poem",
        Id = 2,
    }
};


//put your greeting here

Console.WriteLine("Welcome to Brass and Poems!");

//implement your loop here

string choice = null;
while (choice != "0")
{
    Console.WriteLine(@"Main Menu:
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
}

choice = Console.ReadLine();

if (choice == "1")
{
    List<ProductType> productIds = productTypes.Where(pt => pt.Id > 0).ToList();

    foreach (Product product in products)
    {
        Product chosenProduct = new Product();
        for (int i = 0; i < productTypes.Count; i++)
        {
            Product newProduct = new Product();

            Console.WriteLine($"{i + 1}. {newProduct.Name}, Product type is {productIds}");
        }
    }
}
else if (choice == "2")
{
    throw new NotImplementedException();
}
else if (choice == "3")
{
    throw new NotImplementedException();
}
else if (choice == "4")
{
    throw new NotImplementedException();
}
else if (choice == "5")
{
    throw new NotImplementedException();
}


void DisplayMenu()
{
    throw new NotImplementedException();
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

void UpdateProduct(List<Product> products, List<ProductType> productTypes)
{
    throw new NotImplementedException();
}

// don't move or change this!
public partial class Program { }