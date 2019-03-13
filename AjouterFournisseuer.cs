using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP3
{
    public partial class AjouterFournisseuer : Form
    {

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        DataTable tab;
        DataRow dtr;
        int indice;

        public AjouterFournisseuer()
        {
           
            InitializeComponent();
        }

        private void fournisseurBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fournisseurBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDStockDataSet);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void AjouterFournisseuer_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            //connexion avec le serveurs de base de données
            cnx.ConnectionString = "Data Source=DESKTOP-B830T1F\\SQLEXPRESS;Initial Catalog=BDStock;Integrated Security=True";
            //Ouverture de la connexion
            cnx.Open();
            //commande de selection des données
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Fournisseur";
            cmd.Connection = cnx;
            //chargement des données dans une table
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fournisseur");
            tab = dset.Tables[0];
            //chargement des données dans l'interface
            indice = 0;
            textBox1.Text = (tab.Rows[0][0]).ToString();
            textBox2.Text = (tab.Rows[0][1]).ToString();
            textBox3.Text = (tab.Rows[0][2]).ToString();
            textBox4.Text = (tab.Rows[0][3]).ToString();
            textBox5.Text = (tab.Rows[0][4]).ToString();
            BtAjout.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            BtAjout.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            indice = 0;
            textBox1.Text = (tab.Rows[0][0]).ToString();
            textBox2.Text = (tab.Rows[0][1]).ToString();
            textBox3.Text = (tab.Rows[0][2]).ToString();
            textBox4.Text = (tab.Rows[0][3]).ToString();
            textBox5.Text = (tab.Rows[0][4]).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (indice > 0)
            {
                indice--;
                textBox1.Text = (tab.Rows[indice][0]).ToString();
                textBox2.Text = (tab.Rows[indice][1]).ToString();
                textBox3.Text = (tab.Rows[indice][2]).ToString();
                textBox4.Text = (tab.Rows[indice][3]).ToString();
                textBox5.Text = (tab.Rows[indice][4]).ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (indice < tab.Rows.Count - 1)
            {
                indice++;
                textBox1.Text = (tab.Rows[indice][0]).ToString();
                textBox2.Text = (tab.Rows[indice][1]).ToString();
                textBox3.Text = (tab.Rows[indice][2]).ToString();
                textBox4.Text = (tab.Rows[indice][3]).ToString();
                textBox5.Text = (tab.Rows[indice][4]).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            indice = tab.Rows.Count - 1;
            textBox1.Text = (tab.Rows[indice][0]).ToString();
            textBox2.Text = (tab.Rows[indice][1]).ToString();
            textBox3.Text = (tab.Rows[indice][2]).ToString();
            textBox4.Text = (tab.Rows[indice][3]).ToString();
            textBox5.Text = (tab.Rows[indice][4]).ToString();
        }

        private void BtAjout_Click(object sender, EventArgs e)
        {
            dtr = tab.NewRow();
            dtr[0] = textBox1.Text;
            dtr[1] = textBox2.Text;
            dtr[2] = textBox3.Text;
            dtr[3] = textBox4.Text;
            dtr[4] = textBox5.Text;
            dset.Tables[0].Rows.Add(dtr);
            tab = dset.Tables[0];
            indice = tab.Rows.Count - 1;
            MessageBox.Show("Fournisseur ajouté");
            BtAjout.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer ce fournisseur ? ", "Confirmer suppression", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    dset.Tables[0].Rows[indice].Delete();
                    dset.AcceptChanges();
                    indice--;
                    tab = dset.Tables[0];

                    if (indice < 0)
                        indice = 0;
                    if (tab.Rows.Count != 0)
                    {
                        textBox1.Text = (tab.Rows[indice][0]).ToString();
                        textBox2.Text = (tab.Rows[indice][1]).ToString();
                        textBox3.Text = (tab.Rows[indice][2]).ToString();
                        textBox4.Text = (tab.Rows[indice][3]).ToString();
                        textBox5.Text = (tab.Rows[indice][4]).ToString();
                    }
                    else
                    {
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                        textBox5.Text = "";
                    }
                    MessageBox.Show("Fournisseur Supprimé");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                dset.Tables[0].Rows[indice][0] = textBox1.Text;
                dset.Tables[0].Rows[indice][1] = textBox2.Text;
                dset.Tables[0].Rows[indice][2] = textBox3.Text;
                dset.Tables[0].Rows[indice][3] = textBox4.Text;
                dset.Tables[0].Rows[indice][4] = textBox5.Text;
                tab = dset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                cb = new SqlCommandBuilder(adap);
                adap.Update(dset, "Fournisseur");
                dset.Clear();
                adap.Fill(dset, "Fournisseur");
                tab = dset.Tables[0];
                MessageBox.Show("Données enregistrées dans la base");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void fournisseurBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
