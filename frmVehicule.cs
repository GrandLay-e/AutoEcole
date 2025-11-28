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
        private autoecoleEntities mesDonnees;
        public frmVehicule(autoecoleEntities mesDonnees)
        {
            InitializeComponent();
            this.mesDonnees = mesDonnees;
            this.bdgSourceVehicule.DataSource = mesDonnees.vehicules.ToList();
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
    }
}
