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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDStockDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDStockDataSet.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.bDStockDataSet.Client);

        }

        private void telephoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void codeClientLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomLabel_Click(object sender, EventArgs e)
        {

        }

        private void nomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void prenomLabel_Click(object sender, EventArgs e)
        {

        }

        private void prenomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void adresseLabel_Click(object sender, EventArgs e)
        {

        }

        private void adresseTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeClientTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
