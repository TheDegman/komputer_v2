﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace komputer_v2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AMDvsINTEL : ContentPage
    {
        public AMDvsINTEL()
        {
            InitializeComponent();
            amd.Source = ImageSource.FromResource("komputer_v2.Images.AMD.png");
            intel.Source = ImageSource.FromResource("komputer_v2.Images.Intel.png");
            
        }

        async void amd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new amdFlyout("","","","","","","","","", "", "", "", "", "", "", "", "", "","","",""));
        }

        private async void intel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new intelFlyout("", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", ""));

        }
    }
}