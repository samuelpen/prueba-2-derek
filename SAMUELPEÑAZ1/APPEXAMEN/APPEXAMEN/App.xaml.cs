using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using APPEXAMEN.View;
using APPEXAMEN.ViewModel;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace APPEXAMEN
{
    public partial class App : Application
    {
        public App(String filename)
        {
            InitializeComponent();
            SQLViewModel.Inicializador(filename);
            MainPage = new NotesView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
