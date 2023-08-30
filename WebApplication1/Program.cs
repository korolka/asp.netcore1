//�������
//�������� ������ ASP.NET Core ����������.
//������� � ���� ������ ���������, ��� ������������� MVC.
//�������� ����������� ��������� � �������,
//����� ��� ������� /Test/Message ������������ �������� � ���������� �Hello world�,
//� ��� ������� List/Info -����������� ������ <ul> � ����� ���������� � ������������ �������.
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