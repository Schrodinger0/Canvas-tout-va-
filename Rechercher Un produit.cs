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
    public partial class Rechercher_Un_produit : Form
    {

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        DataSet dset2;

        public Rechercher_Un_produit()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rechercher_Un_produit_Load(object sender, EventArgs e)
        {
            cnx = new SqlConnection();
            cnx.ConnectionString = "Data Source=DESKTOP-B830T1F\\SQLEXPRESS;Initial Catalog=BDStock;Integrated Security=True";
            cnx.Open();
            cmd = new SqlCommand();
            cmd.CommandText = "select * from Fournisseur";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset = new DataSet();
            adap.Fill(dset, "Fournisseur");
            dataGridView1.DataSource = dset.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and NomProduit like('" + textBox1.Text + "%')";
                cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset2 = new DataSet();
                adap.Fill(dset2, "Produit");
                dataGridView1.DataSource = dset2.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand();
                cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn and CodeProduit like(" + textBox1.Text + ")";
                cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset2 = new DataSet();
                adap.Fill(dset2, "Produit");
                dataGridView1.DataSource = dset2.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
