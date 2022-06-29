// See https://aka.ms/new-console-template for more information

using csharp_oop_shop;

Product prod1 = new Product("pasta", 0.80m, 5);


Console.WriteLine(prod1.Id);

Console.WriteLine(prod1.IvaPrice());

Console.WriteLine(prod1.FullName());
