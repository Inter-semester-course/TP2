using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Client
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string motDePasse { get; set; }
        public string genre { get; set; }

        public Client(string nom, string prenom, string email, string motDePasse, string genre)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.motDePasse = motDePasse;
            this.genre = genre;
        }

     }
}
