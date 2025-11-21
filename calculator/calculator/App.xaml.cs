using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new Welcome());
            CarouselPage carouselPage = new CarouselPage();
            carouselPage.Children.Add(new Welcome());
            carouselPage.Children.Add(new Page1());
            carouselPage.Children.Add(new Page2());
            carouselPage.Children.Add(new Page3());
            carouselPage.Children.Add(new Page4());


            MainPage = carouselPage;
        

        }
       
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
