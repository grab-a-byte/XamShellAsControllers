using System;
using System.Collections.Generic;
using App1.Views;
using Xamarin.Forms;

namespace App1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        void RegisterRoutes()
        {
            Routing.RegisterRoute("ItemDetailPage", typeof(ItemDetailPage));
        }
    }
}
