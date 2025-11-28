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
    public partial class frmMenu : Form
    {
        private autoecoleEntities MesDonneesEF {  get; set; }
        public frmMenu()
        {
            InitializeComponent();
            this.MesDonneesEF = new autoecoleEntities();
        }

        private void gèrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGererEleve f = new frmGererEleve(this.MesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void gèrerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmVehicule v = new frmVehicule(this.MesDonneesEF);
            v.MdiParent = this;
            v.AutoScroll = true;
            v.Show();
        }
    }
}
