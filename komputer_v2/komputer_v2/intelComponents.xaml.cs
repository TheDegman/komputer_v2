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
    public partial class intelComponents : TabbedPage
    {
        int check = 0;
        int check_cpu = 0;
        int check_mobo = 0;

        string moboName;
        string moboPrice;
        string moboIMG;

        string cpuName;
        string cpuPrice;
        string cpuIMG;

        string ramName;
        string ramPrice;
        string ramIMG;

        string gpuName;
        string gpuPrice;
        string gpuIMG;

        string psuName;
        string psuPrice;
        string psuIMG;

        string ssdName;
        string ssdPrice;
        string ssdIMG;

        string caseName;
        string casePrice;
        string caseIMG;

        public intelComponents()
        {
            InitializeComponent();
            maticna.ItemsSource = new List<intelMotherboard>
            {
                new intelMotherboard{ime="GIGABYTE B460 D3H", opis="97€", slika="giga.jpg"},
                new intelMotherboard{ime="ASUS ROG Strix B460-F Gaming", opis="174€", slika="asusrog.jpg"},
                new intelMotherboard{ime="ASUS ROG MAXIMUS XIII HERO", opis="513€", slika="asushero.jpg"}



            };
            cpu.ItemsSource = new List<intelCPU>
            {
                new intelCPU{ime="Intel Core i9-11900K", opis="483€", slika="inteli9.jpg"},
                new intelCPU{ime="Intel Core i7-11700", opis="302€", slika="inteli7.jpg"},
                new intelCPU{ime="Intel Core i5-11500", opis="225€", slika="inteli5.jpg"}



            };
            ram.ItemsSource = new List<RAM>
            {
                new RAM{ime="G.SKILL Trident Z Neo, 2x8GB",opis="125€",slika="G.SKILLTridentZNeo.jpg"},
                new RAM{ime="CORSAIR Dominator Platinum RGB, 2x8GB",opis="100€",slika="CORSAIRDominatorPlatinumRGB.jpg"},
                new RAM{ime="G.SKILL Trident Z Royal, 2x16GB",opis="300€",slika="G.SKILLTridentZRoyal.jpg"}
            };
            gpu.ItemsSource = new List<GPU>
            {
                new GPU{ime="NVIDIA GeForce RTX 3090 24GB",opis="1230€",slika="rtx3080.jfif"},
                new GPU{ime="NVIDIA GeForce RTX 3060 Ti 8GB",opis="328€",slika="rtx3060.jpg"},
                new GPU{ime="NVIDIA GeForce RTX 2070 8GB",opis="940€",slika="rtx2070.jpg"}
            };
            psu.ItemsSource = new List<PSU>
            {
                new PSU{ime="SILVERSTONE Strider Platinum 1200W",opis="230€",slika="silverstone1200W.jpg"},
                new PSU{ime="SILVERSTONE Strider Essential 700W",opis="94€",slika="silverstone700W.jpg"},
                new PSU{ime="CORSAIR CX550F RGB 550W",opis="85€",slika="corsair500W.jpg"}
            };
            ssd.ItemsSource = new List<SSD>
            {
                new SSD{ime="KINGSTON NV1 500 GB",opis="60€",slika="kingston500.jpg"},
                new SSD{ime="CORSAIR Force MP400 1000 GB",opis="140€",slika="corsair1000.jpg"},
                new SSD{ime="LC POWER Phenom Pro Series 2000 GB",opis="303€",slika="lc2000.jpg"}
            };
            cases.ItemsSource = new List<CASE>
            {
                new CASE{ime="LC POWER LC-709B-ON",opis="70€",slika="lcpower.jpg"},
                new CASE{ime="CORSAIR iCUE 220T",opis="108€",slika="corsairicue.png"},
                new CASE{ime="LIAN LI 011 Dynamic",opis="145€",slika="lian.jpg"}
            };


        }

        private async void RAZER_Clicked(object sender, EventArgs e)
        {


            moboName = "GIGABYTE B460 D3H";
            moboPrice = "97€";
            moboIMG = "giga.jpg";

            check = 2;




        }

        private async void ASUS_Clicked(object sender, EventArgs e)
        {


            moboName = "ASUS ROG Strix B460-F Gaming";
            moboPrice = "174€";
            moboIMG = "asusrog.jpg";

            check = 2;





        }

        private async void MSI_Clicked(object sender, EventArgs e)
        {


            moboName = "ASUS ROG MAXIMUS XIII HERO";
            moboPrice = "513€";
            moboIMG = "asushero.jpg";

            check = 2;




        }

        private async void amd53600_Clicked(object sender, EventArgs e)
        {


            cpuName = "Intel Core i9-11900K";
            cpuPrice = "483€";
            cpuIMG = "inteli9.jpg";

            check = 1;




        }

        private async void amd55600X_Clicked(object sender, EventArgs e)
        {

            cpuName = "Intel Core i7-11700";
            cpuPrice = "302€";
            cpuIMG = "inteli7.jpg";

            check = 1;





        }

        private async void amd95950X_Clicked(object sender, EventArgs e)
        {


            cpuName = "Intel Core i5-11500";
            cpuPrice = "225€";
            cpuIMG = "inteli5.jpgg";

            check = 1;




        }

        private async void neo_Clicked(object sender, EventArgs e)
        {
            ramName = "G.SKILL Trident Z Neo, 2x8GB";
            ramPrice = "125€";
            ramIMG = "G.SKILLTridentZNeo.jpg";

            check = 3;



        }

        private async void corsair_Clicked(object sender, EventArgs e)
        {
            ramName = "CORSAIR Dominator Platinum RGB, 2x8GB";
            ramPrice = "100€";
            ramIMG = "CORSAIRDominatorPlatinumRGB.jpg";

            check = 3;


        }

        private async void royal_Clicked(object sender, EventArgs e)
        {
            ramName = "G.SKILL Trident Z Royal, 2x16GB";
            ramPrice = "300€";
            ramIMG = "G.SKILLTridentZRoyal.jpg";

            check = 3;


        }

        private async void rtx3080_Clicked(object sender, EventArgs e)
        {
            gpuName = "NVIDIA GeForce RTX 3090 24GB";
            gpuPrice = "1230€";
            gpuIMG = "rtx3080.jfif";

            check = 4;

        }

        private async void rtx3060_Clicked(object sender, EventArgs e)
        {
            gpuName = "NVIDIA GeForce RTX 3060 Ti 8GB";
            gpuPrice = "328€";
            gpuIMG = "rtx3060.jpg";

            check = 4;

        }

        private async void rtx2070_Clicked(object sender, EventArgs e)
        {
            gpuName = "NVIDIA GeForce RTX 2070 8GB";
            gpuPrice = "940€";
            gpuIMG = "rtx2070.jpg";

            check = 4;

        }

        private async void silver1200_Clicked(object sender, EventArgs e)
        {
            psuName = "SILVERSTONE Strider Platinum 1200W";
            psuPrice = "230€";
            psuIMG = "silverstone1200W.jpg";

            check = 5;

        }

        private async void silver700_Clicked(object sender, EventArgs e)
        {
            psuName = "SILVERSTONE Strider Essential 700W";
            psuPrice = "94€";
            psuIMG = "silverstone700W.jpg";

            check = 5;

        }

        private async void corsair500_Clicked(object sender, EventArgs e)
        {
            psuName = "CORSAIR CX550F RGB 550W";
            psuPrice = "85€";
            psuIMG = "corsair500W.jpg";

            check = 5;

        }

        private async void king500_Clicked(object sender, EventArgs e)
        {
            ssdName = "KINGSTON NV1 500 GB";
            ssdPrice = "60€";
            ssdIMG = "kingston500.jpg";

            check = 6;

        }

        private async void corsair1000_Clicked(object sender, EventArgs e)
        {
            ssdName = "CORSAIR Force MP400 1000 GB";
            ssdPrice = "140€";
            ssdIMG = "corsair1000.jpg";

            check = 6;

        }

        private async void lc2000_Clicked(object sender, EventArgs e)
        {
            ssdName = "LC POWER Phenom Pro Series 2000 GB";
            ssdPrice = "303€";
            ssdIMG = "lc2000.jpg";

            check = 6;

        }

        private async void lcpower_Clicked(object sender, EventArgs e)
        {
            caseName = "LC POWER LC-709B-ON";
            casePrice = "70€";
            caseIMG = "lcpower.jpg";

            check = 7;
            if (check == 7)
            {
                await Navigation.PushAsync(new amdFlyout(cpuName, cpuPrice, cpuIMG, moboName, moboPrice, moboIMG, ramName, ramPrice, ramIMG, gpuName, gpuPrice, gpuIMG, psuName, psuPrice, psuIMG, ssdName, ssdPrice, ssdIMG, caseName, casePrice, caseIMG));
            }

        }

        private async void corsaircue_Clicked(object sender, EventArgs e)
        {
            caseName = "CORSAIR iCUE 220T";
            casePrice = "108€";
            caseIMG = "corsairicue.png";

            check = 7;
            if (check == 7)
            {
                await Navigation.PushAsync(new amdFlyout(cpuName, cpuPrice, cpuIMG, moboName, moboPrice, moboIMG, ramName, ramPrice, ramIMG, gpuName, gpuPrice, gpuIMG, psuName, psuPrice, psuIMG, ssdName, ssdPrice, ssdIMG, caseName, casePrice, caseIMG));

            }

        }

        private async void lian_Clicked(object sender, EventArgs e)
        {
            caseName = "LIAN LI 011 Dynamic";
            casePrice = "145€";
            caseIMG = "lian.jpg";

            check = 7;
            if (check == 7)
            {
                await Navigation.PushAsync(new amdFlyout(cpuName, cpuPrice, cpuIMG, moboName, moboPrice, moboIMG, ramName, ramPrice, ramIMG, gpuName, gpuPrice, gpuIMG, psuName, psuPrice, psuIMG, ssdName, ssdPrice, ssdIMG, caseName, casePrice, caseIMG));

            }

        }
    }
}