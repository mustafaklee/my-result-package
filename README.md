# MyResultPackage

## Basic result nuget package structure for APIs

## Structure
MyResultPackage is a NuGet package designed to simplify creating a standardized and consistent result structure for APIs.  
With this package, you can manage success, error, data, and their message combinations in a type-safe and readable way.

| Scenario | Class to Use |
|----------|--------------|
| Return only an error state with a message | `ErrorResult` |
| Return only a success state with a message | `SuccessResult` |
| Return data + error state + message | `ErrorDataResult<T>` |
| Return data + success state + message | `SuccessDataResult<T>` |





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
