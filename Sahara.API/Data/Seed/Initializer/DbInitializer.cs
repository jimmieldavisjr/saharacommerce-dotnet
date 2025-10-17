using Microsoft.EntityFrameworkCore;
using Sahara.API.Data.Contexts;
using Sahara.API.Entities;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Sahara.API.Data.Seed.Initializer
{
    public static class DbInitializer
    {
        public static async Task SeedAsync(AppDbContext context)
        {
            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;
            options.Converters.Add(new JsonStringEnumConverter());

            if (!context.Admins.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/Admins.json");

                var admins = JsonSerializer.Deserialize<List<Admin>>(json, options);

                if (admins != null)
                {
                    if (admins != null)
                    {
                        await context.Database.OpenConnectionAsync();
                        await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Admins] ON;");
                        context.Admins.AddRange(admins);
                        await context.SaveChangesAsync();
                        await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Admins] OFF;");
                        await context.Database.CloseConnectionAsync();
                        Console.WriteLine("Seeded Admins");
                    }
                }
            }

            else
            {
                Console.WriteLine("Admins already exist");
            }

            if (!context.Users.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/Users.json");

                var users = JsonSerializer.Deserialize<List<User>>(json, options);

                if (users != null)
                {
                    await context.Database.OpenConnectionAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Users] ON;");
                    context.Users.AddRange(users);
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Users] OFF;");
                    await context.Database.CloseConnectionAsync();
                    Console.WriteLine("Seeded Users");
                }
            }
            else
            {
                Console.WriteLine("Users already exist");
            }

            if (!context.Customers.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/Customers.json");

                var customers = JsonSerializer.Deserialize<List<Customer>>(json, options);

                if (customers != null)
                {
                    await context.Database.OpenConnectionAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Customers] ON;");
                    context.Customers.AddRange(customers);
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Customers] ON;");
                    await context.Database.CloseConnectionAsync();
                    Console.WriteLine("Seeded Customers");
                }
            }

            else
            {
                Console.WriteLine("Customers already exist");
            }

            if (!context.Vendors.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/Vendors.json");

                var vendors = JsonSerializer.Deserialize<List<Vendor>>(json, options);

                if (vendors != null)
                {
                    await context.Database.OpenConnectionAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Vendors] ON;");
                    context.Vendors.AddRange(vendors);
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Vendors] OFF;");
                    await context.Database.CloseConnectionAsync();
                    Console.WriteLine("Seeded Vendors");
                }
            }

            else
            {
                Console.WriteLine("Vendors already exist");
            }

            if (!context.Categories.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/Categories.json");

                var categories = JsonSerializer.Deserialize<List<Category>>(json);

                if (categories != null)
                {
                    await context.Database.OpenConnectionAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Categories] ON;");
                    context.Categories.AddRange(categories);
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Categories] OFF;");
                    await context.Database.CloseConnectionAsync();
                    Console.WriteLine("Seeded Categories");
                }
            }

            else
            {
                Console.WriteLine("Categories already exist");
            }

            if (!context.Products.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/Products.json");

                var products = JsonSerializer.Deserialize<List<Product>>(json, options);

                if (products != null)
                {
                    await context.Database.OpenConnectionAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Products] ON;");
                    context.Products.AddRange(products);
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Products] OFF;");
                    await context.Database.CloseConnectionAsync();
                    Console.WriteLine("Seeded Products");
                }
            }

            else
            {
                Console.WriteLine("Products already exist");
            }


            if (!context.Orders.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/Orders.json");

                var orders = JsonSerializer.Deserialize<List<Order>>(json, options);

                if (orders != null)
                {
                    await context.Database.OpenConnectionAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Orders] ON;");
                    context.Orders.AddRange(orders);
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Orders] OFF;");
                    await context.Database.CloseConnectionAsync();
                    Console.WriteLine("Seeded Orders");
                }
            }

            else
            {
                Console.WriteLine("Orders already exist");
            }

            if (!context.OrderItems.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/OrderItems.json");

                var orderItems = JsonSerializer.Deserialize<List<OrderItem>>(json);

                if (orderItems != null)
                {
                    await context.Database.OpenConnectionAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [OrderItems] ON;");
                    context.OrderItems.AddRange(orderItems);
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [OrderItems] OFF;");
                    await context.Database.CloseConnectionAsync();
                    Console.WriteLine("Seeded Order Items");
                }
            }

            else
            {
                Console.WriteLine("Order Items already exist");
            }

            if (!context.Payments.Any())
            {
                var json = await File.ReadAllTextAsync("Data/Seed/Payments.json");

                var payments = JsonSerializer.Deserialize<List<Payment>>(json, options);

                if (payments != null)
                {
                    await context.Database.OpenConnectionAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Payments] ON;");
                    context.Payments.AddRange(payments);
                    await context.SaveChangesAsync();
                    await context.Database.ExecuteSqlRawAsync("SET IDENTITY_INSERT [Payments] OFF;");
                    await context.Database.CloseConnectionAsync();
                    Console.WriteLine("Seeded Payments");
                }
            }

            else
            {
                Console.WriteLine("Payments already exist");
            }

            await context.SaveChangesAsync();
        }
    }
}
