using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace hastane_proje
{
    public partial class frm_hastagiris : Form
    {
        public frm_hastagiris()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_hastakayıt fr = new frm_hastakayıt();
            fr.Show();

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hastalar where hastatc=@p1 and hastasifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                hastadetay fr = new hastadetay();
                fr.tc = msktc.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ya da Şifre", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            bgl.baglanti().Close();
        }
    }
}
