using Microsoft.Maui.Controls;

namespace FlashQuizz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void OnMesCoursClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MesCoursPage());
        }

        //private async void OnDecouvrirClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new DecouvrirPage());
        //}

        //private async void OnParametresClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ParametresPage());
        //}

        //private async void OnCompteClicked(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new ComptePage());
        //}
    }
}
