using System;
using App1.Models;
using Xamarin.Forms;
//using Xamarin.Forms.Xaml;
using App1.Services;
using App1.Views;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Xamarin.Forms.Internals;

namespace App1
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            var serviceProvider = SetupDependencyInjection();
            DependencyResolver.ResolveUsing(serviceProvider.GetService);

            MainPage = new AppShell();
        }

        ServiceProvider SetupDependencyInjection()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IDataStore<Item>, MockDataStore>();
            serviceCollection.AddMediatR(typeof(App).Assembly);
            return serviceCollection.BuildServiceProvider();
        }
    }
}
