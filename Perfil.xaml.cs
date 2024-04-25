using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Onlykitchen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Perfil : ContentPage
    {
        
        public Perfil()
        {
            InitializeComponent();
            loadUserData();

        }
        private void loadUserData()
        {
            NombreEntry.IsReadOnly = true;
            EdadEntry.IsReadOnly = true;
            EmailEntry.IsReadOnly = true;
            NombreEntry.Text = "Alan Brito";
            EdadEntry.Text = "22";
            EmailEntry.Text = "correo@dom.com";
        }
        private void clearUserData()
        {
            NombreEntry.IsReadOnly = false;
            EdadEntry.IsReadOnly = false;
            EmailEntry.IsReadOnly = false;
            NombreEntry.Text = string.Empty;
            EdadEntry.Text = string.Empty;
            EmailEntry.Text = string.Empty;
        }

        async void ActualizarPerfil_Clicked(object sender, EventArgs e)
        {
            if (bEliminar.Text == "Cancelar")
            {
                bool answer = await DisplayAlert("Actualizar cuenta?", "tus datos van a cambiar", "Aceptar", "Cancelar");
                Debug.WriteLine("Answer: " + answer);
                if (answer)
                {
                    bEliminar.Text = "Eliminar";
                    loadUserData();
                }
                
            }
            else
            {
                bEliminar.Text = "Cancelar";
                clearUserData();
            }
                
            
        }

        async void EliminarPerfil_Clicked(object sender, EventArgs e)
        {
            if (bEliminar.Text == "Cancelar")
            {
                bEliminar.Text = "Eliminar";
                loadUserData();
            }
            else
            {
                bool answer = await DisplayAlert("Eliminar cuenta?", "se eliminaran todos tus datos", "Aceptar", "Cancelar");
                Debug.WriteLine("Answer: " + answer);
            }
            
        }
    }
}