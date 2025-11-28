using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class frmVehicule : Form
    {
        private autoecoleEntities mesDonneesEF;
        public frmVehicule(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceVehicule.DataSource = mesDonneesEF.vehicules.ToList();
        }

        private void frmVehicule_Load(object sender, EventArgs e)
        {}

        private void updateRadioButtons()
        {
            var acutelVehicule = (vehicule)bdgSourceVehicule.Current;
            if(acutelVehicule != null)
            {
                if (acutelVehicule.enEtat == 0)
                {
                    radioEnPanne.Checked = true;
                    radioEnFonction.Checked = false;
                }
                else
                {
                    radioEnFonction.Checked = true;
                    radioEnPanne.Checked = false;
                }
                    
            }
        }
                             
        private void bdgNavVehicule_RefreshItems(object sender, EventArgs e)
        {
            updateRadioButtons();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            txtCouleurVéhicule.ReadOnly = false;
            txtModeleVehicule.ReadOnly = false;
            txtNumVehicule.ReadOnly=false;
        }

        private vehicule NewVehicule()
        {
            vehicule nVehicule = new vehicule();
            nVehicule.modele = txtModeleVehicule.Text;
            nVehicule.couleur = txtCouleurVéhicule.Text;
            nVehicule.enEtat = (short)(radioEnFonction.Checked ? 1 : 0);

            return nVehicule;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.bdgSourceVehicule.EndEdit();
            try{
                this.mesDonneesEF.vehicules.Add(NewVehicule());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Vehicule enregistré avec succés");
            }catch(Exception ex){
                MessageBox.Show($"Erreur lors de l'enregistrement ! {ex.Message}");
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            var acutelVehicule = (vehicule)bdgSourceVehicule.Current;

        }
    }
}
