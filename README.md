# MyResultPackage

## Basic result nuget package structure for APIs


## Usage Success

```
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
}

using MyResult;
using System;

var prod = new Product
{
    Id = 1,
    Name = "Test Product"
};

var dataResult = DataResult<Product>(prod, true, "Product found");

if (dataResult.Success)
{
    Console.WriteLine(dataResult.Message);
    Console.WriteLine($"Product Id: {dataResult.Data.Id}");
    Console.WriteLine($"Product Name: {dataResult.Data.Name}");
}
else
{
    Console.WriteLine(dataResult.Message);
}

```

## Usage Error

```
using MyResult;
using System;

var dataResult = new DataResult<Product>(null, false, "Product not found");

if (dataResult.Success)
{
    Console.WriteLine(dataResult.Message);
    Console.WriteLine($"Product Id: {dataResult.Data.Id}");
    Console.WriteLine($"Product Name: {dataResult.Data.Name}");
}
else
{
    Console.WriteLine(dataResult.Message);
}
```
