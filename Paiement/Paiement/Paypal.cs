using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paiement
{
    internal class Paypal : Paiement
    {

        public string Courriel { get; set; }


        public Paypal(string email, double montant, string description) : base(montant, description)
        {
            Courriel = email;
        }

        public virtual void AfficheDetails()
        {
            Console.WriteLine($"le montant est {Montant}, la description est {Description} et son email est {Courriel}.");
        }
    }
}