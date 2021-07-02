using System;
using Xamarin.Forms;

namespace AppRegistro
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            this.main_layout.Orientation = StackOrientation.Vertical;
        }

        private void btn_instruc_Clicked(object sender, EventArgs e)
        {
            lblinfo.Text = "Te doy la bienvenida a esta aplicacion de registro para el juego de cartas Telefunque, " +
                "ingresa los nombres o apodos de los participantes y a continuación podrás " +
                "ingresar la puntuación en cada una de las siete rondas.\n" +
                "Se habilitará la opción de mostrar el puntaje total cuando se hayan llenado los casilleros.\n" +
                "\nJUEGA CON CABEZA!";
            Deshabilitar();
        }

        private void btn_info_Clicked(object sender, EventArgs e)
        {
            lblinfo.Text = "Aplicacion desarrollada remotamente por el programador junior Luis Rodriguez." +
                "\nContacto por si ocurre un bug o crees que deba agregar o mejorar algo en la app: luisrodriguezbobadilla01@gmail.com";
            Deshabilitar();
        }

        private async void btn_inicio_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataPage());
        }

        private void Deshabilitar()
        {
            btn_instruc.IsVisible = false;
            btn_inicio.IsVisible = false;
            btn_info.IsVisible = false;
            btn_Salir.IsVisible = false;
            btn_Atras.IsVisible = true;
        }

        private void HabilitarMenuPrincipal()
        {
            btn_instruc.IsVisible = true;
            btn_inicio.IsVisible = true;
            btn_info.IsVisible = true;
            btn_Salir.IsVisible = true;
            btn_Atras.IsVisible = false;
            lblinfo.Text = string.Empty;
        }

        private void btn_Atras_Clicked(object sender, EventArgs e)
        {

            HabilitarMenuPrincipal();
        }

        private void btn_Salir_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
