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
    public partial class Ajouter_une_facture : Form
    {

        SqlConnection cnx;
        SqlCommand cmd, cmd2, cmd3;
        SqlDataAdapter adap, adap2, adap3;
        SqlDataReader dread;
        DataSet dset, dset2, dset3;
        SqlCommandBuilder cb;
        DataRow dtr;

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment ajouter cette facture? ", "Ajout d'une Facture", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {

                    long codeFacture;
                    //insertion de la facture dans la table facture
                    cmd.CommandText = "insert into Facture(CodeClient,DateFacture) values(" + cmbClient.SelectedValue.ToString() + ", '" + dateTimePicker1.Value.Date.ToString() + "')";
                    cmd.ExecuteNonQuery();
                    //Afficher la deuxième partie de facture
                    this.Height = 640;
                    grbligne.Visible = true;
                    //recupérer le code de la facture
                    cmd.CommandText = "select max(codeFacture) from Facture;";
                    codeFacture = (long)cmd.ExecuteScalar();
                    //créer le dataset pour les lignes de la facture
                    cmd2 = new SqlCommand();
                    cmd2.CommandText = "select * from LigneFacture where codeFacture = " + codeFacture.ToString();
                    cmd2.Connection = cnx;


                    float t = 0;
                    adap2 = new SqlDataAdapter(cmd2);
                    dset2 = new DataSet();
                    //recupérer les clés de la table
                    adap2.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                    adap2.Fill(dset2, "LigneFacture");
                    dataGridView1.DataSource = dset2.Tables[0];
                    btnAjoutFact.Enabled = false;
                    btnQ1.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void cmbProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd.CommandText = "select CodeProduit, PrixUnitaire,QtEnStock from Produit where CodeProduit = " + cmbProd.SelectedValue.ToString();
            cmd.Connection = cnx;
            dread = cmd.ExecuteReader();
            dread.Read();
            txtprix.Text = dread[1].ToString();
            txtQt.Text = dread[2].ToString();
            qt = (int)dread[2];
            dread.Close();
        }

        private void txtQt_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(txtQt.Text) > qt)
            {
                MessageBox.Show("qantité en stock insuffisante pour la quantité demandé");
                txtQt.Text = qt.ToString();
                txtQt.Focus();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView1.CurrentRow.Index;
                long code =
                long.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                int qt =
                int.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                float p;
                cmd = cnx.CreateCommand();
                //création d'une requete avec parametres
                cmd.CommandText = "select PrixUnitaire from Produit where CodeProduit = @code";
                //definition d'un nouveau parametre
                cmd.Parameters.Add("@code", SqlDbType.BigInt);
                //préparer la requete pour le serveur
                cmd.Prepare();
                cmd.Parameters["@code"].Value = code;
                p = float.Parse(cmd.ExecuteScalar().ToString());
                t -= p * qt;
                txtTot.Text = (t - float.Parse(txtRet.Text)).ToString();
                dset2.Tables[0].Rows[i].Delete();
                dset2.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        int qt;

        private void button5_Click(object sender, EventArgs e)
        {
        }

        public Ajouter_une_facture()
        {
            InitializeComponent();
        }

        private void Ajouter_une_facture_Load(object sender, EventArgs e)
        {

            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=.\\sqlexpress;InitialCatalog = BDStock; Integrated Security = True";
cnx.Open();
            //commande pour charger la liste des clients
            cmd = new SqlCommand();
            cmd.CommandText = "select CodeClient, cast(Nom as varchar(20)) + ' ' + cast(prenom as varchar(20)) as NomPrenom from Client";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Client");
            cmbClient.DataSource = dset.Tables[0];
            cmbClient.DisplayMember = "NomPrenom";
            cmbClient.ValueMember = "CodeClient";
            //commande pour charger la liste des Produits
            cmd3 = new SqlCommand();
            cmd3.CommandText = "select CodeProduit, NomProduit ,QtEnStock from Produit where QtEnStock > 0; ";
            cmd3.Connection = cnx;
            adap3 = new SqlDataAdapter(cmd3);
            dset3 = new DataSet();
            adap3.Fill(dset3, "Produit");
            cmbProd.DataSource = dset3.Tables[0];
            cmbProd.DisplayMember = "NomProduit";
            cmbProd.ValueMember = "CodeProduit";
            cmbProd.SelectedIndex = -1;
            cmbClient.SelectedIndex = -1;
            // TODO: This line of code loads data into the 'bDStockDataSet.Facture' table. You can move, or remove it, as needed.
            //this.factureTableAdapter.Fill(this.bDStockDataSet.Facture);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
