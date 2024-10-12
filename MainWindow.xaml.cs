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
            ucOpeningBenzineStation ucOpeningBenzineStation = new ucOpeningBenzineStation();
            OpenMyUserControl(ucOpeningBenzineStation);
        }

        private void btnOpeningBenzineStation2_Click(object sender, RoutedEventArgs e)
        {
            ucOpeningBenzineStation2 ucOpeningBenzineStation2 = new ucOpeningBenzineStation2();
            OpenMyUserControl(ucOpeningBenzineStation2);
        }

        private void btnBloemenWinkel_Click(object sender, RoutedEventArgs e)
        {
            ucBleomenzaak ucBleomenzaak = new ucBleomenzaak();
            OpenMyUserControl(ucBleomenzaak);
        }

        private void btn10Getallen_Click(object sender, RoutedEventArgs e)
        {
            uc10Getallen uc10Getallen = new uc10Getallen();
            OpenMyUserControl(uc10Getallen);
        }

        private void btn10GetallenOmgekeerd_Click(object sender, RoutedEventArgs e)
        {
            uc10GetallenOmgekeerd uc10GetallenOmgekeerd = new uc10GetallenOmgekeerd();
            OpenMyUserControl(uc10GetallenOmgekeerd);
        }

        private void btn10KeerDeVoornaam_Click(object sender, RoutedEventArgs e)
        {
            uc10Voornaam uc10Voornaam = new uc10Voornaam();
            OpenMyUserControl(uc10Voornaam);
        }

        private void btnGeef10Evengetallen_Click(object sender, RoutedEventArgs e)
        {
            uc10EvenGetallen uc10EvenGetallen = new uc10EvenGetallen();
            OpenMyUserControl(uc10EvenGetallen);
        }

        private void btnGemiddeldeVerbruik_Click(object sender, RoutedEventArgs e)
        {
            ucGemiddeldeVerbruik ucGemiddeldeVerbruik = new ucGemiddeldeVerbruik();
            OpenMyUserControl(ucGemiddeldeVerbruik);            
        }

        private void btnVreemdeMuntenOmrekenen_Click(object sender, RoutedEventArgs e)
        {
            ucVreemdeMuntenOmzetten ucVreemdeMuntenOmzetten = new ucVreemdeMuntenOmzetten();
            OpenMyUserControl(ucVreemdeMuntenOmzetten);
        }

        private void btnAantalArtikelen_Click(object sender, RoutedEventArgs e)
        {
            ucAantalArtikelen ucAantalArtikelen = new ucAantalArtikelen();
            OpenMyUserControl(ucAantalArtikelen);
        }

        private void btnBiljartClub_Click(object sender, RoutedEventArgs e)
        {
            ucBiljartClub ucBiljartClub = new ucBiljartClub();
            OpenMyUserControl(ucBiljartClub);
        }

        private void btnIntrestOp15Jaar_Click(object sender, RoutedEventArgs e)
        {
           ucIntrestOp15jaar ucInterestOp15jaar = new ucIntrestOp15jaar();
            OpenMyUserControl(ucInterestOp15jaar);
        }

        private void btnPrognoseVerkoop_Click(object sender, RoutedEventArgs e)
        {
            ucPrognoseVerkoop ucPrognoseVerkoop = new ucPrognoseVerkoop();
            OpenMyUserControl(ucPrognoseVerkoop);
        }

        private void btnTweeNatuurlijkeGetallen_Click(object sender, RoutedEventArgs e)
        {
            ucTweeNatuurlijkeGetallen ucTweeNatuurlijkeGetallen = new ucTweeNatuurlijkeGetallen();
            OpenMyUserControl(ucTweeNatuurlijkeGetallen);
        }

        private void btnSomVan5de10de15de_Click(object sender, RoutedEventArgs e)
        {
            ucSomVan5de10de15de ucSomVan5de10de15de = new ucSomVan5de10de15de();
            OpenMyUserControl(ucSomVan5de10de15de);
        }

        private void btnExtraGrootsteKleinste_Click(object sender, RoutedEventArgs e)
        {
            ucExtra_Grootste ucExtra_Grootste = new ucExtra_Grootste();
            OpenMyUserControl(ucExtra_Grootste);
        }

        private void btnFillingAnArray_Click(object sender, RoutedEventArgs e)
        {
            ucFillArray ucFillArray = new ucFillArray();
            OpenMyUserControl(ucFillArray);
        }

        private void btnVoidMethodes_Click(object sender, RoutedEventArgs e)
        {
            ucVoid ucVoid = new ucVoid();
            OpenMyUserControl(ucVoid);
        }

        private void btnFuncionMethodes_Click(object sender, RoutedEventArgs e)
        {
            ucFunction ucFunction = new ucFunction();
            OpenMyUserControl(ucFunction);
        }

        private void btnSpecialMethode_Click(object sender, RoutedEventArgs e)
        {
            ucSpecialMethods ucSpecialMethods = new ucSpecialMethods();
            OpenMyUserControl(ucSpecialMethods);
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