using FirstApp.Extension;
using FirstApp.Pages;
using FirstApp.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace FirstApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IHost _host;

        public App()
        {
            _host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<MainWindow>();
                    services.AddFactory<TaskWindow>();
                    services.AddTransient<IServiceTest, ServiceTest>();
                }).Build();


        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await _host.StartAsync();

            var page = _host.Services.GetRequiredService<MainWindow>();
            page.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await _host.StopAsync();

            base.OnExit(e);
        }


    }
}
