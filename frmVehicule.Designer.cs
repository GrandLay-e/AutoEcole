namespace autoEcoleEF
{
    partial class frmVehicule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVehicule));
            this.lblNumVehicule = new System.Windows.Forms.Label();
            this.lblModeleVehicule = new System.Windows.Forms.Label();
            this.lblCouleurVehicule = new System.Windows.Forms.Label();
            this.lblEtatVehicule = new System.Windows.Forms.Label();
            this.radioEnFonction = new System.Windows.Forms.RadioButton();
            this.bdgSourceVehicule = new System.Windows.Forms.BindingSource(this.components);
            this.radioEnPanne = new System.Windows.Forms.RadioButton();
            this.txtNumVehicule = new System.Windows.Forms.TextBox();
            this.txtModeleVehicule = new System.Windows.Forms.TextBox();
            this.txtCouleurVéhicule = new System.Windows.Forms.TextBox();
            this.bdgNavVehicule = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVehicule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgNavVehicule)).BeginInit();
            this.bdgNavVehicule.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumVehicule
            // 
            this.lblNumVehicule.AutoSize = true;
            this.lblNumVehicule.Location = new System.Drawing.Point(78, 104);
            this.lblNumVehicule.Name = "lblNumVehicule";
            this.lblNumVehicule.Size = new System.Drawing.Size(55, 16);
            this.lblNumVehicule.TabIndex = 1;
            this.lblNumVehicule.Text = "Numéro";
            // 
            // lblModeleVehicule
            // 
            this.lblModeleVehicule.AutoSize = true;
            this.lblModeleVehicule.Location = new System.Drawing.Point(78, 165);
            this.lblModeleVehicule.Name = "lblModeleVehicule";
            this.lblModeleVehicule.Size = new System.Drawing.Size(53, 16);
            this.lblModeleVehicule.TabIndex = 2;
            this.lblModeleVehicule.Text = "Modèle";
            // 
            // lblCouleurVehicule
            // 
            this.lblCouleurVehicule.AutoSize = true;
            this.lblCouleurVehicule.Location = new System.Drawing.Point(78, 232);
            this.lblCouleurVehicule.Name = "lblCouleurVehicule";
            this.lblCouleurVehicule.Size = new System.Drawing.Size(53, 16);
            this.lblCouleurVehicule.TabIndex = 3;
            this.lblCouleurVehicule.Text = "Couleur";
            // 
            // lblEtatVehicule
            // 
            this.lblEtatVehicule.AutoSize = true;
            this.lblEtatVehicule.Location = new System.Drawing.Point(294, 299);
            this.lblEtatVehicule.Name = "lblEtatVehicule";
            this.lblEtatVehicule.Size = new System.Drawing.Size(85, 16);
            this.lblEtatVehicule.TabIndex = 4;
            this.lblEtatVehicule.Text = "Etat Vehicule";
            // 
            // radioEnFonction
            // 
            this.radioEnFonction.AutoSize = true;
            this.radioEnFonction.Checked = true;
            this.radioEnFonction.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bdgSourceVehicule, "enEtat", true));
            this.radioEnFonction.Location = new System.Drawing.Point(128, 362);
            this.radioEnFonction.Name = "radioEnFonction";
            this.radioEnFonction.Size = new System.Drawing.Size(98, 20);
            this.radioEnFonction.TabIndex = 5;
            this.radioEnFonction.TabStop = true;
            this.radioEnFonction.Text = "En Fonction";
            this.radioEnFonction.UseVisualStyleBackColor = true;
            // 
            // bdgSourceVehicule
            // 
            this.bdgSourceVehicule.DataSource = typeof(autoEcoleEF.vehicule);
            // 
            // radioEnPanne
            // 
            this.radioEnPanne.AutoSize = true;
            this.radioEnPanne.Location = new System.Drawing.Point(420, 362);
            this.radioEnPanne.Name = "radioEnPanne";
            this.radioEnPanne.Size = new System.Drawing.Size(86, 20);
            this.radioEnPanne.TabIndex = 6;
            this.radioEnPanne.TabStop = true;
            this.radioEnPanne.Text = "En Panne";
            this.radioEnPanne.UseVisualStyleBackColor = true;
            // 
            // txtNumVehicule
            // 
            this.txtNumVehicule.AllowDrop = true;
            this.txtNumVehicule.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceVehicule, "numImma", true));
            this.txtNumVehicule.Location = new System.Drawing.Point(195, 101);
            this.txtNumVehicule.Name = "txtNumVehicule";
            this.txtNumVehicule.ReadOnly = true;
            this.txtNumVehicule.Size = new System.Drawing.Size(100, 22);
            this.txtNumVehicule.TabIndex = 7;
            // 
            // txtModeleVehicule
            // 
            this.txtModeleVehicule.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceVehicule, "modele", true));
            this.txtModeleVehicule.Location = new System.Drawing.Point(195, 162);
            this.txtModeleVehicule.Name = "txtModeleVehicule";
            this.txtModeleVehicule.ReadOnly = true;
            this.txtModeleVehicule.Size = new System.Drawing.Size(100, 22);
            this.txtModeleVehicule.TabIndex = 8;
            // 
            // txtCouleurVéhicule
            // 
            this.txtCouleurVéhicule.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgSourceVehicule, "couleur", true));
            this.txtCouleurVéhicule.Location = new System.Drawing.Point(195, 232);
            this.txtCouleurVéhicule.Name = "txtCouleurVéhicule";
            this.txtCouleurVéhicule.ReadOnly = true;
            this.txtCouleurVéhicule.Size = new System.Drawing.Size(100, 22);
            this.txtCouleurVéhicule.TabIndex = 9;
            // 
            // bdgNavVehicule
            // 
            this.bdgNavVehicule.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bdgNavVehicule.BindingSource = this.bdgSourceVehicule;
            this.bdgNavVehicule.CountItem = this.bindingNavigatorCountItem;
            this.bdgNavVehicule.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bdgNavVehicule.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bdgNavVehicule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem});
            this.bdgNavVehicule.Location = new System.Drawing.Point(0, 0);
            this.bdgNavVehicule.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bdgNavVehicule.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bdgNavVehicule.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bdgNavVehicule.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bdgNavVehicule.Name = "bdgNavVehicule";
            this.bdgNavVehicule.PositionItem = this.bindingNavigatorPositionItem;
            this.bdgNavVehicule.Size = new System.Drawing.Size(800, 31);
            this.bdgNavVehicule.TabIndex = 10;
            this.bdgNavVehicule.Text = "bindingNavigator1";
            this.bdgNavVehicule.RefreshItems += new System.EventHandler(this.bdgNavVehicule_RefreshItems);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 28);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
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
            // frmVehicule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bdgNavVehicule);
            this.Controls.Add(this.txtCouleurVéhicule);
            this.Controls.Add(this.txtModeleVehicule);
            this.Controls.Add(this.txtNumVehicule);
            this.Controls.Add(this.radioEnPanne);
            this.Controls.Add(this.radioEnFonction);
            this.Controls.Add(this.lblEtatVehicule);
            this.Controls.Add(this.lblCouleurVehicule);
            this.Controls.Add(this.lblModeleVehicule);
            this.Controls.Add(this.lblNumVehicule);
            this.Name = "frmVehicule";
            this.Text = "Vehicules";
            this.Load += new System.EventHandler(this.frmVehicule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdgSourceVehicule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgNavVehicule)).EndInit();
            this.bdgNavVehicule.ResumeLayout(false);
            this.bdgNavVehicule.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bdgSourceVehicule;
        private System.Windows.Forms.Label lblNumVehicule;
        private System.Windows.Forms.Label lblModeleVehicule;
        private System.Windows.Forms.Label lblCouleurVehicule;
        private System.Windows.Forms.Label lblEtatVehicule;
        private System.Windows.Forms.RadioButton radioEnFonction;
        private System.Windows.Forms.RadioButton radioEnPanne;
        private System.Windows.Forms.TextBox txtNumVehicule;
        private System.Windows.Forms.TextBox txtModeleVehicule;
        private System.Windows.Forms.TextBox txtCouleurVéhicule;
        private System.Windows.Forms.BindingNavigator bdgNavVehicule;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
    }
}