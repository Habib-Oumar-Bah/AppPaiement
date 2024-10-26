using Paiement;

internal class Program
{
    private static void Main(string[] args)
    {
        CarteCredit carteCredit1 = new CarteCredit(52256, 10000, "virement");
        CarteCredit carteCredit2 = new CarteCredit(9466, 441, "Investisement");
        CarteCredit carteCredit3 = new CarteCredit(86313, 4550, "achat");


        List<CarteCredit> CarteCredits = new List<CarteCredit> { carteCredit1, carteCredit2, carteCredit3 };
        Console.WriteLine("les cartes de credits sont :");
        foreach (var CarteCredit in CarteCredits)
        {
            CarteCredit.AfficherDetails();
        }
        Paypal paypal1 = new Paypal("alhassane.diallo@gmail.com", 2500000, "Totalisé");
        Paypal paypal2 = new Paypal("mariam@gmail.com", 15000, "Completer");

        //Affichage des details de ces objets de la classe Paypal
        List<Paypal> paypals = new List<Paypal> { paypal1, paypal2 };
        Console.WriteLine("les comptes paypals sont :");
        foreach (var Paypal in paypals)
        {
            Paypal.AfficheDetails();
        }


    }

}