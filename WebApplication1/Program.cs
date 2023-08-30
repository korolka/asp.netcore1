//Задание
//Создайте пустое ASP.NET Core приложение.
//Внесите в него нужные изменения, для использования MVC.
//Сделайте необходимые изменения в проекте,
//чтобы при запросе /Test/Message отображалась страница с сообщением «Hello world»,
//а при запросе List/Info -отображался список <ul> с тремя элементами и произвольным текстом.
namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute
                (
                    name: "default",
                    pattern: "{controller=list}/{action=info}"
                    );
            });

            app.Run();
        }
    }
}