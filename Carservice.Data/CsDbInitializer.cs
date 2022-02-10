using Carservice.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Carservice.Data
{
    public class CsDbInitializer : DropCreateDatabaseIfModelChanges<CsDbContext>
    {
        protected override void Seed(CsDbContext db)
        {
            db.Employees.Add(new Employee { Surname = "Кочнев", Name = "Иван", Patronymic = "Петрович", Position = new Position { PositionName = "Инженер" } });
            db.Employees.Add(new Employee { Surname = "Федоров", Name = "Сергей", Patronymic = "Павлович", Position = new Position { PositionName = "Слесарь" } });
            db.Employees.Add(new Employee { Surname = "Корчагин", Name = "Николай", Patronymic = "Александрович", Position = new Position { PositionName = "Мастер" } });

            db.Measures.Add(new Measure { MeasureName = "Штука", MeasureShortName = "шт." });
            db.Measures.Add(new Measure { MeasureName = "Литр", MeasureShortName = "л." });
            db.Measures.Add(new Measure { MeasureName = "Комплект", MeasureShortName = "к-т" });
            db.Measures.Add(new Measure { MeasureName = "Метр", MeasureShortName = "м." });
            db.SaveChanges();

            db.CarsBrands.Add(new CarBrand
            {
                BrandName = "BMV",
                CarModels = new List<CarModel> {
                              new CarModel{ModelName = "X5" }, new CarModel{ModelName ="X3"},
                              new CarModel{ModelName ="X6"}, new CarModel {ModelName ="X7"}}
            });
            db.CarsBrands.Add(new CarBrand
            {
                BrandName = "Toyota",
                CarModels = new List<CarModel> {
                              new CarModel{ModelName = "Camry" }, new CarModel{ModelName = "Corolla"},
                              new CarModel{ModelName = "Land Cruiser"}, new CarModel {ModelName = "Highlander"}}
            });
            db.CarsBrands.Add(new CarBrand
            {
                BrandName = "Nissan",
                CarModels = new List<CarModel> {
                              new CarModel{ModelName = "Pathfinder" }, new CarModel{ModelName ="Qashqai"},
                              new CarModel{ModelName ="X-Trail"}, new CarModel {ModelName ="Almera"}}
            });
            db.CarsBrands.Add(new CarBrand
            {
                BrandName = "Honda",
                CarModels = new List<CarModel> {
                              new CarModel{ModelName = "Accord" }, new CarModel{ModelName ="C-RV"},
                              new CarModel{ModelName ="Pilot"}, new CarModel {ModelName ="Civic"}}
            });

            db.SaveChanges();


            db.Services.Add(new Service { ServiceName = "Эндоскопия цилиндропоршневой группы (без учета обеспечения доступа)", ServiceCost = 1500, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Сканирование и удаление ошибок электронных систем", ServiceCost = 800, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Диагностика форсунок на стенде без учета снятия", ServiceCost = 150, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена тормозного барабана", ServiceCost = 500, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена передних тормозных дисков", ServiceCost = 700, MeasureId = 3 });
            db.Services.Add(new Service { ServiceName = "Замена задних тормозных дисков", ServiceCost = 700, MeasureId = 3 });
            db.Services.Add(new Service { ServiceName = "Замена датчика давления масла", ServiceCost = 250, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена датчика MAF (ДМРВ)", ServiceCost = 300, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена датчика положения дроссельной заслонки", ServiceCost = 500, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена датчика ABS", ServiceCost = 600, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена стартера", ServiceCost = 700, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена датчика температуры охлаждающей жидкости", ServiceCost = 300, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Демонтаж-монтаж поворотного кулака", ServiceCost = 1500, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена шаровой опоры (резьбовое соединение)", ServiceCost = 500, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Перепресовка шаровой опоры при снятом рычаге", ServiceCost = 500, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена передней опоры стойки", ServiceCost = 800, MeasureId = 1 });
            db.Services.Add(new Service { ServiceName = "Замена задней опоры стойки", ServiceCost = 800, MeasureId = 1 });

            db.Clients.Add(new Client { Surname = "Иванов", Name = "Иван", Patronymic = "Иванович", Cars = new List<Car> { new Car { CarModelId = 5, Color = "Красный", RegNumber = "C 568 TO 54", ProductionDate = DateTime.Now.AddYears(-10) } } });
            db.Clients.Add(new Client { Surname = "Коршунов", Name = "Федор", Patronymic = "Владимирович", Cars = new List<Car> { new Car { CarModelId = 8, Color = "Серый", RegNumber = "A 456 AK 54", ProductionDate = DateTime.Now.AddYears(-15) } } });
            db.Clients.Add(new Client { Surname = "Петров", Name = "Сергей", Patronymic = "Михайлович", Cars = new List<Car> { new Car { CarModelId = 6, Color = "Бежевфй", RegNumber = "P 225 OE 54", ProductionDate = DateTime.Now.AddYears(-5) } } });
            db.Clients.Add(new Client { Surname = "Добрынин", Name = "Александр", Patronymic = "Владимирович", Cars = new List<Car> { new Car { CarModelId = 10, Color = "Синий", RegNumber = "M 568 MH 54", ProductionDate = DateTime.Now.AddYears(-12) } } });

            db.SaveChanges();

            db.Orders.Add(new Order
            {
                OpenDate = DateTime.Now.AddDays(-2),
                DueDate = DateTime.Now.AddDays(+2),
                CarId = 1,
                EmployeeId = 1,
                Services = new List<OrderService>
            { new OrderService { ServiceId = 1, NumberOfServices = 2},
            new OrderService{ ServiceId = 5, NumberOfServices = 1},
            new OrderService { ServiceId = 3, NumberOfServices = 1},
            new OrderService { ServiceId = 4, NumberOfServices = 2}}
            });
            db.Orders.Add(new Order
            {
                OpenDate = DateTime.Now.AddDays(-1),
                DueDate = DateTime.Now.AddDays(+5),
                CarId = 2,
                EmployeeId = 2,
                Services = new List<OrderService>
            { new OrderService { ServiceId = 10, NumberOfServices = 2},
            new OrderService{ ServiceId = 6, NumberOfServices = 1},
            new OrderService { ServiceId = 3, NumberOfServices = 1},
            new OrderService { ServiceId = 4, NumberOfServices = 2}}
            });
            db.Orders.Add(new Order
            {
                OpenDate = DateTime.Now.AddDays(-3),
                DueDate = DateTime.Now.AddDays(+1),
                CarId = 3,
                EmployeeId = 3,
                Services = new List<OrderService>
            { new OrderService { ServiceId = 7, NumberOfServices = 1},
            new OrderService{ ServiceId = 5, NumberOfServices = 1},
            new OrderService { ServiceId = 8, NumberOfServices = 1},
            new OrderService { ServiceId = 4, NumberOfServices = 1}}
            });
            db.Orders.Add(new Order
            {
                OpenDate = DateTime.Now.AddDays(-2),
                DueDate = DateTime.Now.AddDays(+4),
                CarId = 4,
                EmployeeId = 3,
                Services = new List<OrderService>
            { new OrderService { ServiceId = 1, NumberOfServices = 1},
            new OrderService{ ServiceId = 15, NumberOfServices = 1},
            new OrderService { ServiceId = 11, NumberOfServices = 1},
            new OrderService { ServiceId = 4, NumberOfServices = 1}}
            });
            db.SaveChanges();
        }
    }
}
