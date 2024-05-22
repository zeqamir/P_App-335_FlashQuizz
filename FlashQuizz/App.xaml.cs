namespace FlashQuizz
{
    public partial class App : Application
    {
        public App()
        {
            this.InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

    }
}
