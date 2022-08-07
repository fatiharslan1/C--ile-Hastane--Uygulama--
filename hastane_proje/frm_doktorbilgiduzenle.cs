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
    public partial class frm_doktorbilgiduzenle : Form
    {
        public frm_doktorbilgiduzenle()
        {
            InitializeComponent();
        }

        sqlbaglantısı bgl = new sqlbaglantısı();
        public string TCNO;

        private void frm_doktorbilgiduzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = TCNO;

            SqlCommand komut = new SqlCommand(" select * from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msktc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                cmbbrans.Text = dr[3].ToString();
                txtsifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktorlar set doktorad=@p1, doktorsoyad=@p2, doktorbrans=@p3, doktorsifre=@p4 where doktortc=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbbrans.Text);
            komut.Parameters.AddWithValue("@p4", txtsifre.Text);
            komut.Parameters.AddWithValue("@p5", msktc.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();

        }
    }
}
