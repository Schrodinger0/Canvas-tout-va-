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
    public partial class Liste_des_Produits : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        DataSet dset2;

        public Liste_des_Produits()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimer ce produit ", "Supprimer un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmd.CommandText = "delete from Produit where CodeProduit=" +
                    dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("suppression effectuée avec succes", "Suppression");
                    cmd = new SqlCommand();
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as  'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F    where P.CodeFourn = F.CodeFourn";
                    cmd.Connection = cnx;
                    adap = new SqlDataAdapter(cmd);
                    dset2 = new DataSet();
                    adap.Fill(dset2, "Produit");
                    dataGridView1.DataSource = dset2.Tables[0];
                    cmbFourn.SelectedIndex = cmbFourn.Items.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void Liste_des_Produits_Load(object sender, EventArgs e)
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
            DataRow dr;
            dr = dset.Tables[0].NewRow();
            dr["NomPrenom"] = "Toute la liste";
            dset.Tables[0].Rows.Add(dr);
            cmbFourn.DataSource = dset.Tables[0];
            cmbFourn.DisplayMember = "NomPrenom";
            cmbFourn.ValueMember = "CodeFourn";
            cmd = new SqlCommand();
            cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";
            cmd.Connection = cnx;
            adap = new SqlDataAdapter(cmd);
            dset2 = new DataSet();
            adap.Fill(dset2, "Produit");
            dataGridView1.DataSource = dset2.Tables[0];
            cmbFourn.SelectedIndex = cmbFourn.Items.Count - 1;
        }

        private void cmbFourn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            {
                cmd = new SqlCommand();
                if (cmbFourn.SelectedIndex == cmbFourn.Items.Count - 1)
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire, QtEnStock from Produit P, Fournisseur F where P.CodeFourn = F.CodeFourn";
                else
                    cmd.CommandText = "select CodeProduit,NomProduit,NomPrenom as 'Fournisseur', PrixUnitaire,QtEnStock from Produit P, Fournisseur F where  P.CodeFourn = F.CodeFourn and P.CodeFourn = " + cmbFourn.SelectedValue;
                    cmd.Connection = cnx;
                adap = new SqlDataAdapter(cmd);
                dset2 = new DataSet();
                adap.Fill(dset2, "Produit");
                dataGridView1.DataSource = dset2.Tables[0];
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous enregistrer les modifications ? ", "Confirmer modification", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    cb = new SqlCommandBuilder(adap);
                    adap.Update(dset, "Produit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
