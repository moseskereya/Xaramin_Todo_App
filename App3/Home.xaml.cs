using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetMoviesAsync();
           
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Name.Text)  && !String.IsNullOrWhiteSpace(Price.Text))
            {
                await App.Database.SaveMovieAsync(new Movie
                {
                    Name = Name.Text,
                    Price = decimal.Parse(Price.Text)
                });

                Name.Text  = Price.Text = string.Empty;
                listView.ItemsSource = await App.Database.GetMoviesAsync();
                
            }
        }
    }
}