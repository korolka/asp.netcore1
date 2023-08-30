//Задание 1.
//Доработайте приложение SimpleApp.
//В файл data.txt добавьте дополнительную информацию о продукте – описание продукта, количество единиц на складе.
//Добавьте в представление Details описание продукта и количество единиц на складе.
//В представлении List сделайте так, чтобы если продукта на складе нет,
//отображалось сообщение напротив продукта - «нет в наличии»,
//если количество до 5 единиц на складе – «заканчивается», если более 5 единиц – «в наличии».
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace SimpleApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "Default",
                    template: "{controller}/{action}/{id?}");
            });

            // {id?} - данный фрагмент шаблона описывает не обязательный сегмент в адресе запроса.
            // При этом в контроллерах по имени id можно будет получить информацию, которая пришла в запросе
            // Products/Details/10
            // {controller} = Products
            // {action} = Details
            // {id} = 10
        }
    }
}
