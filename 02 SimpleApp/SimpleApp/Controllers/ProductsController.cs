//Завдання 1

//Доопрацюйте програму SimpleApp.
//До файлу data.txt додайте додаткову інформацію про продукт – опис продукту, кількість одиниць на складі.

//Додайте в опис Details опис продукту і кількість одиниць на складі.

//У поданні List зробіть так, щоб якщо продукту на складі немає,
//відображалося повідомлення навпроти продукту - немає в наявності,
//якщо кількість до 5 одиниць на складі - закінчується, якщо більше 5 одиниць - в наявності.

//Завдання 2

//Зробіть так, щоб у програмі SimpleApp за адресою Home/Index поверталося відображення.
//Зробіть у цьому відображенні посилання «Завантажити опис уроку». При натисканні на посилання повинен завантажуватися цей файл.

//Завдання 3

//Створіть порожню ASP.NET Core програму. Внесіть до нього потрібні зміни для використання MVC.
//Зробіть необхідні зміни в проекті, щоб при запиті /Test/Message відображалася сторінка з повідомленням Hello world,
//а при запиті List/Info - відображався список <ul> з трьома елементами і довільним текстом.
using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleApp.Controllers
{
    public class ProductsController : Controller
    {
        private ProductReader reader;

        // ВНИМАНИЕ.
        // Каждый запрос обрабатывает новый экземпляр контроллера.
        // Конструктор будет вызываться перед вызовом метода List и метода Details
        // После обработки запроса, экземпляр контроллера будет удален из памяти
        public ProductsController()
        {
            reader = new ProductReader();
        }

        // Products/List
        public IActionResult List()
        {
            List<Product> products = reader.ReadFromFile();
            // Возврат представления List и передача представлению модели в виде коллекции products
            // Получить доступ к коллекции в представлении можно будет через свойство представления Model
            return View(products);
        }

        // Products/Details/1
        public IActionResult Details(int id)
        {
            List<Product> products = reader.ReadFromFile();
            Product product = products.Where(x => x.Id == id).FirstOrDefault();

            if (product != null)
            {
                // Возврат представления с именем Details и передача представлению экземпляра product
                // В представление доступ к экземпляру можно получить через свойство представления Model
                return View(product);
            }
            else
            {
                // Возврат ошибки 404
                return NotFound();
            }
        }
    }
}