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
    public partial class Recetas : ContentPage
    {
        public Recetas()
        {
            InitializeComponent();
            // Ejemplo de datos de recetas
            List<Recipe> recipes = new List<Recipe>
            {
                new Recipe { Name = "Spaghetti Carbonara", Description = "Deliciosa pasta italiana con salsa cremosa de huevo, queso y tocino." },
                new Recipe { Name = "Chicken Stir-Fry", Description = "Salteado rápido y fácil de pollo con verduras en una salsa de soja y jengibre." },
                new Recipe { Name = "Vegetable Curry", Description = "Curry vegetariano lleno de sabor con una variedad de verduras y especias." }
                // Agrega más recetas según sea necesario
            };

            // Asigna la lista de recetas al ListView
            RecipeListView.ItemsSource = recipes;
        }
        private void RecipeListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // Aquí puedes manejar la selección de la receta
            // Por ejemplo, puedes obtener la receta seleccionada con e.SelectedItem
        }
    }
    // Clase de modelo para representar una receta
    public class Recipe
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}