using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hastane_proje
{
    public partial class frmgirisler : Form
    {
        public frmgirisler()
        {
            InitializeComponent();
        }

        private void btnhasta_Click(object sender, EventArgs e)
        {
            frm_hastagiris fr = new frm_hastagiris();
            fr.Show();
            this.Hide();
        }

        private void btndoktor_Click(object sender, EventArgs e)
        {
            frm_doktorgiris fr = new frm_doktorgiris();
            fr.Show();
            this.Hide();
        }

        private void btnsekreter_Click(object sender, EventArgs e)
        {
            frm_sekretergiris fr = new frm_sekretergiris();
            fr.Show();
            this.Hide();
        }
    }
}
