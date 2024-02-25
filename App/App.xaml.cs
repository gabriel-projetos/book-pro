using App.GRRInnovations.BookPro.Views;

namespace App.GRRInnovations.BookPro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HomeView();
        }
    }
}
