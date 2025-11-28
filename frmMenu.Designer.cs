namespace autoEcoleEF
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eleèveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gèrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.véhiculeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gèrerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leçonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.eleèveToolStripMenuItem,
            this.véhiculeToolStripMenuItem,
            this.leçonToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(887, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(76, 29);
            this.toolStripMenuItem1.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.quitterToolStripMenuItem.Text = "Quitter";
            // 
            // eleèveToolStripMenuItem
            // 
            this.eleèveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gèrerToolStripMenuItem});
            this.eleèveToolStripMenuItem.Name = "eleèveToolStripMenuItem";
            this.eleèveToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.eleèveToolStripMenuItem.Text = "Elève";
            // 
            // gèrerToolStripMenuItem
            // 
            this.gèrerToolStripMenuItem.Name = "gèrerToolStripMenuItem";
            this.gèrerToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.gèrerToolStripMenuItem.Text = "Gèrer";
            this.gèrerToolStripMenuItem.Click += new System.EventHandler(this.gèrerToolStripMenuItem_Click);
            // 
            // véhiculeToolStripMenuItem
            // 
            this.véhiculeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gèrerToolStripMenuItem1,
            this.listeToolStripMenuItem});
            this.véhiculeToolStripMenuItem.Name = "véhiculeToolStripMenuItem";
            this.véhiculeToolStripMenuItem.Size = new System.Drawing.Size(90, 29);
            this.véhiculeToolStripMenuItem.Text = "Véhicule";
            // 
            // gèrerToolStripMenuItem1
            // 
            this.gèrerToolStripMenuItem1.Name = "gèrerToolStripMenuItem1";
            this.gèrerToolStripMenuItem1.Size = new System.Drawing.Size(140, 30);
            this.gèrerToolStripMenuItem1.Text = "Gèrer";
            this.gèrerToolStripMenuItem1.Click += new System.EventHandler(this.gèrerToolStripMenuItem1_Click);
            // 
            // listeToolStripMenuItem
            // 
            this.listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            this.listeToolStripMenuItem.Size = new System.Drawing.Size(140, 30);
            this.listeToolStripMenuItem.Text = "Liste";
            // 
            // leçonToolStripMenuItem
            // 
            this.leçonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.validerToolStripMenuItem});
            this.leçonToolStripMenuItem.Name = "leçonToolStripMenuItem";
            this.leçonToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.leçonToolStripMenuItem.Text = "Leçon";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // validerToolStripMenuItem
            // 
            this.validerToolStripMenuItem.Name = "validerToolStripMenuItem";
            this.validerToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.validerToolStripMenuItem.Text = "Valider";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 550);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Gestion des leçons de conduite";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eleèveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem véhiculeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leçonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gèrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gèrerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validerToolStripMenuItem;
    }
}

