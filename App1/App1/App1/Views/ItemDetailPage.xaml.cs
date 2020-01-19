using System.ComponentModel;
using App1.Commands;
using Xamarin.Forms;
using App1.ViewModels;
using MediatR;

namespace App1.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    [QueryProperty("ItemId", "id")]
    public partial class ItemDetailPage : ContentPage
    {
        private readonly IMediator mediator;

        public ItemDetailPage()
        {
            InitializeComponent();
            this.mediator = DependencyService.Resolve<IMediator>();
        }

        public string ItemId { get; set; }

        protected override async void OnAppearing()
        {
            var response = await mediator.Send(new GetDetailsRequest() {Id = this.ItemId});

            BindingContext = new ItemDetailViewModel(response.Item);
        }
    }
}