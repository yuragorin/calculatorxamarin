using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page4 : ContentPage
    {
        private string login;
        private string pas;

        public Page4()
        {
            InitializeComponent();
        }

        public Page4(string login, string pas)
        {
          
            this.login = login;
            this.pas = pas;
          
         
            InitializeComponent();
        }
    }
}