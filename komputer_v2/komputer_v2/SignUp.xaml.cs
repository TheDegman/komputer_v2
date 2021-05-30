using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace komputer_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        public SignUp()
        {
            InitializeComponent();
            logo.Source = ImageSource.FromResource("komputer_v2.Images.LOGO.png");
        }

        private async void signUp_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage(EMAIL.Text, LOZINKA1.Text));

        }

        private async void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            await Navigation.PushAsync(new MainPage(EMAIL.Text, LOZINKA1.Text));
        }
    }
}