namespace TP3
{
    partial class Ajouter_une_facture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codeProduitLabel;
            System.Windows.Forms.Label nomProduitLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            this.btnQ1 = new System.Windows.Forms.Button();
            this.btnAjoutFact = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbClient = new System.Windows.Forms.ComboBox();
            this.grbligne = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTot = new System.Windows.Forms.TextBox();
            this.txtRet = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codeFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFactureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.retenueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDStockDataSet = new TP3.BDStockDataSet();
            this.txtQt = new System.Windows.Forms.TextBox();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.cmbProd = new System.Windows.Forms.ComboBox();
            this.factureTableAdapter = new TP3.BDStockDataSetTableAdapters.FactureTableAdapter();
            codeProduitLabel = new System.Windows.Forms.Label();
            nomProduitLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grbligne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDStockDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // codeProduitLabel
            // 
            codeProduitLabel.AutoSize = true;
            codeProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            codeProduitLabel.Location = new System.Drawing.Point(185, 170);
            codeProduitLabel.Name = "codeProduitLabel";
            codeProduitLabel.Size = new System.Drawing.Size(60, 20);
            codeProduitLabel.TabIndex = 20;
            codeProduitLabel.Text = "Client:";
            // 
            // nomProduitLabel
            // 
            nomProduitLabel.AutoSize = true;
            nomProduitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            nomProduitLabel.Location = new System.Drawing.Point(192, 206);
            nomProduitLabel.Name = "nomProduitLabel";
            nomProduitLabel.Size = new System.Drawing.Size(53, 20);
            nomProduitLabel.TabIndex = 21;
            nomProduitLabel.Text = "Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label2.Location = new System.Drawing.Point(16, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 20);
            label2.TabIndex = 21;
            label2.Text = "Produit:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label3.Location = new System.Drawing.Point(207, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(81, 20);
            label3.TabIndex = 22;
            label3.Text = "Prix Unit:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label4.Location = new System.Drawing.Point(427, 37);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(83, 20);
            label4.TabIndex = 23;
            label4.Text = "Quantité:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label5.Location = new System.Drawing.Point(215, 356);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(121, 20);
            label5.TabIndex = 49;
            label5.Text = "Total Facture:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            label6.Location = new System.Drawing.Point(31, 358);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(83, 20);
            label6.TabIndex = 50;
            label6.Text = "Retenue:";
            // 
            // btnQ1
            // 
            this.btnQ1.Location = new System.Drawing.Point(402, 254);
            this.btnQ1.Name = "btnQ1";
            this.btnQ1.Size = new System.Drawing.Size(109, 50);
            this.btnQ1.TabIndex = 42;
            this.btnQ1.Text = "Quitter";
            this.btnQ1.UseVisualStyleBackColor = true;
            // 
            // btnAjoutFact
            // 
            this.btnAjoutFact.Location = new System.Drawing.Point(235, 254);
            this.btnAjoutFact.Name = "btnAjoutFact";
            this.btnAjoutFact.Size = new System.Drawing.Size(110, 50);
            this.btnAjoutFact.TabIndex = 38;
            this.btnAjoutFact.Text = "Ajouter";
            this.btnAjoutFact.UseVisualStyleBackColor = true;
            this.btnAjoutFact.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 140);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP3.Properties.Resources.iconfinder_bill_416404;
            this.pictureBox1.Location = new System.Drawing.Point(35, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Creer Facture ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(283, 205);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 43;
            // 
            // cmbClient
            // 
            this.cmbClient.FormattingEnabled = true;
            this.cmbClient.Location = new System.Drawing.Point(283, 172);
            this.cmbClient.Name = "cmbClient";
            this.cmbClient.Size = new System.Drawing.Size(200, 21);
            this.cmbClient.TabIndex = 44;
            this.cmbClient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grbligne
            // 
            this.grbligne.Controls.Add(this.button3);
            this.grbligne.Controls.Add(this.button2);
            this.grbligne.Controls.Add(this.button1);
            this.grbligne.Controls.Add(this.txtTot);
            this.grbligne.Controls.Add(this.txtRet);
            this.grbligne.Controls.Add(label6);
            this.grbligne.Controls.Add(label5);
            this.grbligne.Controls.Add(this.dataGridView1);
            this.grbligne.Controls.Add(this.txtQt);
            this.grbligne.Controls.Add(this.txtprix);
            this.grbligne.Controls.Add(this.cmbProd);
            this.grbligne.Controls.Add(label4);
            this.grbligne.Controls.Add(label3);
            this.grbligne.Controls.Add(label2);
            this.grbligne.Location = new System.Drawing.Point(12, 323);
            this.grbligne.Name = "grbligne";
            this.grbligne.Size = new System.Drawing.Size(676, 422);
            this.grbligne.TabIndex = 45;
            this.grbligne.TabStop = false;
            this.grbligne.Text = "Les Lignes";
            this.grbligne.Visible = false;
            this.grbligne.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(561, 190);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 26);
            this.button3.TabIndex = 55;
            this.button3.Text = "Supp Ligne";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(561, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 26);
            this.button2.TabIndex = 54;
            this.button2.Text = "Ajouter Ligne";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(546, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 53;
            this.button1.Text = "Enregistrer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtTot
            // 
            this.txtTot.Location = new System.Drawing.Point(335, 358);
            this.txtTot.Name = "txtTot";
            this.txtTot.ReadOnly = true;
            this.txtTot.Size = new System.Drawing.Size(100, 20);
            this.txtTot.TabIndex = 52;
            this.txtTot.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtRet
            // 
            this.txtRet.Location = new System.Drawing.Point(109, 358);
            this.txtRet.Name = "txtRet";
            this.txtRet.Size = new System.Drawing.Size(100, 20);
            this.txtRet.TabIndex = 51;
            this.txtRet.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeFactureDataGridViewTextBoxColumn,
            this.codeClientDataGridViewTextBoxColumn,
            this.dateFactureDataGridViewTextBoxColumn,
            this.retenueDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.factureBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(535, 246);
            this.dataGridView1.TabIndex = 48;
            // 
            // codeFactureDataGridViewTextBoxColumn
            // 
            this.codeFactureDataGridViewTextBoxColumn.DataPropertyName = "CodeFacture";
            this.codeFactureDataGridViewTextBoxColumn.HeaderText = "CodeFacture";
            this.codeFactureDataGridViewTextBoxColumn.Name = "codeFactureDataGridViewTextBoxColumn";
            // 
            // codeClientDataGridViewTextBoxColumn
            // 
            this.codeClientDataGridViewTextBoxColumn.DataPropertyName = "CodeClient";
            this.codeClientDataGridViewTextBoxColumn.HeaderText = "CodeClient";
            this.codeClientDataGridViewTextBoxColumn.Name = "codeClientDataGridViewTextBoxColumn";
            // 
            // dateFactureDataGridViewTextBoxColumn
            // 
            this.dateFactureDataGridViewTextBoxColumn.DataPropertyName = "DateFacture";
            this.dateFactureDataGridViewTextBoxColumn.HeaderText = "DateFacture";
            this.dateFactureDataGridViewTextBoxColumn.Name = "dateFactureDataGridViewTextBoxColumn";
            // 
            // retenueDataGridViewTextBoxColumn
            // 
            this.retenueDataGridViewTextBoxColumn.DataPropertyName = "Retenue";
            this.retenueDataGridViewTextBoxColumn.HeaderText = "Retenue";
            this.retenueDataGridViewTextBoxColumn.Name = "retenueDataGridViewTextBoxColumn";
            // 
            // factureBindingSource
            // 
            this.factureBindingSource.DataMember = "Facture";
            this.factureBindingSource.DataSource = this.bDStockDataSet;
            // 
            // bDStockDataSet
            // 
            this.bDStockDataSet.DataSetName = "BDStockDataSet";
            this.bDStockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtQt
            // 
            this.txtQt.Location = new System.Drawing.Point(516, 37);
            this.txtQt.Name = "txtQt";
            this.txtQt.Size = new System.Drawing.Size(100, 20);
            this.txtQt.TabIndex = 47;
            this.txtQt.TextChanged += new System.EventHandler(this.txtQt_TextChanged);
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(294, 37);
            this.txtprix.Name = "txtprix";
            this.txtprix.ReadOnly = true;
            this.txtprix.Size = new System.Drawing.Size(100, 20);
            this.txtprix.TabIndex = 46;
            // 
            // cmbProd
            // 
            this.cmbProd.FormattingEnabled = true;
            this.cmbProd.Location = new System.Drawing.Point(82, 39);
            this.cmbProd.Name = "cmbProd";
            this.cmbProd.Size = new System.Drawing.Size(115, 21);
            this.cmbProd.TabIndex = 45;
            this.cmbProd.SelectedIndexChanged += new System.EventHandler(this.cmbProd_SelectedIndexChanged);
            // 
            // factureTableAdapter
            // 
            this.factureTableAdapter.ClearBeforeFill = true;
            // 
            // Ajouter_une_facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 749);
            this.Controls.Add(this.grbligne);
            this.Controls.Add(codeProduitLabel);
            this.Controls.Add(this.cmbClient);
            this.Controls.Add(nomProduitLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnQ1);
            this.Controls.Add(this.btnAjoutFact);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ajouter_une_facture";
            this.Text = "Ajouter Facture";
            this.Load += new System.EventHandler(this.Ajouter_une_facture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grbligne.ResumeLayout(false);
            this.grbligne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDStockDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQ1;
        private System.Windows.Forms.Button btnAjoutFact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbClient;
        private System.Windows.Forms.GroupBox grbligne;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtQt;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.ComboBox cmbProd;
        private BDStockDataSet bDStockDataSet;
        private System.Windows.Forms.BindingSource factureBindingSource;
        private BDStockDataSetTableAdapters.FactureTableAdapter factureTableAdapter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTot;
        private System.Windows.Forms.TextBox txtRet;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFactureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn retenueDataGridViewTextBoxColumn;
    }
}