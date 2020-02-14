using Desafio_ILG.Controller;
using Desafio_ILG.Model;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Desafio_ILG
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchCityPage : ContentPage
    {
        WeatherController weatherController = new WeatherController();

        public SearchCityPage()
        {
            InitializeComponent();

            lvCities.ItemsSource = (List<String>)weatherController.LoadJsonCities();
            
        }


        private async void OnButtonPesquisarClicked(object sender, EventArgs e)
        {
            
            City city = await weatherController.Search(cityEntry.Text);

            await Navigation.PushAsync(new WeatherDetailPage
            {
                BindingContext = city
            });

        }

        private async void OnListCitySelectionChanged(object sender, SelectedItemChangedEventArgs e)
        {
            City city = await weatherController.Search((String)e.SelectedItem);

            await Navigation.PushAsync(new WeatherDetailPage
            {
                BindingContext = city
            });
        }

    }
}