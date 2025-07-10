using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    internal class Memoire
    {
        List<Client>clients = new List<Client>();

        public void ajouterClient(Client client)
        {
            clients.Add(client);
        }

        public List<Client> GetClients()
        {
            return clients;
        }

        public bool EmailExiste(string mail)
        {
            return clients.Any(c => c.email == mail);
        }
    }
}
