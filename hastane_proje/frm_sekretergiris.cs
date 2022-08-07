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
    public partial class frm_sekretergiris : Form
    {
        public frm_sekretergiris()
        {
            InitializeComponent();
        }

        
        sqlbaglantısı bgl = new sqlbaglantısı();

        private void btngiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekretertc=@p1 and sekretersifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            komut.Parameters.AddWithValue("@p2", txtsifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frm_sekreterdetay fr = new frm_sekreterdetay();
                fr.sekretertc = msktc.Text;
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
