using Desafio_ILG.Controller;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Desafio_ILG
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherDetailPage : ContentPage
    {
        WeatherController weatherController = new WeatherController();

        public WeatherDetailPage()
        {
            InitializeComponent();
        }

        private async void OnButtonWatchClicked(object sender, EventArgs e)
        {
            Model.City city = (Model.City)this.BindingContext;
            if (await weatherController.SaveCity(city))
            {
                await Navigation.PopToRootAsync();
            }
            else
            {
                await DisplayAlert("Alerta", "Houve um problema para salvar", "Ok");
            }

        }
    }
}