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
    public partial class Ajout_d_un_Produit : Form
    {

        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;
        public Ajout_d_un_Produit()
        {
            InitializeComponent();
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDStockDataSet);

        }

        private void Ajout_d_un_Produit_Load(object sender, EventArgs e)
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
            cmbFourn.DataSource = dset.Tables[0];
            cmbFourn.DisplayMember = "NomPrenom";
            cmbFourn.ValueMember = "CodeFourn";
            //this.tableTableAdapter.Fill(this.bDStockDataSet.Table);

        }

        private void codeFournLabel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment ajouter ce produit ?","Ajout d'un Produit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmd.CommandText = "insert into Produit values (" +
                    txtCode.Text + "," + cmbFourn.SelectedValue.ToString() + ",'" +
                    txtNom.Text + "'," + txtPrix.Text + "," + txtQt.Text + ")";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insertion effectuée avec succes", "Insertion");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
