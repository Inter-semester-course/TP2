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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
            errorMessage.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connexion form = new Connexion();
            form.Show();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxConfirmation.Text)
            {
                errorMessage.Text = "Invalide";
                errorMessage.ForeColor = Color.Red;
            }
            else
            {
                errorMessage.Text = "OK";
                errorMessage.ForeColor = Color.Green;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(nom.Text)) &&
                !(String.IsNullOrEmpty(prenom.Text)) &&
                !(String.IsNullOrEmpty(mail.Text)) &&
                !(String.IsNullOrEmpty(textBoxPassword.Text)) &&
                !(String.IsNullOrEmpty(textBoxConfirmation.Text)))
            {
                MessageBox.Show("Votre Compte a bien ete Cree!");
            }
            else
            {
                MessageBox.Show("Vous devez tous remplir et Verifier votre mot de passe!");
            }
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!(String.IsNullOrEmpty(nom.Text)) &&
                    !(String.IsNullOrEmpty(prenom.Text)) &&
                    !(String.IsNullOrEmpty(mail.Text)) &&
                    !(String.IsNullOrEmpty(textBoxPassword.Text)) &&
                    !(String.IsNullOrEmpty(textBoxConfirmation.Text)))
                {
                    MessageBox.Show("Votre Compte a bien ete Cree!");
                }
                else
                {
                    MessageBox.Show("Vous devez tous remplir et Verifier votre mot de passe!");
                }
            }
        }
    }
    }
