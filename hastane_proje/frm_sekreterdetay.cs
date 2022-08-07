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
    public partial class frm_sekreterdetay : Form
    {
        public frm_sekreterdetay()
        {
            InitializeComponent();
        }

        public string sekretertc;

        sqlbaglantısı bgl = new sqlbaglantısı();

        private void frm_sekreterdetay_Load(object sender, EventArgs e)
        {
            lblsekretertc.Text = sekretertc;
            //ad soyad
            SqlCommand komut1 = new SqlCommand(" select sekreteradsoyad from tbl_sekreter where sekretertc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lblsekretertc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblsekreteradsoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();
          
            // brans yazdırma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar", bgl.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //doktor yazdırma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorad + ' ' +doktorsoyad) as 'Doktorlar', doktorbrans from tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;

            //brans combaboxa ekleme

            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (randevutarih, randevusaat, randevubrans, randevudoktor) values (@r1, @r2, @r3, @r4)" , bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", msktarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", msksaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmbbrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbdoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();

            //comboboxa doktor ekleme

            SqlCommand komut = new SqlCommand("select doktorad, doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbbrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbdoktor.Items.Add(dr[0] + " " + dr[1]);
            }
        }

        private void btnduyuruolustur_Click(object sender, EventArgs e)
        {
            
            SqlCommand komut = new SqlCommand("insert into tbl_duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchduyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void btndoktorpanel_Click(object sender, EventArgs e)
        {
            frm_doktorpaneli frdoktor = new frm_doktorpaneli();
            frdoktor.Show();
        }

        private void btnbranspanel_Click(object sender, EventArgs e)
        {
            frm_brans frb = new frm_brans();
            frb.Show();
        }

        private void btnrandevuliste_Click(object sender, EventArgs e)
        {
            frm_ranevulistesi frr = new frm_ranevulistesi();
            frr.Show();
        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            frm_duyurular frd = new frm_duyurular();
            frd.Show();

        }

        
    }
}
