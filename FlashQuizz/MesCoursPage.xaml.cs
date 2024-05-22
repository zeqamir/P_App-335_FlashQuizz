using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace FlashQuizz
{
    public partial class MesCoursPage : ContentPage
    {
        public ObservableCollection<Cours> CoursList { get; set; }

        public MesCoursPage()
        {
            this.InitializeComponent();

            CoursList = new ObservableCollection<Cours>
            {
                new Cours { Title = "Hamlet", Progress = "37%", ImageSource = "hamlet.jpg" },
                new Cours { Title = "Love Finds the Way", Progress = "100%", ImageSource = "love_finds_the_way.jpg" },
            };

            BindingContext = this;
        }
    }

    public class Cours
    {
        public string Title { get; set; }
        public string Progress { get; set; }
        public string ImageSource { get; set; }
    }
}
