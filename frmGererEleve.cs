using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace autoEcoleEF
{
    public partial class frmGererEleve : Form
    {
        private autoecoleEntities mesDonneesEF;
        public frmGererEleve(autoecoleEntities mesDonneesEF)
        {
            InitializeComponent();
            for(int i = 0; i<30;  i++)
                this.crediHoraireEleve.Items.Add(i);
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSourceEleve.DataSource = mesDonneesEF.eleves.ToList();
        }

        private int createNewId(){
            eleve dernierEleve = (from el in this.mesDonneesEF.eleves
                              orderby el.id descending
                              select el).First();
            return dernierEleve.id + 1;
        }

        private eleve NewEleve()
        {
            eleve newEleve = new eleve();
            newEleve.id = Convert.ToInt16(txtNumEleve.Text);
            newEleve.nom = txtNomEleve.Text;
            newEleve.prenom = txtPrenomEleve.Text;
            newEleve.adresse = txtAdresseEleve.Text;
            newEleve.dateInscription = dateInscriptionEleve.Value;

            return newEleve;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.txtNumEleve.Text = this.createNewId().ToString();
        }

        private void saveNewEleve_Click(object sender, EventArgs e)
        {
            this.bdgSourceEleve.EndEdit();
            try
            {
                this.mesDonneesEF.eleves.Add(NewEleve());
                this.mesDonneesEF.SaveChanges();
                MessageBox.Show("Enregistrement validé");
            }catch(Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : \n" + ex.Message);
            }
        }

        private void supprimerEleve_Click(object sender, EventArgs e)
        {
            using (var context = new autoecoleEntities())
            {
                var idASupprimer = Convert.ToInt16(txtNumEleve.Text);
                var entitieASupprimer = context.eleves.FirstOrDefault(el => el.id == idASupprimer);
                try
                {
                    if (entitieASupprimer != null)
                    {
                        context.eleves.Remove(entitieASupprimer);
                        context.SaveChanges();
                        bdgSourceEleve.RemoveCurrent();
                        MessageBox.Show("Elève supprimé ");
                    }
                    else
                    {
                        MessageBox.Show("Elève non trouvé");
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    MessageBox.Show($"Erreur lors de la suppression {ex.Message}");
                }
            }
        }
    }
}
