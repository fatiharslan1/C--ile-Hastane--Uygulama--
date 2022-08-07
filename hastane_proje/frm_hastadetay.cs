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
    public partial class hastadetay : Form
    {
        public hastadetay()
        {
            InitializeComponent();
        }

        public string tc;

        sqlbaglantısı bgl =  new sqlbaglantısı();

        private void hastadetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc; 
             // ad soyad yazdırma
            SqlCommand komut = new SqlCommand("select hastaad, hastasoyad from tbl_hastalar where hastatc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbladsoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // randevu geçmişi yazdırma

            DataTable dt = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select * from tbl_randevular where  hastatc=" + tc, bgl.baglanti());
            da2.Fill(dt);
            dataGridView1.DataSource = dt;


            // branşları yazdırma

            SqlCommand komut2 = new SqlCommand("select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbdoktor.Items.Clear();


            SqlCommand komut3 = new SqlCommand("select doktorad, doktorsoyad from tbl_doktorlar where doktorbrans =@b1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@b1", cmbbrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
               cmbdoktor.Items.Add(dr3[0]+ " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cmbdoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevubrans ='" + cmbbrans.Text + "'" + " and randevudoktor= '" + cmbdoktor.Text+ "' and randevudurum= 0", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_bilgiduzenle fr = new frm_bilgiduzenle();
            fr.tcno = lbltc.Text;
            fr.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();

        }

        private void btnrandevu_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum= 1, hastatc= @p1, hastasikayet= @p2 where randevuid = @p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lbltc.Text);
            komut.Parameters.AddWithValue("@p2", rchsikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
