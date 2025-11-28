namespace autoEcoleEF
{
    partial class frmGererEleve
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGererEleve));
            this.labNumEleve = new System.Windows.Forms.Label();
            this.labNomEleve = new System.Windows.Forms.Label();
            this.labPrenomEleve = new System.Windows.Forms.Label();
            this.labAdresseEleve = new System.Windows.Forms.Label();
            this.labDatInscEleve = new System.Windows.Forms.Label();
            this.labHoraire = new System.Windows.Forms.Label();
            this.txtNumEleve = new System.Windows.Forms.TextBox();
            this.txtNomEleve = new System.Windows.Forms.TextBox();
            this.txtPrenomEleve = new System.Windows.Forms.TextBox();
            this.txtAdresseEleve = new System.Windows.Forms.TextBox();
            this.dateInscriptionEleve = new System.Windows.Forms.DateTimePicker();
            this.crediHoraireEleve = new System.Windows.Forms.ComboBox();
            this.bdgNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.supprimerEleve = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveNewEleve = new System.Windows.Forms.ToolStripButton();
            this.bdgSourceEleve = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bdgNav)).BeginInit();
            this.bdgNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).BeginInit();
            this.SuspendLayout();
            // 
            // labNumEleve
            // 
            this.labNumEleve.AutoSize = true;
            this.labNumEleve.Location = new System.Drawing.Point(62, 55);
            this.labNumEleve.Name = "labNumEleve";
            this.labNumEleve.Size = new System.Drawing.Size(55, 16);
            this.labNumEleve.TabIndex = 0;
            this.labNumEleve.Text = "Numéro";
            // 
            // labNomEleve
            // 
            this.labNomEleve.AutoSize = true;
            this.labNomEleve.Location = new System.Drawing.Point(62, 122);
            this.labNomEleve.Name = "labNomEleve";
            this.labNomEleve.Size = new System.Drawing.Size(36, 16);
            this.labNomEleve.TabIndex = 1;
            this.labNomEleve.Text = "Nom";
            // 
            // labPrenomEleve
            // 
            this.labPrenomEleve.AutoSize = true;
            this.labPrenomEleve.Location = new System.Drawing.Point(62, 177);
            this.labPrenomEleve.Name = "labPrenomEleve";
            this.labPrenomEleve.Size = new System.Drawing.Size(54, 16);
            this.labPrenomEleve.TabIndex = 2;
            this.labPrenomEleve.Text = "Prénom";
            // 
            // labAdresseEleve
            // 
            this.labAdresseEleve.AutoSize = true;
            this.labAdresseEleve.Location = new System.Drawing.Point(62, 249);
            this.labAdresseEleve.Name = "labAdresseEleve";
            this.labAdresseEleve.Size = new System.Drawing.Size(58, 16);
            this.labAdresseEleve.TabIndex = 3;
            this.labAdresseEleve.Text = "Adresse";
            // 
            // labDatInscEleve
            // 
            this.labDatInscEleve.AutoSize = true;
            this.labDatInscEleve.Location = new System.Drawing.Point(62, 320);
            this.labDatInscEleve.Name = "labDatInscEleve";
            this.labDatInscEleve.Size = new System.Drawing.Size(102, 16);
            this.labDatInscEleve.TabIndex = 4;
            this.labDatInscEleve.Text = "Dat d\'inscription";
            // 
            // labHoraire
            // 
            this.labHoraire.AutoSize = true;
            this.labHoraire.Location = new System.Drawing.Point(62, 382);
            this.labHoraire.Name = "labHoraire";
            this.labHoraire.Size = new System.Drawing.Size(90, 16);
            this.labHoraire.TabIndex = 5;
            this.labHoraire.Text = "Crédit Horaire";
            // 
            // txtNumEleve
            // 
            this.txtNumEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "id", true));
            this.txtNumEleve.Location = new System.Drawing.Point(175, 55);
            this.txtNumEleve.Name = "txtNumEleve";
            this.txtNumEleve.ReadOnly = true;
            this.txtNumEleve.Size = new System.Drawing.Size(116, 22);
            this.txtNumEleve.TabIndex = 6;
            // 
            // txtNomEleve
            // 
            this.txtNomEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "nom", true));
            this.txtNomEleve.Location = new System.Drawing.Point(175, 122);
            this.txtNomEleve.Name = "txtNomEleve";
            this.txtNomEleve.Size = new System.Drawing.Size(116, 22);
            this.txtNomEleve.TabIndex = 7;
            // 
            // txtPrenomEleve
            // 
            this.txtPrenomEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "prenom", true));
            this.txtPrenomEleve.Location = new System.Drawing.Point(175, 177);
            this.txtPrenomEleve.Name = "txtPrenomEleve";
            this.txtPrenomEleve.Size = new System.Drawing.Size(116, 22);
            this.txtPrenomEleve.TabIndex = 8;
            // 
            // txtAdresseEleve
            // 
            this.txtAdresseEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "adresse", true));
            this.txtAdresseEleve.Location = new System.Drawing.Point(175, 246);
            this.txtAdresseEleve.Name = "txtAdresseEleve";
            this.txtAdresseEleve.Size = new System.Drawing.Size(276, 22);
            this.txtAdresseEleve.TabIndex = 9;
            // 
            // dateInscriptionEleve
            // 
            this.dateInscriptionEleve.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdgSourceEleve, "dateInscription", true));
            this.dateInscriptionEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "dateInscription", true));
            this.dateInscriptionEleve.Location = new System.Drawing.Point(186, 320);
            this.dateInscriptionEleve.Name = "dateInscriptionEleve";
            this.dateInscriptionEleve.Size = new System.Drawing.Size(265, 22);
            this.dateInscriptionEleve.TabIndex = 10;
            // 
            // crediHoraireEleve
            // 
            this.crediHoraireEleve.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceEleve, "creditHoraire", true));
            this.crediHoraireEleve.FormattingEnabled = true;
            this.crediHoraireEleve.Location = new System.Drawing.Point(186, 382);
            this.crediHoraireEleve.Name = "crediHoraireEleve";
            this.crediHoraireEleve.Size = new System.Drawing.Size(121, 24);
            this.crediHoraireEleve.TabIndex = 11;
            // 
            // bdgNav
            // 
            this.bdgNav.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdgNav.BindingSource = this.bdgSourceEleve;
            this.bdgNav.CountItem = this.bindingNavigatorCountItem;
            this.bdgNav.DeleteItem = this.supprimerEleve;
            this.bdgNav.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdgNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.supprimerEleve,
            this.saveNewEleve});
            this.bdgNav.Location = new System.Drawing.Point(0, 0);
            this.bdgNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgNav.Name = "bdgNav";
            this.bdgNav.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgNav.Size = new System.Drawing.Size(800, 31);
            this.bdgNav.TabIndex = 12;
            this.bdgNav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(57, 28);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // supprimerEleve
            // 
            this.supprimerEleve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.supprimerEleve.Image = ((System.Drawing.Image)(resources.GetObject("supprimerEleve.Image")));
            this.supprimerEleve.Name = "supprimerEleve";
            this.supprimerEleve.RightToLeftAutoMirrorImage = true;
            this.supprimerEleve.Size = new System.Drawing.Size(29, 28);
            this.supprimerEleve.Text = "Supprimer";
            this.supprimerEleve.Click += new System.EventHandler(this.supprimerEleve_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // saveNewEleve
            // 
            this.saveNewEleve.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveNewEleve.Image = ((System.Drawing.Image)(resources.GetObject("saveNewEleve.Image")));
            this.saveNewEleve.ImageTransparentColor = System.Drawing.Color.MediumBlue;
            this.saveNewEleve.Name = "saveNewEleve";
            this.saveNewEleve.Size = new System.Drawing.Size(29, 28);
            this.saveNewEleve.Text = "Enregistrer";
            this.saveNewEleve.Click += new System.EventHandler(this.saveNewEleve_Click);
            // 
            // bdgSourceEleve
            // 
            this.bdgSourceEleve.DataSource = typeof(autoEcoleEF.eleve);
            // 
            // frmGererEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdgNav);
            this.Controls.Add(this.crediHoraireEleve);
            this.Controls.Add(this.dateInscriptionEleve);
            this.Controls.Add(this.txtAdresseEleve);
            this.Controls.Add(this.txtPrenomEleve);
            this.Controls.Add(this.txtNomEleve);
            this.Controls.Add(this.txtNumEleve);
            this.Controls.Add(this.labHoraire);
            this.Controls.Add(this.labDatInscEleve);
            this.Controls.Add(this.labAdresseEleve);
            this.Controls.Add(this.labPrenomEleve);
            this.Controls.Add(this.labNomEleve);
            this.Controls.Add(this.labNumEleve);
            this.Name = "frmGererEleve";
            this.Text = "Gèrer Elève";
            ((System.ComponentModel.ISupportInitialize)(this.bdgNav)).EndInit();
            this.bdgNav.ResumeLayout(false);
            this.bdgNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceEleve)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labNumEleve;
        private System.Windows.Forms.Label labNomEleve;
        private System.Windows.Forms.Label labPrenomEleve;
        private System.Windows.Forms.Label labAdresseEleve;
        private System.Windows.Forms.Label labDatInscEleve;
        private System.Windows.Forms.Label labHoraire;
        private System.Windows.Forms.TextBox txtNumEleve;
        private System.Windows.Forms.TextBox txtNomEleve;
        private System.Windows.Forms.TextBox txtPrenomEleve;
        private System.Windows.Forms.TextBox txtAdresseEleve;
        private System.Windows.Forms.DateTimePicker dateInscriptionEleve;
        private System.Windows.Forms.ComboBox crediHoraireEleve;
        private System.Windows.Forms.BindingSource bdgSourceEleve;
        private System.Windows.Forms.BindingNavigator bdgNav;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton supprimerEleve;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton saveNewEleve;
    }
}