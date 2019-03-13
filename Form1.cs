using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

 

        private void listeDesClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void ajouterUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void ajouterUnFournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AjouterFournisseuer ajouterFournisseuer = new AjouterFournisseuer();
            ajouterFournisseuer.Show();
            this.Hide();
        }

        private void listeDesFournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeFournisseur lf = new ListeFournisseur();
            lf.Show();
            this.Hide();
        }

        private void ajouterUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajout_d_un_Produit ap = new Ajout_d_un_Produit();
            ap.Show();
            this.Hide();
        }

        private void listeDesProduitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Liste_des_Produits lp = new Liste_des_Produits();
            lp.Show();
            this.Hide();
        }

        private void rechercherUnProduitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rechercher_Un_produit rp = new Rechercher_Un_produit();
            rp.Show();
            this.Hide();
        }
    }
}
