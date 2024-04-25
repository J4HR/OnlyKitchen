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
    public partial class Amigos : ContentPage
    {
        public Amigos()
        {
            InitializeComponent();
            // Ejemplo de datos de perfiles
            List<Profile> profiles = new List<Profile>
            {
                new Profile { Name = "John Doe", Email = "john@example.com" },
                new Profile { Name = "Jane Smith", Email = "jane@example.com" },
                new Profile { Name = "Alice Johnson", Email = "alice@example.com" }
                // Agrega más perfiles según sea necesario
            };

            // Asigna la lista de perfiles al ListView
            ProfileListView.ItemsSource = profiles;
        }
        private void ProfileListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Aquí puedes manejar la selección del perfil
            // Por ejemplo, puedes obtener el perfil seleccionado con e.SelectedItem
        }
    }
    // Clase de modelo para representar un perfil
    public class Profile
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}