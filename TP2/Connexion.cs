using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailSaisi = email.Text.Trim().ToLower();
            string motDePasseSaisi = pass.Text;

            Client client = Program.MemoireClients
                           .GetClients()
                           .Find(c => c.email.ToLower() == emailSaisi && c.motDePasse == motDePasseSaisi);


            if (client != null)
            {
                MessageBox.Show($"réussie !\nBienvenue {client.prenom} {client.nom}");
            }
            else
            {
                MessageBox.Show("Connexion Echouee veuillez verifier votre mot de passe ou votre email!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inscription formInscription = new Inscription();
            formInscription.Show();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (email.Text.ToLower() == "admin" && pass.Text.ToLower() == "admin")
                {
                    MessageBox.Show("Connexion reussi!");
                }
                else
                {
                    MessageBox.Show("Connexion Echouee veuillez verifier votre mot de passe ou votre email!");
                }
            }
        }
    }
}
