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
    public partial class ListeFournisseur : Form
    {
        SqlConnection cnx;
        SqlCommand cmd;
        SqlDataAdapter adap;
        SqlCommandBuilder cb;
        DataSet dset;

        public ListeFournisseur()
        {
            InitializeComponent();
        }

        private void ListeFournisseur_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous vraiment supprimer ce fournisseur ? ", "Confirmer suppression", MessageBoxButtons.YesNo) ==  DialogResult.Yes)
                {
                    
            int i = dataGridView1.CurrentRow.Index;
            dset.Tables[0].Rows[i].Delete();
            cb = new SqlCommandBuilder(adap);
            adap.Update(dset, "Fournisseur");
        }
    }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Voulez vous enregistrer les modifications ? ", "Confirmer modification", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    cb = new SqlCommandBuilder(adap);
                    adap.Update(dset, "Fournisseur");
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
