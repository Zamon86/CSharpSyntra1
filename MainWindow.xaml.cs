using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnVariabelen_Click(object sender, RoutedEventArgs e)
        {
            ucVariabelen _ucVariabelen = new ucVariabelen();
            OpenMyUserControl(_ucVariabelen);

        }

        private void btnSomVanDrieGetallen_Click(object sender, RoutedEventArgs e)
        {
            ucSomVanDrieGetallen _ucSomVanDrieGetallen = new ucSomVanDrieGetallen();
            OpenMyUserControl(_ucSomVanDrieGetallen);
        }

        private void btnFactuur_Click(object sender, RoutedEventArgs e)
        {
            ucFactuur _ucFactur = new ucFactuur();
            OpenMyUserControl(_ucFactur);
        }

        private void btnOndernemingMetEigenVermogen_Click(object sender, RoutedEventArgs e)
        {
            ucOndernemingMetEigenVermogen _ucOndernemingMetEigenVermogen = new ucOndernemingMetEigenVermogen();
            OpenMyUserControl(_ucOndernemingMetEigenVermogen);
        }

        private void btnOmwentelingWiel_Click(object sender, RoutedEventArgs e)
        {
            ucOmwentelingWiel _ucOmwentelingWiel = new ucOmwentelingWiel();
            OpenMyUserControl(_ucOmwentelingWiel);
        }

        private void btnAantalOmwentelingen_Click(object sender, RoutedEventArgs e)
        {
            ucAantalOmwentelingen _ucAantalOmwentelingen = new ucAantalOmwentelingen();
            OpenMyUserControl(_ucAantalOmwentelingen);
        }

        private void btnCurrencyConverter_Click(object sender, RoutedEventArgs e)
        {
            ucCurrencyConverter _ucCurrencyConverter = new ucCurrencyConverter();
            OpenMyUserControl(_ucCurrencyConverter);
        }

        private void btnCelsius_Fahrenheid_Click(object sender, RoutedEventArgs e)
        {
            ucCelsius_Fahrenheid _ucCelsius_Fahrenheid = new ucCelsius_Fahrenheid();
            OpenMyUserControl(_ucCelsius_Fahrenheid);
        }

        private void btnHandelaarPeeters_Click(object sender, RoutedEventArgs e)
        {
            ucHandelaarPeeters _ucHandelaarPeeters = new ucHandelaarPeeters();
            OpenMyUserControl(_ucHandelaarPeeters);
        }

        private void btnWatKostMijnAugo_Click(object sender, RoutedEventArgs e)
        {
            ucWatKostMijnAuto _ucWatKostMijnAugo = new ucWatKostMijnAuto();
            OpenMyUserControl(_ucWatKostMijnAugo);
        }

        private void btnGemiddelde_Click(object sender, RoutedEventArgs e)
        {
            ucGemiddelde _ucGemiddelde = new ucGemiddelde();
            OpenMyUserControl(_ucGemiddelde);
        }

        private void btnSaldo_Click(object sender, RoutedEventArgs e)
        {
            ucSaldo _ucSaldo = new ucSaldo();
            OpenMyUserControl(_ucSaldo);
        }

        private void btnHetGrootsteGetal_Click(object sender, RoutedEventArgs e)
        {
            ucHetGrootsteGetal _ucHetGrootsteGetal = new ucHetGrootsteGetal();
            OpenMyUserControl(_ucHetGrootsteGetal);
        }

        private void btnVerzekeringsPolis_Click(object sender, RoutedEventArgs e)
        {
            ucVerzekeringsPolis _ucVerzekeringsPolis = new ucVerzekeringsPolis();
            OpenMyUserControl(_ucVerzekeringsPolis);
        }

        private void btnIngelezenEenheidsPrijs_Click(object sender, RoutedEventArgs e)
        {
            ucIngelezenEenheidsPrijs _ucIngelezenEenheidsPrijs = new ucIngelezenEenheidsPrijs();
            OpenMyUserControl(_ucIngelezenEenheidsPrijs);
        }

        private void btnGetallenZijnGelijk_Click(object sender, RoutedEventArgs e)
        {
            ucGetallenZijnGelijk _ucGetallenZijnGelijk = new ucGetallenZijnGelijk();
            OpenMyUserControl(_ucGetallenZijnGelijk);
        }

        private void btnDrieGetallenVergelijken_Click(object sender, RoutedEventArgs e)
        {
            ucDrieGetallenVergelijken _ucDrieGetallenVergelijken = new ucDrieGetallenVergelijken();
            OpenMyUserControl(_ucDrieGetallenVergelijken);
        }

        private void btnEenWillekeurigGetalvergelijken_Click(object sender, RoutedEventArgs e)
        {
            ucEenWillekeurigGetalvergelijken _ucEENWillekeurigGetalvergelijken = new ucEenWillekeurigGetalvergelijken();
            OpenMyUserControl(_ucEENWillekeurigGetalvergelijken);
        }

        private void btnHetKleinsteGetal_Click(object sender, RoutedEventArgs e)
        {
            ucHetKleinsteGetal _ucHetKleinsteGetal = new ucHetKleinsteGetal();
            OpenMyUserControl(_ucHetKleinsteGetal);
        }

        private void btnHetVerschil_Click(object sender, RoutedEventArgs e)
        {
            ucHetVerschil _ucHetVerschil = new ucHetVerschil();
            OpenMyUserControl(_ucHetVerschil);
        }

        private void btnControleRekeningNummer_Click(object sender, RoutedEventArgs e)
        {
            ucControleRekeningNummer _ucControleRekeningNummer = new ucControleRekeningNummer();
            OpenMyUserControl(_ucControleRekeningNummer);
        }

        private void btnWinkelKorting_Click(object sender, RoutedEventArgs e)
        {
            ucWinkelKorting _ucWinkelKorting = new ucWinkelKorting();
            OpenMyUserControl(_ucWinkelKorting);
        }

        private void btnOpeningBenzineStation_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnOpeningBenzineStation2_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnBloemenWinkel_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn10Getallen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn10GetallenOmgekeerd_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btn10KeerDeVoornaam_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnGeef10Evengetallen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnGemiddeldeVerbruik_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnVreemdeMuntenOmrekenen_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnAantalArtikelen_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnBiljartClub_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnIntrestOp15Jaar_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnPrognoseVerkoop_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnTweeNatuurlijkeGetallen_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSomVan5de10de15de_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void btnExtraGrootsteKleinste_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnFillingAnArray_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnVoidMethodes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnFuncionMethodes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnSpecialMethode_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void OpenMyUserControl(UserControl myUC)
        {
            if (grdMain.Children.Count > 1)
            {
                grdMain.Children.RemoveAt(1);
            }

            Grid.SetColumn(myUC, 1);
            Grid.SetRow(myUC, 0);
            grdMain.Children.Add(myUC);


        }
    }
}