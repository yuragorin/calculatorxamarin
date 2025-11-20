using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static System.Net.Mime.MediaTypeNames;

namespace calculator
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            if (Procent != null)
                Procent.Text = String.Format("Выбрано: {0:F1}", e.NewValue);
        }

        private void AmountEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            
                


         
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            if (double.TryParse(AmountEntry.Text, out double Sum) && Sum != 0 && Sum > 0)
            {
                double sum = Convert.ToDouble(AmountEntry.Text);
                if (int.TryParse(MounthEntry.Text, out int Mount) && 0 < Mount && Mount <= 12)
                {
                    int mount = Convert.ToInt32(MounthEntry.Text);


                    double stavka = sum / mount;
                    if (Procent != null)
                    {

                        double procstavka = (stavka * Sliderr.Value) + stavka;


                        MountPay.Text = procstavka.ToString();
                        Summ.Text = (procstavka * Mount).ToString();
                        Pereplata.Text = ((procstavka * Mount) - Sum).ToString();

                    }
                }
            }
        }
    }
}