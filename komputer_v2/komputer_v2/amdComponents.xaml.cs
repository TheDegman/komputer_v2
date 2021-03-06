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
    public partial class amdComponents : TabbedPage
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

        public amdComponents()
        {
            InitializeComponent();
            maticna.ItemsSource = new List<amdMotherboard>
            {

                new amdMotherboard{ime="ASRock B550 Taichi Razer Edition", opis="230€", slika="ASRockB550TaichiRazerEdition.jpg"},
                new amdMotherboard{ime="ASUS TUF B450M-Plus II Gaming", opis="65€", slika="ASUSTUFB450MPlusIIGaming.png"},
                new amdMotherboard{ime="MSI B450 TOMAHAWK MAX II", opis="98€", slika="B450TOMAHAWKMAXII.png"}


            };
            cpu.ItemsSource = new List<amdCPU>
            {
                new amdCPU{ime="AMD Ryzen™ 5 3600", opis="170€", slika="amd53600.jpg"},
                new amdCPU{ime="AMD Ryzen™ 5 5600X", opis="245€", slika="amd55600X.jpg"},
                 new amdCPU{ime="AMD Ryzen™ 9 5950X", opis="805€", slika="amd95950X.jpg"}

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
            
            
                moboName = "ASRock B550 Taichi Razer Edition";
                moboPrice = "230€";
                moboIMG = "ASRockB550TaichiRazerEdition.jpg";
                
                check=2;
           



        }

        private async void ASUS_Clicked(object sender, EventArgs e)
        {
            
            
                moboName = "ASUS TUF B450M-Plus II Gaming";
                moboPrice = "65€";
                moboIMG = "ASUSTUFB450MPlusIIGaming.png";
                
                check=2;
            




        }

        private async void MSI_Clicked(object sender, EventArgs e)
        {
            
            
                moboName = "MSI B450 TOMAHAWK MAX II";
                moboPrice = "98€";
                moboIMG = "B450TOMAHAWKMAXII.png";
                
                check=2;
            



        }

        private async void amd53600_Clicked(object sender, EventArgs e)
        {
           
            
                cpuName = "AMD Ryzen™ 5 3600";
                cpuPrice = "170€";
                cpuIMG = "amd53600.jpg";
                
                check=1;
            
           


        }

        private async void amd55600X_Clicked(object sender, EventArgs e)
        {
            
                cpuName = "AMD Ryzen™ 5 5600X";
                cpuPrice = "245€";
                cpuIMG = "amd55600X.jpg";
                
                check=1;
            
           



        }

        private async void amd95950X_Clicked(object sender, EventArgs e)
        {
           
            
                cpuName = "AMD Ryzen™ 9 5950X";
                cpuPrice = "805€";
                cpuIMG = "amd95950X.jpg";

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

            check =4;

        }

        private async void rtx3060_Clicked(object sender, EventArgs e)
        {
            gpuName = "NVIDIA GeForce RTX 3060 Ti 8GB";
            gpuPrice = "328€";
            gpuIMG = "rtx3060.jpg";

            check =4;

        }

        private async void rtx2070_Clicked(object sender, EventArgs e)
        {
            gpuName = "NVIDIA GeForce RTX 2070 8GB";
            gpuPrice = "940€";
            gpuIMG = "rtx2070.jpg";

            check =4;

        }

        private async void silver1200_Clicked(object sender, EventArgs e)
        {
            psuName = "SILVERSTONE Strider Platinum 1200W";
            psuPrice = "230€";
            psuIMG = "silverstone1200W.jpg";

            check =5;

        }

        private async void silver700_Clicked(object sender, EventArgs e)
        {
            psuName = "SILVERSTONE Strider Essential 700W";
            psuPrice = "94€";
            psuIMG = "silverstone700W.jpg";

            check =5;

        }

        private async void corsair500_Clicked(object sender, EventArgs e)
        {
            psuName = "CORSAIR CX550F RGB 550W";
            psuPrice = "85€";
            psuIMG = "corsair500W.jpg";

            check =5;

        }

        private async void king500_Clicked(object sender, EventArgs e)
        {
            ssdName = "KINGSTON NV1 500 GB";
            ssdPrice = "60€";
            ssdIMG = "kingston500.jpg";

            check =6;

        }

        private async void corsair1000_Clicked(object sender, EventArgs e)
        {
            ssdName = "CORSAIR Force MP400 1000 GB";
            ssdPrice = "140€";
            ssdIMG = "corsair1000.jpg";

            check =6;

        }

        private async void lc2000_Clicked(object sender, EventArgs e)
        {
            ssdName = "LC POWER Phenom Pro Series 2000 GB";
            ssdPrice = "303€";
            ssdIMG = "lc2000.jpg";

            check =6;

        }

        private async void lcpower_Clicked(object sender, EventArgs e)
        {
            caseName = "LC POWER LC-709B-ON";
            casePrice = "70€";
            caseIMG = "lcpower.jpg";

            check =7;
            if (check == 7)
            {
                await Navigation.PushAsync(new amdFlyout(cpuName, cpuPrice, cpuIMG, moboName, moboPrice, moboIMG, ramName, ramPrice, ramIMG, gpuName,gpuPrice,gpuIMG,psuName,psuPrice,psuIMG,ssdName,ssdPrice,ssdIMG,caseName, casePrice, caseIMG));
            }

        }

        private async void corsaircue_Clicked(object sender, EventArgs e)
        {
            caseName = "CORSAIR iCUE 220T";
            casePrice = "108€";
            caseIMG = "corsairicue.png";

            check =7;
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

            check =7;
            if (check == 7)
            {
                await Navigation.PushAsync(new amdFlyout(cpuName, cpuPrice, cpuIMG, moboName, moboPrice, moboIMG, ramName, ramPrice, ramIMG, gpuName, gpuPrice, gpuIMG, psuName, psuPrice, psuIMG, ssdName, ssdPrice, ssdIMG, caseName, casePrice, caseIMG));

            }

        }
    }
}