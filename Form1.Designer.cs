namespace TP3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnFournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesFournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesProduitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rechercherUnProduitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creerUneFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherFactureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.listeDesFacturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.fournisseursToolStripMenuItem,
            this.produitsToolStripMenuItem,
            this.facturesToolStripMenuItem,
            this.sToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(720, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnClientToolStripMenuItem,
            this.toolStripSeparator4,
            this.listeDesClientToolStripMenuItem});
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // ajouterUnClientToolStripMenuItem
            // 
            this.ajouterUnClientToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_JD_01_2625526;
            this.ajouterUnClientToolStripMenuItem.Name = "ajouterUnClientToolStripMenuItem";
            this.ajouterUnClientToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.ajouterUnClientToolStripMenuItem.Text = "Ajouter un Client";
            this.ajouterUnClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnClientToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(161, 6);
            // 
            // listeDesClientToolStripMenuItem
            // 
            this.listeDesClientToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_JD_01_26255261;
            this.listeDesClientToolStripMenuItem.Name = "listeDesClientToolStripMenuItem";
            this.listeDesClientToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.listeDesClientToolStripMenuItem.Text = "Liste des Client";
            this.listeDesClientToolStripMenuItem.Click += new System.EventHandler(this.listeDesClientToolStripMenuItem_Click);
            // 
            // fournisseursToolStripMenuItem
            // 
            this.fournisseursToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnFournisseurToolStripMenuItem,
            this.toolStripSeparator1,
            this.listeDesFournisseursToolStripMenuItem});
            this.fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
            this.fournisseursToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.fournisseursToolStripMenuItem.Text = "Fournisseurs";
            // 
            // ajouterUnFournisseurToolStripMenuItem
            // 
            this.ajouterUnFournisseurToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_JD_06_2625478;
            this.ajouterUnFournisseurToolStripMenuItem.Name = "ajouterUnFournisseurToolStripMenuItem";
            this.ajouterUnFournisseurToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ajouterUnFournisseurToolStripMenuItem.Text = "Ajouter un Fournisseur";
            this.ajouterUnFournisseurToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnFournisseurToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // listeDesFournisseursToolStripMenuItem
            // 
            this.listeDesFournisseursToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_JD_06_2625478;
            this.listeDesFournisseursToolStripMenuItem.Name = "listeDesFournisseursToolStripMenuItem";
            this.listeDesFournisseursToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.listeDesFournisseursToolStripMenuItem.Text = "Liste des Fournisseurs";
            this.listeDesFournisseursToolStripMenuItem.Click += new System.EventHandler(this.listeDesFournisseursToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem
            // 
            this.produitsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterUnProduitToolStripMenuItem,
            this.listeDesProduitsToolStripMenuItem,
            this.toolStripSeparator2,
            this.rechercherUnProduitToolStripMenuItem});
            this.produitsToolStripMenuItem.Name = "produitsToolStripMenuItem";
            this.produitsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.produitsToolStripMenuItem.Text = "Produits";
            // 
            // ajouterUnProduitToolStripMenuItem
            // 
            this.ajouterUnProduitToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_send_box_45273;
            this.ajouterUnProduitToolStripMenuItem.Name = "ajouterUnProduitToolStripMenuItem";
            this.ajouterUnProduitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.ajouterUnProduitToolStripMenuItem.Text = "Ajouter un Produit";
            this.ajouterUnProduitToolStripMenuItem.Click += new System.EventHandler(this.ajouterUnProduitToolStripMenuItem_Click);
            // 
            // listeDesProduitsToolStripMenuItem
            // 
            this.listeDesProduitsToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_send_box_45273;
            this.listeDesProduitsToolStripMenuItem.Name = "listeDesProduitsToolStripMenuItem";
            this.listeDesProduitsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.listeDesProduitsToolStripMenuItem.Text = "Liste des Produits";
            this.listeDesProduitsToolStripMenuItem.Click += new System.EventHandler(this.listeDesProduitsToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // rechercherUnProduitToolStripMenuItem
            // 
            this.rechercherUnProduitToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_system_search_118797;
            this.rechercherUnProduitToolStripMenuItem.Name = "rechercherUnProduitToolStripMenuItem";
            this.rechercherUnProduitToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.rechercherUnProduitToolStripMenuItem.Text = "Rechercher un Produit";
            this.rechercherUnProduitToolStripMenuItem.Click += new System.EventHandler(this.rechercherUnProduitToolStripMenuItem_Click);
            // 
            // facturesToolStripMenuItem
            // 
            this.facturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creerUneFactureToolStripMenuItem,
            this.afficherFactureToolStripMenuItem,
            this.toolStripSeparator3,
            this.listeDesFacturesToolStripMenuItem});
            this.facturesToolStripMenuItem.Name = "facturesToolStripMenuItem";
            this.facturesToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.facturesToolStripMenuItem.Text = "Factures";
            // 
            // creerUneFactureToolStripMenuItem
            // 
            this.creerUneFactureToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_file_powerpoint_285681;
            this.creerUneFactureToolStripMenuItem.Name = "creerUneFactureToolStripMenuItem";
            this.creerUneFactureToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.creerUneFactureToolStripMenuItem.Text = "Creer une Facture";
            // 
            // afficherFactureToolStripMenuItem
            // 
            this.afficherFactureToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_file_powerpoint_285681;
            this.afficherFactureToolStripMenuItem.Name = "afficherFactureToolStripMenuItem";
            this.afficherFactureToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.afficherFactureToolStripMenuItem.Text = "Afficher Facture";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(164, 6);
            // 
            // listeDesFacturesToolStripMenuItem
            // 
            this.listeDesFacturesToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_file_powerpoint_285681;
            this.listeDesFacturesToolStripMenuItem.Name = "listeDesFacturesToolStripMenuItem";
            this.listeDesFacturesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.listeDesFacturesToolStripMenuItem.Text = "Liste des Factures";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Image = global::TP3.Properties.Resources.iconfinder_Help_1493288;
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(28, 20);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TP3.Properties.Resources.better_call_saul_saul_goodman_jimmy_mcgill_105915_1920x1080;
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 406);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 436);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GESTION DU STOCK";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem listeDesClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnFournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem listeDesFournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesProduitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem rechercherUnProduitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creerUneFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherFactureToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem listeDesFacturesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

