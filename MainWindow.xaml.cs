using System.Windows;
using System.Windows.Controls;

namespace LogikaOefening
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MessageBox.Show(Math.Tan(15).ToString());
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

        private void btnOnderneming_EigenVermogen_Click(object sender, RoutedEventArgs e)
        {
            ucOnderneming_EigenVermogen _ucOnderneming_EigenVermogen = new ucOnderneming_EigenVermogen();
            OpenMyUserControl(_ucOnderneming_EigenVermogen);
        }

        private void btnWielOmwentelingen_Click(object sender, RoutedEventArgs e)
        {
            ucWielOmwentelingen _ucWielOmwentelingen = new ucWielOmwentelingen();
            OpenMyUserControl(_ucWielOmwentelingen);
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
            ucTweeGetallenGelijk _ucTweeGetallenGelijk = new ucTweeGetallenGelijk();
            OpenMyUserControl(_ucTweeGetallenGelijk);
        }

        private void btnDrieGetallen_Click(object sender, RoutedEventArgs e)
        {
            ucDrieGetallen _ucDrieGetallen = new ucDrieGetallen();
            OpenMyUserControl(_ucDrieGetallen);
        }

        private void btnEenWillekeurigGetalvergelijken_Click(object sender, RoutedEventArgs e)
        {
            ucVergelijkWillekeurigGetal _ucVergelijkWillekeurigGetal = new ucVergelijkWillekeurigGetal();
            OpenMyUserControl(_ucVergelijkWillekeurigGetal);
        }

        private void btnHetKleinsteGetal_Click(object sender, RoutedEventArgs e)
        {
            ucHetKleinsteGetal _ucHetKleinsteGetal = new ucHetKleinsteGetal();
            OpenMyUserControl(_ucHetKleinsteGetal);
        }

        private void btnHetVerschil_Click(object sender, RoutedEventArgs e)
        {
            ucBerekenHetVerschil _ucBerekenHetVerschil = new ucBerekenHetVerschil();
            OpenMyUserControl(_ucBerekenHetVerschil);
        }

        private void btnControleRekeningNummer_Click(object sender, RoutedEventArgs e)
        {
            ucControleRekeningNummer _ucControleRekeningNummer = new ucControleRekeningNummer();
            OpenMyUserControl(_ucControleRekeningNummer);
        }

        private void btnWinkelKorting_Click(object sender, RoutedEventArgs e)
        {
            ucKledingWinkel _ucKledingWinkel = new ucKledingWinkel();
            OpenMyUserControl(_ucKledingWinkel);
        }

        private void btnOpeningBenzineStation_Click(object sender, RoutedEventArgs e)
        {
            ucOpeningBenzineStation _ucOpeningBenzineStation = new ucOpeningBenzineStation();
            OpenMyUserControl(_ucOpeningBenzineStation);
        }

        private void btnOpeningBenzineStation2_Click(object sender, RoutedEventArgs e)
        {
            ucOpeningBenzineStation2 _ucOpeningBenzineStation2 = new ucOpeningBenzineStation2();
            OpenMyUserControl(_ucOpeningBenzineStation2);
        }

        private void btnBloemenWinkel_Click(object sender, RoutedEventArgs e)
        {
            ucBleomenzaak _ucBleomenzaak = new ucBleomenzaak();
            OpenMyUserControl(_ucBleomenzaak);
        }

        private void btn10Getallen_Click(object sender, RoutedEventArgs e)
        {
            uc10Getallen _uc10Getallen = new uc10Getallen();
            OpenMyUserControl(_uc10Getallen);
        }

        private void btn10GetallenOmgekeerd_Click(object sender, RoutedEventArgs e)
        {
            uc10GetallenOmgekeerd _uc10GetallenOmgekeerd = new uc10GetallenOmgekeerd();
            OpenMyUserControl(_uc10GetallenOmgekeerd);
        }

        private void btn10KeerDeVoornaam_Click(object sender, RoutedEventArgs e)
        {
            uc10Voornaam _uc10Voornaam = new uc10Voornaam();
            OpenMyUserControl(_uc10Voornaam);
        }

        private void btnGeef10Evengetallen_Click(object sender, RoutedEventArgs e)
        {
            uc10EvenGetallen _uc10EvenGetallen = new uc10EvenGetallen();
            OpenMyUserControl(_uc10EvenGetallen);
        }

        private void btnGemiddeldeVerbruik_Click(object sender, RoutedEventArgs e)
        {
            ucGemiddeldeVerbruik _ucGemiddeldeVerbruik = new ucGemiddeldeVerbruik();
            OpenMyUserControl(_ucGemiddeldeVerbruik);            
        }

        private void btnVreemdeMuntenOmrekenen_Click(object sender, RoutedEventArgs e)
        {
            ucVreemdeMuntenOmzetten _ucVreemdeMuntenOmzetten = new ucVreemdeMuntenOmzetten();
            OpenMyUserControl(_ucVreemdeMuntenOmzetten);
        }

        private void btnAantalArtikelen_Click(object sender, RoutedEventArgs e)
        {
            ucAantalArtikelen _ucAantalArtikelen = new ucAantalArtikelen();
            OpenMyUserControl(_ucAantalArtikelen);
        }

        private void btnBiljartClub_Click(object sender, RoutedEventArgs e)
        {
            ucBiljartClub _ucBiljartClub = new ucBiljartClub();
            OpenMyUserControl(_ucBiljartClub);
        }

        private void btnIntrestOp15Jaar_Click(object sender, RoutedEventArgs e)
        {
           ucIntrestOp15jaar _ucInterestOp15jaar = new ucIntrestOp15jaar();
            OpenMyUserControl(_ucInterestOp15jaar);
        }

        private void btnPrognoseVerkoop_Click(object sender, RoutedEventArgs e)
        {
            ucPrognoseVerkoop _ucPrognoseVerkoop = new ucPrognoseVerkoop();
            OpenMyUserControl(_ucPrognoseVerkoop);
        }

        private void btnTweeNatuurlijkeGetallen_Click(object sender, RoutedEventArgs e)
        {
            ucTweeNatuurlijkeGetallen _ucTweeNatuurlijkeGetallen = new ucTweeNatuurlijkeGetallen();
            OpenMyUserControl(_ucTweeNatuurlijkeGetallen);
        }

        private void btnSomVan5de10de15de_Click(object sender, RoutedEventArgs e)
        {
            ucSomVan5de10de15de _ucSomVan5de10de15de = new ucSomVan5de10de15de();
            OpenMyUserControl(_ucSomVan5de10de15de);
        }

        private void btnExtraGrootsteKleinste_Click(object sender, RoutedEventArgs e)
        {
            ucExtra_Grootste _ucExtra_Grootste = new ucExtra_Grootste();
            OpenMyUserControl(_ucExtra_Grootste);
        }

        private void btnFillingAnArray_Click(object sender, RoutedEventArgs e)
        {
            ucFillArray _ucFillArray = new ucFillArray();
            OpenMyUserControl(_ucFillArray);
        }

        private void btnVoidMethodes_Click(object sender, RoutedEventArgs e)
        {
            ucVoid _ucVoid = new ucVoid();
            OpenMyUserControl(_ucVoid);
        }

        private void btnFuncionMethodes_Click(object sender, RoutedEventArgs e)
        {
            ucFunction _ucFunction = new ucFunction();
            OpenMyUserControl(_ucFunction);
        }

        private void btnSpecialMethode_Click(object sender, RoutedEventArgs e)
        {
            ucSpecialMethods _ucSpecialMethods = new ucSpecialMethods();
            OpenMyUserControl(_ucSpecialMethods);
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