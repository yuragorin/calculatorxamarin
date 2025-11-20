using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Sharpnado.Presentation.Forms;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calculator
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Welcome : ContentPage
	{
		public Welcome ()
		{
            
            InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
		{
			string login = Log.Text;
			string pas =Pass.Text;
			if (string.IsNullOrWhiteSpace(Log.Text)|| string.IsNullOrWhiteSpace(Pass.Text))
            {
                DisplayAlert("Ошибка", "Поле не может быть пустым", "OK");
                return; 
               
                
            }
			else
			{
                login = null;
                pas = null;
                Navigation.PushAsync(new MainPage());
            }

        }
    }
}