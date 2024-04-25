using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Onlykitchen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
        }

        async void PerfilButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Perfil());
        }
        async void AmigosButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Amigos());
        }
        async void RecetasButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recetas());
        }
        async void MisRecetasButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recetas());
        }
        async void RecomendadosButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Recetas());
        }
    }
}