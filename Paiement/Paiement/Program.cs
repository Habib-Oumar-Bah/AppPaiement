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

    }
}