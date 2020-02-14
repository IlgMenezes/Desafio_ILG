using Desafio_ILG.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Desafio_ILG.Model;
using Xamarin.Forms.Xaml;

namespace Desafio_ILG
{
    
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        WeatherController weatherController = new WeatherController();

        public MainPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = await weatherController.ListSavedCities();
        }

        private async void OnButtonPesquisarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SearchCityPage());
        }


        private void OnListCitiesSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            City city = (City)e.CurrentSelection[0];
            Navigation.PushAsync(new WeatherDetailPage
            {
                BindingContext = city
            });


        }
    }
}
