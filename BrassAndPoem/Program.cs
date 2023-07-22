﻿
//create a "products" variable here to include at least five Product instances. Give them appropriate ProductTypeIds.

using System.Xml;
using System.Linq;
using System.Collections.Generic;

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

string choice = null;
while (choice != "5")
{
    DisplayMenu();
    choice = Console.ReadLine();
    //implement your loop here
    if (choice == "1")
    {
        DisplayAllProducts(products, productTypes);
    }
    else if (choice == "2")
    {
        DeleteProduct(products, productTypes);
    }
    else if (choice == "3")
    {
       AddProduct(products, productTypes);
    }
    else if (choice == "4")
    {
       UpdateProduct(products, productTypes);
    }
    else if (choice == "5")
    {
        Console.WriteLine("See ya!");
    }
}

void DisplayMenu()
{
    Console.WriteLine(@"Main Menu:
1. Display all products
2. Delete a product
3. Add a new product
4. Update product properties
5. Exit");
}

void DisplayAllProducts(List<Product> products, List<ProductType> productTypes)
{
    for (int i = 0; i < products.Count; i++)
    {
        Product product = products[i];
        ProductType productType = productTypes.FirstOrDefault(pt => pt.Id == product.ProductTypeId);
        Console.WriteLine($"{i + 1}. {product.Name}, Product type {productType.Id}");
    }
}

void DeleteProduct(List<Product> products, List<ProductType> productTypes)
{
    DisplayAllProducts(products, productTypes);
    int response = int.Parse(Console.ReadLine().Trim());
    if (response >= 1 && response <= products.Count)
    {
        products.RemoveAt(response - 1);
        Console.WriteLine("Product removed successfully");
    }
}

void AddProduct(List<Product> products, List<ProductType> productTypes)
{
    Console.WriteLine("Enter the product name: ");
    string Name = Console.ReadLine();
    Console.WriteLine("Enter the product price: ");
    decimal Price = decimal.Parse(Console.ReadLine());
    Console.WriteLine("Choose a product type: 1. Brass, 2. Poem");
    int Id = int.Parse(Console.ReadLine());

    Product newProduct = new Product
    {
        Name = Name,
        Price = Price,
        ProductTypeId = Id,
    };
    products.Add(newProduct);
}
    void UpdateProduct(List<Product> products, List<ProductType> productTypes)
    {
        DisplayAllProducts(products, productTypes);
        Console.WriteLine("Which product would you like to update?");

        int userChoice = int.Parse(Console.ReadLine().Trim());
        int productToUpdate = userChoice - 1;

        Product selectedProduct = products[productToUpdate];
        Console.WriteLine($"You have chosen {selectedProduct.Name}. It costs {selectedProduct.Price} dollars and is of product type {selectedProduct.ProductTypeId}");
        Console.WriteLine("What should the new product name be? ");
        string response1 = Console.ReadLine();
        Console.WriteLine("What should the updated price be? ");
        string response2 = Console.ReadLine();
        Console.WriteLine("What is the updated product type? ");
        string response3 = Console.ReadLine();

        if (!string.IsNullOrEmpty(response1))
        {
            selectedProduct.Name = response1;
        }
        else
        {
            selectedProduct.Name = selectedProduct.Name;
        }

        if (!string.IsNullOrEmpty(response2))
        {
            selectedProduct.Price = decimal.Parse(response2);

        }
        else
        {
            selectedProduct.Price = selectedProduct.Price;
        }

        if (!string.IsNullOrEmpty(response3))
        {
            int productId = int.Parse(response3);
            selectedProduct.ProductTypeId = productId;

        }
        else
        {
            selectedProduct.ProductTypeId = selectedProduct.ProductTypeId;
        }

        Product updatedProduct = new Product
        {
            Name = selectedProduct.Name,
            Price = selectedProduct.Price,
            ProductTypeId = selectedProduct.ProductTypeId,
        };

        selectedProduct = updatedProduct;

        Console.WriteLine("Product updated successfully!");
    }

// don't move or change this!
public partial class Program { }