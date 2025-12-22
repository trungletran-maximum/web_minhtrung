using lab8.Models;

namespace lab8.Data
{
    public class DbSeeder
    {
        public static void Seed(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // ===== BRAND =====
            if (!context.Brands.Any())
            {
                var toyota = new Brand { Name = "Toyota", Country = "Japan" };
                var hyundai = new Brand { Name = "Hyundai", Country = "Korea" };

                context.Brands.AddRange(toyota, hyundai);
                context.SaveChanges();

                // ===== CAR MODEL =====
                var viosModel = new CarModel { Name = "Vios", BrandId = toyota.Id };
                var camryModel = new CarModel { Name = "Camry", BrandId = toyota.Id };
                var accentModel = new CarModel { Name = "Accent", BrandId = hyundai.Id };

                context.CarModels.AddRange(viosModel, camryModel, accentModel);
                context.SaveChanges();

                // ===== CAR =====
                var car1 = new Car { Name = "Vios 2023", BrandId = toyota.Id };
                var car2 = new Car { Name = "Camry 2024", BrandId = toyota.Id };
                var car3 = new Car { Name = "Accent 2023", BrandId = hyundai.Id };

                context.Cars.AddRange(car1, car2, car3);
                context.SaveChanges();

                // ===== CUSTOMER =====
                var cus1 = new Customer
                {
                    FullName = "Nguyen Van A",
                    Phone = "0901234567"
                };

                var cus2 = new Customer
                {
                    FullName = "Tran Thi B",
                    Phone = "0912345678"
                };

                context.Customers.AddRange(cus1, cus2);
                context.SaveChanges();

                // ===== ORDER =====
                var order1 = new Order
                {
                    CustomerId = cus1.Id,
                    OrderDate = DateTime.Now
                };

                context.Orders.Add(order1);
                context.SaveChanges();

                // ===== ORDER DETAIL =====
                var od1 = new OrderDetail
                {
                    OrderId = order1.Id,
                    CarId = car1.Id,
                    Price = 450000000
                };

                var od2 = new OrderDetail
                {
                    OrderId = order1.Id,
                    CarId = car2.Id,
                    Price = 1200000000
                };

                context.OrderDetails.AddRange(od1, od2);
                context.SaveChanges();
            }
        }
    }
}
