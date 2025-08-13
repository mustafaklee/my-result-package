# MyResultPackage

## Basic result nuget package structure for APIs

## Installation
```
dotnet add package MyResults --version 1.0.0
```
## Usage Success

```
public class Product
{
    public int Id { get; set; }
    public string Description { get; set; }
}

using MyResults;

namespace ConsoleApp1
{
    public class Class1
    {
        public static void Main()
        {
            Product prod = new Product
            {
                Id = 1,
                Description = "A product"
            };

            var dataResult = new DataResult<Product>(prod, true, "Product found");

            if (dataResult.Success)
            {
                Console.WriteLine(dataResult.Message);
                Console.WriteLine($"Product ID: {dataResult.Data.Id}");
                Console.WriteLine($"Product Description: {dataResult.Data.Description}");
            }
            Console.ReadLine();
        }
    }
}


```

## Usage Error

```
using MyResults;

namespace ConsoleApp1
{
    public class Class1
    {
        public static void Main() { 

            var dataResult = new DataResult<Product>(new Product(), false, "Product not found");

            if (dataResult.Success)
            {
                Console.WriteLine(dataResult.Message);
                Console.WriteLine($"Product ID: {dataResult.Data.Id}");
                Console.WriteLine($"Product Description: {dataResult.Data.Description}");
            }
            else
            {
                Console.WriteLine("Error: " + dataResult.Message);
            }
                Console.ReadLine();
        }
    }
}

```
