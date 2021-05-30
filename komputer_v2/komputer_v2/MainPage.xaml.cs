using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace komputer_v2
{
    public partial class MainPage : ContentPage
    {
        string email;
        string lozinka;
        string provjeraEmail;
        string provjeraLozinka;

        string nista = "";

        int check=0;

        public MainPage(string checkEmail, string checkLozinka)
        {
            InitializeComponent();
            provjeraEmail = checkEmail;
            provjeraLozinka = checkLozinka;


            logo.Source = ImageSource.FromResource("komputer_v2.Images.LOGO.png");
        }

        async private void logIn_Clicked(object sender, EventArgs e)
        {
            int i = 0;
            email = EMAIL.Text;
            lozinka = LOZINKA.Text;
            if (email == provjeraEmail)
            {
                i++;
            }
            if (lozinka == provjeraLozinka)
            {
                i++;

            }
            if (i == 2)
            {
                await Navigation.PushAsync(new AMDvsINTEL());

            }
            if (i != 2)
            {
                EMAIL.Text = nista;
                LOZINKA.Text = nista;
                error.Text = "You have entered wrong password or email, try again";
                //await DisplayAlert("Alert", "Wrong email or password","Ok");

            }

        }

       

        private async void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            await Navigation.PushAsync(new SignUp());
            check++;

        }
    }
}
