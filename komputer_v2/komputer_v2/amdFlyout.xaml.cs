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
    public partial class amdFlyout : FlyoutPage
    {
        


        /*string name, string img,string price int id*/


        public amdFlyout(string CPUname,string CPUprice, string CPUimg, string MOBOname,string MOBOprice, string MOBOimg, string RAMname, string RAMprice, string RAMimg)
        {
            InitializeComponent();
            //komponente.ItemsSource = new List<DIJELOVI>
            //{
            //    new DIJELOVI{ime="CPU"},
            //    new DIJELOVI{ime="Motherboard"},
            //    new DIJELOVI{ime="RAM"},

            //    new DIJELOVI{ime="GPU"},
            //    new DIJELOVI{ime="PSU"},
            //    new DIJELOVI{ime="Case"}


            //};

            //switch (id)
            //{
            //    case 0:
            //        CPUname = name;
            //        CPUimg = img;
            //        CPUprice = price;
            //        break;
            //    case 1:
            //        MOBOname = name;
            //        MOBOimg = img;
            //        MOBOprice = price;
            //        break;
            //    case 2:
            //        ramName.Text = name;
            //        ramIMG.Source = img;
            //        ramPrice.Text = price;
            //        break;
            //    case 3:
            //        gpuName.Text = name;
            //        gpuIMG.Source = img;
            //        gpuPrice.Text = price;
            //        break;
            //    case 4:
            //        psuName.Text = name;
            //        psuIMG.Source = img;
            //        psuPrice.Text = price;

            //        break;
            //    case 5:
            //        caseName.Text = name;
            //        caseIMG.Source = img;
            //        casePrice.Text = price;
            //        break;


            //}
            cpuName.Text = CPUname;
            cpuIMG.Source = CPUimg;
            cpuPrice.Text = CPUprice;

            motherboardName.Text = MOBOname;
            motherboardIMG.Source = MOBOimg;
            motherboardPrice.Text = MOBOprice;

            ramName.Text = RAMname;
            ramIMG.Source = RAMimg;
            ramPrice.Text = RAMprice;



        }
        

        private async void CPU_Clicked(object sender, EventArgs e)
        {
            //CPU.Background = new SolidColorBrush(Color.FromRgb(48, 48, 48));
            CPU1.Background = new SolidColorBrush(Color.FromRgb(104, 104, 104));
            await Navigation.PushAsync(new amdComponents());
            Motherboard1.Background = new SolidColorBrush(Color.FromRgb(46, 46, 46));

        }

        private async void Motherboard_Clicked(object sender, EventArgs e)
        {
            Motherboard1.Background = new SolidColorBrush(Color.FromRgb(104, 104, 104));
            await Task.Delay(40);
            await Navigation.PushAsync(new amdComponents());
            Motherboard1.Background = new SolidColorBrush(Color.FromRgb(46, 46, 46));

        }

        private async void RAM_Clicked(object sender, EventArgs e)
        {
            RAM1.Background = new SolidColorBrush(Color.FromRgb(104, 104, 104));
            await Task.Delay(40);

            RAM1.Background = new SolidColorBrush(Color.FromRgb(46, 46, 46));

        }

        private async void GPU_Clicked(object sender, EventArgs e)
        {
            GPU1.Background = new SolidColorBrush(Color.FromRgb(104, 104, 104));
            await Task.Delay(40);

            GPU1.Background = new SolidColorBrush(Color.FromRgb(46, 46, 46));

        }

        private async void PSU_Clicked(object sender, EventArgs e)
        {
            PSU1.Background = new SolidColorBrush(Color.FromRgb(104, 104, 104));
            await Task.Delay(40);

            PSU1.Background = new SolidColorBrush(Color.FromRgb(46, 46, 46));

        }

        private async void case_Clicked(object sender, EventArgs e)
        {
            Case1.Background = new SolidColorBrush(Color.FromRgb(104, 104, 104));
            await Task.Delay(40);
            await Navigation.PushAsync(new SignUp());
            PSU1.Background = new SolidColorBrush(Color.FromRgb(46, 46, 46));

        }
    }
}